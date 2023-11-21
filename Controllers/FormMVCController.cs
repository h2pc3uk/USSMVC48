using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using USSMVC48.Services;
using USSMVC48.Models;
using System.Data.Entity;

namespace USSMVC48.Controllers
{
    public class FormMVCController : Controller
    {
        private readonly FormService _formService;

        public FormMVCController()
        {
            _formService = new FormService(new Data.USSMVC48Context());
        }

        // GET: FormMVC
        public ActionResult Index()
        {
            return View();
        }

        [Route("FormMVC/showForm/{id:int}")]
        public ActionResult ShowForm(int? id)
        {
            System.Diagnostics.Debug.WriteLine($"formId: {id}");
            if (!id.HasValue) 
            {
                return Content("No FormID provided");
            }

            var questions = _formService.GetQuestionsWithOptionsByFormId(id.Value);
            
            if(questions == null || !questions.Any())
            {
                return RedirectToAction("Index");
            }

            ViewBag.FormID = id.Value;

            return View(questions);
        }

        [HttpPost]
        public JsonResult SubmitForm(FormViewModel formData)
        {
            
            if(formData == null)
            {
                return Json(new { success = false, message = "Form data is null." }, JsonRequestBehavior.AllowGet);
            }

            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
                return Json(new { success = false, message = string.Join(" ", errorMessage) });
            }


            // Submit the responses
            Guid surveySessionId = Guid.NewGuid();
            var responses = formData.ToResponses(surveySessionId);

            var validationResult = _formService.ValidateResponses(responses, formData.FormId);

            //if (!validationResult.IsValid)
            //{
            //    string message = "Please correct the errors. Missing responses for questions: " + String.Join(", ", validationResult.MissingQuestionIds);

            //    return Json(new { success = false, message = "Please correct the errors.", missingQuestionIds = validationResult.MissingQuestionIds });
            //}

            _formService.SubmitResponse(responses, surveySessionId);

            // Redirect to a confirmation page or display a success message
            return Json(new { success = true, message = "Responses submitted successfully" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DatabaseTest()
        {
            bool isConnected = _formService.TestDatabaseConnection();
            return Content($"Database connection test result: {isConnected}");
        }

        public ActionResult GetTestQuestions()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    QuestionID = 1,
                    Text = "Test Question",
                    Options = new List<Option>
                    {
                        new Option { OptionID = 1, Text = "Option 1" },
                        new Option { OptionID = 2, Text = "Option 2" }
                    }
                }
            };

            return View(questions);
        }

    }
}