using System.ComponentModel.DataAnnotations;

namespace GroupTooUniversity.Models
{
    public enum Type
    {
        SimpleText,
        MultipleChoice,
        RatingScale,
        CheckBoxes
    }

    [RequiredAnswer(ErrorMessage = "* Answers must be supplied for the question.")]
    public class Question
    {
        public Question()
        {
            this.Type = Type.SimpleText;
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Question")]
        public string Text { get; set; }

        public Type Type { get; set; }

        [Display(Name = "Answer Choices")]
        public string PossibleAnswers
        {
            get; set;
        }

        public int SurveyId { get; set; }

        // Navigation properties
        public Survey Survey { get; set; }
        public Response Response { get; set; }

    }
}
