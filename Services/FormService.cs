using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using USSMVC48.Data;
using USSMVC48.Models;

namespace USSMVC48.Services
{
    public class FormService
    {
        private readonly USSMVC48Context _context;

        public FormService(USSMVC48Context context)
        {
            _context = context;
        }

        public List<Question> GetQuestionsWithOptionsByFormId(int formId)
        {
            var questions = _context.Questions
                .Where(q => q.FormID == formId)
                .Include(q => q.Options)
                .ToList();

            // Debugging: Check if options are loaded
            //foreach(var question in questions)
            //{
            //    System.Diagnostics.Debug.WriteLine($"Question: {question.Text}, Options Count: {question.Options.Count}");
            //    foreach(var option in question.Options)
            //    {
            //        System.Diagnostics.Debug.WriteLine($"Option: {option.Text}");
            //    }
            //}

            return questions;
        }

        public Question GetNextQuestion(int currentQuestionId, int selectedOptionId)
        {
            var skipToQuestionId = _context.Options
                .Where(o => o.OptionID == selectedOptionId)
                .Select(o => o.SkipToQuestionID)
                .FirstOrDefault();

            if (skipToQuestionId.HasValue)
            {
                return _context.Questions.Find(skipToQuestionId.Value);
            }
            else
            {
                int nextQuestionId = currentQuestionId + 1;
                return _context.Questions.FirstOrDefault(q => q.QuestionID == nextQuestionId);
            }
        }

        public void SubmitResponse(List<Response> responses, Guid surveySeesinId)
        {

            foreach(var response in responses)
            {
                response.SurveySessionID = surveySeesinId;
                _context.Responses.Add(response);
            }

            _context.SaveChanges();
        }

        public ValidationResult ValidateResponses(List<Response> responses, int formId)
        {
            ValidationResult result = new ValidationResult
            {
                IsValid = true,
                MissingQuestionIds = new List<int>()
            };

            var allQuestions = _context.Questions
                .Where(q => q.FormID == formId)
                .ToList();

            foreach (var question in allQuestions)
            {
                // Check if the question is required and not skippable
                if (question.IsRequired && !question.IsSkippable)
                {
                    // Check if a response exists
                    if (!responses.Any(r => r.QuestionID == question.QuestionID))
                    {
                        result.IsValid = false;
                        result.MissingQuestionIds.Add(question.QuestionID);
                    }
                }
                // For skippable questions, we can allow null values
            }

            return result;
        }

        //public ValidationResult ValidateResponses(List<Response> responses, int formId)
        //{
        //    ValidationResult result = new ValidationResult
        //    {
        //        IsValid = true,
        //        MissingQuestionIds = new List<int>()
        //    };

        //    var mandatoryQuestions = _context.Questions
        //        .Where(q => q.FormID == formId && q.IsRequired && !q.IsSkippable)
        //        .Select(q => q.QuestionID)
        //        .ToList();

        //    foreach(var questionId in mandatoryQuestions) 
        //    {
        //        if(!responses.Any(r => r.QuestionID == questionId))
        //        {
        //            result.IsValid = false;
        //            result.MissingQuestionIds.Add(questionId);
        //        }
        //    }

        //    return result;
        //}

        public bool TestDatabaseConnection()
        {
            try
            {
                return _context.Database.Exists();
            }
            catch
            {
                return false;
            }
        }
    }


}