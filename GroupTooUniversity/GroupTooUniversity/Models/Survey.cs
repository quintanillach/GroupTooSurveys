using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroupTooUniversity.Models
{
    public class Survey
    {
        public Survey() : this(string.Empty)
        {
        }
        public Survey(string title)
        {
            Title = title;
        }
        public int SurveyID { get; set; }

        [Required(ErrorMessage = "* You must provide a Title for the survey.")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        public int StudentID { get; set; }

        public int CourseID { get; set; }

        public bool Published { get; set; }

        public Course Course { get; set; }

        public Instructor Owner { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
