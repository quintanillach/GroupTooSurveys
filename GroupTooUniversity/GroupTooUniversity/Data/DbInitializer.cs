using GroupTooUniversity.Models;
using System;
using System.Linq;

namespace GroupTooUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var instructors = new Instructor[]
            {
            new Instructor{FirstMidName="Jonah",LastName="Hill", Email="jonah.hill@gtoo.microsoft.com"},
            new Instructor{FirstMidName="Liam",LastName="Neeson", Email="liam.neeson@gtoo.microsoft.com"},
            new Instructor{FirstMidName="Denzel",LastName="Washington", Email="denzel.washington@gtoo.microsoft.com"}
            };
            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            context.SaveChanges();

            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",Email="carson.alexander@gtoo.microsoft.com",SurveyDate=DateTime.Parse("2019-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",Email="meredith.alonso@gtoo.microsoft.com",SurveyDate=DateTime.Parse("2019-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",Email="arturo.anand@gtoo.microsoft.com",SurveyDate=DateTime.Parse("2019-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",Email="gytis.barzdukas@gtoo.microsoft.com",SurveyDate=DateTime.Parse("2019-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",Email="yan.li@gtoo.microsoft.com",SurveyDate=DateTime.Parse("2019-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",Email="peggy.justice@gtoo.microsoft.com",SurveyDate=DateTime.Parse("2019-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",Email="norman.laura@gtoo.microsoft.com",SurveyDate=DateTime.Parse("2019-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",Email="nino.olivetto@gtoo.microsoft.com",SurveyDate=DateTime.Parse("2019-09-01")}
            };
            foreach (Student u in students)
            {
                context.Students.Add(u);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var surveys = new Survey[]
            {
            new Survey{StudentID=1,CourseID=1050},
            new Survey{StudentID=1,CourseID=4022},
            new Survey{StudentID=1,CourseID=4041},
            new Survey{StudentID=2,CourseID=1045},
            new Survey{StudentID=2,CourseID=3141},
            new Survey{StudentID=2,CourseID=2021},
            new Survey{StudentID=3,CourseID=1050},
            new Survey{StudentID=4,CourseID=1050},
            new Survey{StudentID=4,CourseID=4022},
            new Survey{StudentID=5,CourseID=4041},
            new Survey{StudentID=6,CourseID=1045},
            new Survey{StudentID=7,CourseID=3141},
            };
            foreach (Survey s in surveys)
            {
                context.Surveys.Add(s);
            }
            context.SaveChanges();
        }
    }
}   