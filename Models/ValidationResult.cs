using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.Models
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<int> MissingQuestionIds { get; set; }

        public ValidationResult() 
        { 
            MissingQuestionIds = new List<int>();
        }
    }
}