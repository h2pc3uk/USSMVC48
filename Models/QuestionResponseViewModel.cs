using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.Models
{
    public class QuestionResponseViewModel
    {
        public int QuestionId { get; set; }
        public List<int> SelectedOptionIds { get; set; } // For multiple choice questions
        public int? SelectedOptionId { get; set; } // For single choice questions
        public string AdditionalText { get; set; } // For text input questions

        public QuestionResponseViewModel()
        {
            SelectedOptionIds = new List<int>();
        }
    }
}