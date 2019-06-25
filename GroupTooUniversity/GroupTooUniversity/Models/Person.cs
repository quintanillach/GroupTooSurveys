using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace GroupTooUniversity.Models
{
    public abstract class Person
    {
        public int ID { get; set; }

        [JsonProperty(PropertyName = "LastName")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Column("FirstName")]
        [JsonProperty(PropertyName = "FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [JsonProperty(PropertyName = "Email")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        
    }
}