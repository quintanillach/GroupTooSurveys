using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GroupTooUniversity.Models
{
    public class Response
    {
        public int ID { get; set; }

        public int QuestionId { get; set; }

        public string Value { get; set; }

        public string Comment { get; set; }

        public Question Question { get; set; }
        public Survey Survey { get; set; }
        public Person Respondent { get; set; }
    }
}