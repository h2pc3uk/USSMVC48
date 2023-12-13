using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.Models
{
    public class FormViewModel
    {
        public int FormId { get; set; }

        public List<QuestionResponseViewModel> Questions { get; set; }
        public FormViewModel()
        {
            Questions = new List<QuestionResponseViewModel>();
        }

        public List<Response> ToResponses(Guid surveySessionId)
        {
            var responses = new List<Response>();

            foreach (var question in Questions)
            {
                if (question.SelectedOptionIds.Any())
                {
                    // Handle multiple choice questions
                    foreach (var optionId in question.SelectedOptionIds)
                    {
                        responses.Add(CreateResponse(surveySessionId, question.QuestionId, optionId, question.AdditionalText));
                    }
                }
                else if (question.SelectedOptionId.HasValue)
                {
                    // Handle single choice question
                    responses.Add(CreateResponse(surveySessionId, question.QuestionId, question.SelectedOptionId.Value, question.AdditionalText));
                }
                else
                {
                    // Handle text input question
                    responses.Add(CreateResponse(surveySessionId, question.QuestionId, null, question.AdditionalText));
                }
            }

            return responses;
        }

        private Response CreateResponse(Guid surveySessionId, int questionId, int? optionId, string additionalText)
        {
            return new Response
            {
                SurveySessionID = surveySessionId,
                QuestionID = questionId,
                OptionID = optionId,
                AdditionalText = additionalText,
                CreatedTime = DateTime.Now
            };
        }

    }
}