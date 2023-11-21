using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.Models
{
    public class QuestionResponseViewModel
    {
        public int QuestionId { get; set; }
        public int? SelectedOptionId { get; set; }
        public string AdditionalText { get; set; }
    }
}