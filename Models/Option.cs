using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.Models
{
    public class Option
    {
        public int OptionID { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public int? SkipToQuestionID { get; set; }
        public virtual Question Question { get; set; }
        public virtual Question SkipToQuestion { get; set; }

    }
}