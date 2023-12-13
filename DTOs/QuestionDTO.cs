using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.DTOs
{
    public class QuestionDTO
    {
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public List<OptionDTO> Options { get; set; }
        public string TextResponse { get; set; }
        public bool IsMultipleChoice { get; set; }
    }
}