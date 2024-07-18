using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CollegeMivchan3.Dal.Repositories
{
    internal class StudentRepository
    {
        DBContext dbContext;
        public StudentRepository()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            dbContext = new DBContext(conn);
        }

        public bool CheckPassword(string password, string name)
        {
            string queiry = @"declare @flag bit = 0

                            if exists (select * from Students where StudentName=@name and StudentPassword=@password)
                            begin
	                            set @flag = 1;
                            end

                            select @flag";
            bool ok = (bool)dbContext.ExecuteScalar(queiry, [new SqlParameter("@name", name), new SqlParameter("@password", password)]);
            return ok;
        }
    }
}
