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

        //[Route("FormMVC/showForm/{id:int}")]
        [Route("FormMVC/showForm")]
        public ActionResult ShowForm()
        {
            int id = 1;

            System.Diagnostics.Debug.WriteLine($"formId: {id}");
            var questions = _formService.GetQuestionsWithOptionsByFormId(id);

            ViewBag.FormID = id;

            return View(questions);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(FormViewModel formData)
        {
            // Log formData for debugging
            System.Diagnostics.Debug.WriteLine("Received form data: ");
            foreach (var question in formData.Questions)
            {
                System.Diagnostics.Debug.WriteLine($"Question ID: {question.QuestionId}, Text: {question.AdditionalText}");
            }

            if (formData == null)
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

            _formService.SubmitResponse(responses, surveySessionId);

            TempData["SuccessMessage"] = "表單已成功傳送";

            return RedirectToAction("ShowForm");
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