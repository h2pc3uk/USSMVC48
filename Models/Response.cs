using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.Models
{
    public class Response
    {
        public int ResponseID { get; set; }
        public Guid SurveySessionID { get; set; }
        public int QuestionID { get; set; }
        public int? OptionID { get; set; }
        public string AdditionalText { get; set; }
        public virtual Question Question { get; set; }
        public virtual Option Option { get; set; }
    }
}