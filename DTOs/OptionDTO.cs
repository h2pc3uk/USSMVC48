using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.DTOs
{
    public class OptionDTO
    {
        public int OptionID { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public int? SkipToQuestionID { get; set; }
        public bool IsSelected { get; set; }
    }
}