using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace CollegeMivchan3.Dal.Repositories
{
    internal class PaymentReposirtory 
    {
        DBContext dbContext;
        public PaymentReposirtory()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            dbContext = new DBContext(conn);
        }
        public void PayAndUpdateTheLeftToPay(string studentName, string amount)
        {
            string queiry = @"declare @name varchar(15) = @studentName
                              declare @id int = (select ID from Students where StudentName=@name)

                             insert into Payments(StudentID, Payd)
                             values
	                             (@id, @amount)

                             UPDATE Students 
                             SET LeftToPay = LeftToPay - @amount
                             WHERE ID = @id
                             select LeftToPay from Students
                             where id = @id;";
            
            int leftToPay = (int)dbContext.ExecuteScalar(queiry, [new SqlParameter("@studentName", studentName), new SqlParameter("@amount", amount)]);
          

            if (leftToPay == 0)
            {

            }else if (leftToPay > 0) {
                MessageBox.Show($"The payment went successfuly! You still need to pay {leftToPay}$");

            }
            else
            {
                MessageBox.Show($"you have got on your acount extra {leftToPay * - 1}$");

            }


        }

        public void BuyCourses(string courseName, string machzor, string studentName)
        {
            string queiry = @" 
exec buyCourse @courseName = @CourseName, @machzor=@Machzor, @name=@StudentName";
            dbContext.ExecuteNonQuery(queiry, [new SqlParameter("@StudentName", studentName),
                                               new SqlParameter("@Machzor", machzor),
                                               new SqlParameter("@CourseName", courseName)]);




        }
        public int TotalIncomeFromStudents()
        {
            string quiry = "select sum(Payd) from Payments;";
            int answer = (int)dbContext.ExecuteScalar(quiry, null);
            return answer;
        }

        public int TotalSalaryProffesors()
        {
            string quiry = @"select sum(SubjectHours * SallaryPH) from Subjects s
                             join Professors p on s.ProffesorID = p.ID";
            int answer = (int)dbContext.ExecuteScalar(quiry, null);
            return answer;
        }

        public int LeftToPayOfOneStudent(string Name)
        {
            string quiry = @"select LeftToPay from Students where StudentName = @name";
            int answer = (int)dbContext.ExecuteScalar(quiry, [new SqlParameter("@name", Name)]);
            return answer;
        }
    }
}
