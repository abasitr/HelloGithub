using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    class CourseDAO
    {
        public static List<Course> GetCourses()
        {
            var list = new List<Course>();
            var results = MyDB.GetInstance().ExecuteSelectSQL("SELECT * FROM Course");

            while (results.Read())
            {
                var course = new Course()
                {
                    Id = (int)results["CourseID"],
                    Name = results["CourseName"].ToString()
                };
                list.Add(course);
            }
            return list;

        }
        public static void Create(Course course)
        {
            var db = MyDB.GetInstance();

            var sql = "insert into Course ('" + course.Name + "')";
           //var sql1= "Insert INTO Course ('{0}')",course.Name;
            db.ExecuteSQL(sql);

        }
        public static void Delete(Course course)
        {
            var db = MyDB.GetInstance();
            var sql = "DELETE from Course where CourseName = " + course.Name;
            db.ExecuteSQL(sql);
        }
        public static void Update(Course course)
        {
            var db = MyDB.GetInstance();
            var sql = String.Format("UPDATE Course SET CourseName = '{0}' WHERE CourseID = {1}", course.Name, course.Id);
            db.ExecuteSQL(sql);
        }

        public static Course GetCourse(int ID)
        {
            var db = MyDB.GetInstance();
            var sql = string.Format("Select * from Course where CourseID = {0}", ID);
            var result = db.ExecuteSelectSQL(sql);
            if (result.HasRows)
            {
                result.Read();
                return new Course
                {
                    Id = (int)result["CourseID"],
                    Name = result["CourseName"].ToString()
                };

            }
            return null;

        }











    }
}

