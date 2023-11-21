using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USSMVC48.Models
{
    public class Form
    {
        public int FormID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Question> Questions { get; set; }
    }
}