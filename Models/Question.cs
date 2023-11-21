using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int FormID { get; set; }
        public string Text { get; set; }
        public bool IsSkippable { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public bool IsRequired { get; set; }
        public bool IsMultipleChoice { get; set; }

        public virtual Form Form { get; set; }
    }
}