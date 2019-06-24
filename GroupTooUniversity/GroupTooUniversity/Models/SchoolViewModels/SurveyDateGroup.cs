using System;
using System.ComponentModel.DataAnnotations;

namespace GroupTooUniversity.Models.SchoolViewModels
{
    public class SurveyDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? SurveyDate { get; set; }

        public int StudentCount { get; set; }
    }
}