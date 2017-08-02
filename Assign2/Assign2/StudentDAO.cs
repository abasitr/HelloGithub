using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    class StudentDAO //data access object
    {
        public static void Create(Student student)
        {
            var db = MyDB.GetInstance();

            var sql = "insert into Student ('" + student.FirstName + "', '" + student.LastName + "')";
            db.ExecuteSQL(sql);

        }
        public static void Delete(Student student)
        {
            var db = MyDB.GetInstance();
            var sql = "DELETE from Student where stuID = " + student.ID;
            db.ExecuteSQL(sql);
        }
        public static void Update(Student student)
        {
            var db = MyDB.GetInstance();
            var sql = String.Format("UPDATE Student SET FirstName = '{0}'  , LastName = '{1}' WHERE StuID = {2}", student.FirstName, student.LastName, student.ID);
            db.ExecuteSQL(sql);
        }
        public static Student GetStudent(int ID)
        {
            var db = MyDB.GetInstance();
            var sql = string.Format("Select * from Student where StuID = {0}", ID);
            var result = db.ExecuteSelectSQL(sql);
            if (result.HasRows)
            {
                result.Read();
                return new Student
                {
                    ID = (int)result["stuID"],
                    FirstName = result["FirstName"].ToString(),
                    LastName = result["LastName"].ToString()
                };

            }
            return null;

        }

        public static List<Student> GetStudents()
        {
            return null;
        }



    }//end of classs


}
