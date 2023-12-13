using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using USSMVC48.Services;
using USSMVC48.Models;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Http.Results;
using USSMVC48.DTOs;


namespace USSMVC48.Controllers
{
    public class FormAPIController : ApiController
    {
        private readonly FormService _formService;

        public FormAPIController()
        {
            _formService = new FormService(new Data.USSMVC48Context());
        }

        [HttpGet]
        public IHttpActionResult ShowForm(int id = 1)
        {

            var questions = _formService.GetQuestionsWithOptionsByFormId(id);

            if(questions == null)
            {
                return NotFound();
            }

            var questionDTOs = questions.Select(q => new QuestionDTO
            {
                QuestionID = q.QuestionID,
                Text = q.Text,
                Options = q.Options.Select(o => new OptionDTO
                {
                    OptionID = o.OptionID,
                    Text = o.Text,
                    Type = o.Type,
                    SkipToQuestionID = o.SkipToQuestionID
                }).ToList(),
                IsMultipleChoice = q.IsMultipleChoice
            }).ToList();

            return Ok(questionDTOs);
        }

        [HttpPost]
        public IHttpActionResult SubmitForm([FromBody] List<QuestionDTO> questionDTOs)
        {
            if(questionDTOs == null)
            {
                return BadRequest("Question data is null");
            }

            var formViewModel = ConvertDTOsToFormViewModel(questionDTOs);

            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
                return BadRequest(string.Join(" ", errorMessage));

            }

            try
            {
                // Submit the responses
                Guid surveySessionId = Guid.NewGuid();

                var responses = formViewModel.ToResponses(surveySessionId);

                var validationResult = _formService.ValidateResponses(responses, formViewModel.FormId);

                if(!validationResult.IsValid)
                {
                    //string missingQuestionMessage = validationResult.MissingQuestionIds.Any() ? $"Missing responses for questions: {string.Join(", ", validationResult.MissingQuestionIds)}" : "Validation failed.";
                    var errorMessage = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));

                    return BadRequest(string.Join(" ", errorMessage));
                }

                _formService.SubmitResponse(responses, surveySessionId);
                
                return Ok("表單已成功傳送");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occurred: " +  ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
                return InternalServerError(ex);
            }
        }

        private FormViewModel ConvertDTOsToFormViewModel(List<QuestionDTO> questionDTOs)
        {
            FormViewModel formViewModel = new FormViewModel();

            foreach (var questionDto in questionDTOs)
            {
                QuestionResponseViewModel questionResponse = new QuestionResponseViewModel
                {
                    QuestionId = questionDto.QuestionID,
                    AdditionalText = questionDto.TextResponse
                };

                var selectedOptions = questionDto.Options.Where(o => o.IsSelected).Select(o => o.OptionID).ToList();
                if (selectedOptions.Count == 1)
                {
                    // Single selection
                    questionResponse.SelectedOptionId = selectedOptions.First();
                }
                else if (selectedOptions.Count > 1)
                {
                    // Multiple selections
                    questionResponse.SelectedOptionIds = selectedOptions;
                }

                formViewModel.Questions.Add(questionResponse);
            }
            return formViewModel;
        }

    }
}