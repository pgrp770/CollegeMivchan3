using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CollegeMivchan3.Dal.Repositories
{
    internal class CoursesRepository 
    {

        DBContext dbContext;
        public CoursesRepository()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            dbContext = new DBContext(conn);
        }
        public List<string> GetAllCoursesName()
        {
            string queiry = "select distinct CourseName from Courses;";
            DataTable dt = dbContext.ExecuteQuery(queiry, null);
            List<string> ls = new List<string>();

            // fill the list from data-table
            foreach (DataRow row in dt.Rows)
            {
                ls.Add(row[0].ToString());
            }
            return ls;
        }

        public List<string> GetAllMachzorimByCourseName(string courseName)
        {
            string queiry = "Select Machzor from Courses where CourseName = @courseName;";
            DataTable dt = dbContext.ExecuteQuery(queiry, [new SqlParameter("@courseName", courseName)]);
            List<string> ls = new List<string>();

            // fill the list from data-table
            foreach (DataRow row in dt.Rows)
            {
                ls.Add(row[0].ToString());
            }
            return ls;
        }

        public DataTable GetCouresSylabusByNameAndMachzor(string courseName, string machzor) 
        {
            string quiery = @"select s.SubjectName, p.ProfessorName, s.SubjectHours from Courses c
                            join Subjects s on c.ID = s.CourseID
                            join Professors p on p.ID = s.ProffesorID
                            where c.ID = (Select ID from Courses where CourseName=@courseName and Machzor=@machzor)";
            DataTable dt = dbContext.ExecuteQuery(quiery, [new SqlParameter("@courseName", courseName), new SqlParameter("@machzor", machzor)]);
            return dt;
        }

        public DataTable GetAllDetailTimeFromCouresByNameAndMachzor(string courseName, string machzor)
        {
            string quiery = @"select BeginingDate, DaysInAWeek, HoursADay, Price from Courses
                              where CourseName=@courseName and Machzor=@machzor";
            DataTable dt = dbContext.ExecuteQuery(quiery, [new SqlParameter("@courseName", courseName), new SqlParameter("@machzor", machzor)]);
            return dt;

        }
        public void InsertNewStudentToCourse(string courseName, string machzor, string name)
        {
            string queiry = @"insert into StudentsInCourses(CourseID, StudentID)
                                values
	                                ((select ID from Courses where CourseName = @courseName and Machzor = @machzor),
                                    (select ID from Students where StudentName = @name))";

            dbContext.ExecuteNonQuery(queiry, [new SqlParameter("@courseName", courseName), 
                                                                  new SqlParameter("@machzor", machzor),
                                                                  new SqlParameter("@name", name)]);
        }

        public List<string> GetAllCoursesNameForStudent(string name)
        {
            string queiry = @"select distinct CourseName from Courses c 
                            join StudentsInCourses sc on c.ID = sc.CourseID
                            join Students s on s.ID = sc.StudentID
                            where s.StudentName = @name;";
            DataTable dt = dbContext.ExecuteQuery(queiry, [new SqlParameter("@name", name)]);
            List<string> ls = new List<string>();

            // fill the list from data-table
            foreach (DataRow row in dt.Rows)
            {
                ls.Add(row[0].ToString());
            }
            return ls;
        }

        public bool checkIfExistThisCourse(string courseName, string machzor, string name)
        {
            string queiry = @"exec checkIsThisCourseGood  @courseName = @CourseName, @machzor = @Machzor,@name = @Name";
            SqlParameter[] foo = [new SqlParameter("@CourseName", courseName),
                new SqlParameter("@Machzor", machzor),
                new SqlParameter("@Name", name)];
            bool ok = (bool)dbContext.ExecuteScalar(queiry, foo);
            return ok;

        }

    }
}
