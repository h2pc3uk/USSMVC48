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

            if(Questions != null)
            {
                foreach (var question in Questions)
                {
                    // Initialize a new Response object
                    var response = new Response
                    {
                        SurveySessionID = surveySessionId,
                        QuestionID = question.QuestionId,
                        OptionID = question.SelectedOptionId,
                        AdditionalText = question.AdditionalText,
                        CreatedTime = DateTime.Now
                    };

                    // Optional: Add further validation or processing here
                    // For example, handling null or default values differently

                    // Add the response to the list
                    responses.Add(response);
                }
            }
            return responses;
        }
    }
}