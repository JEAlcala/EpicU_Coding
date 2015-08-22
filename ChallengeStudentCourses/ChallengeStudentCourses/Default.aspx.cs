using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        /*
        Dictionary<int, string> _dict = new Dictionary<int , string>();

        void PutDataIntoDictionary()
        {
            for (int i = 0; i < 1000; i ++)
            {
                lock (_dict)
                { 
                if(!_dict.ContainsKey(i))
                    _dict.Add(i, "i=" + i + "From Thread" + Thread.CurrentThread.ManagedThreadId);
            }
            Thread.Sleep(100);
        }
         */

      
        
        
        

        
        
        
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            var courses = new List<Course>
            {
            new Course { CourseName = "JS", Students = new List<Student> {
                new Student { StudentName = "JBobb"},
                new Student {StudentName = "BElli"}
            }},
            new Course {CourseName = "C#", Students = new List<Student> {
                new Student {StudentName = "JBobb"},
                new Student {StudentName = "BElli"}
            }},
            new Course {CourseName = "HTML", Students = new List<Student>{
                new Student {StudentName = "JBobb"},
                new Student {StudentName = "BElli"}
            }},
            };

            foreach (var course in courses)
            {
                result += "<br><b>" + course.CourseName + "</b>";

                foreach (var student in course.Students)
                {
                    result += String.Format("<br>&nbsp;&nbsp;&nbsp;</b>" + student.StudentName , student.StudentId , student.StudentGrade);
                }
            }

            resultLabel.Text = result;

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            string result = "";
            var coursesDictionary = new Dictionary<int, Course>()
            {
                {1, new Course {CourseName = "JS", Students = new List<Student>{
                    new Student {StudentName = "JBobb"},
                    new Student {StudentName = "BElli"}
                }}},
            
            {2, new Course {CourseName = "C#", Students = new List<Student>{
                    new Student {StudentName = "JBobb"},
                    new Student {StudentName = "BElli"}  
                }}
            },
            };

            resultLabel.Text = result;
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
           
         string result = "";

           Dictionary<int, Student> students = new Dictionary<int, Student>(){

           {100, new Student {StudentName = "JBobb", Courses = new List<Course>{
           new Course {CourseId = 101, CourseName = "JS", StudentGrade = 95}, 
           new Course {CourseId = 102, CourseName = "C#", StudentGrade = 90}
           }
           }
           }
           };

           foreach (var kv in students)
           {
               var id = kv.Key;
               var student = kv.Value;

               result += kv.Key + "&nbsp;" + kv.Value.StudentName;

               foreach (var course in student.Courses)
               {
                   result += "<br/>" + course.CourseName + "&nbsp;" + course.StudentGrade;
               }

               resultLabel.Text = result;
  
        }
    }
}