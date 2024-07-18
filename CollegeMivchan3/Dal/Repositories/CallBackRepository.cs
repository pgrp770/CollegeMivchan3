using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CollegeMivchan3.Dal.Repositories
{
    internal class CallBackRepository
    {

        DBContext dbContext;
        public CallBackRepository()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            dbContext = new DBContext(conn);
        }

        public void SendRequist(string name, string riquest)
        {
            string queiry = @"exec AddRequist @name = @Name, @requst = @Requist";

            dbContext.ExecuteNonQuery(queiry, [new SqlParameter("@Name", name), new SqlParameter("@Requist", riquest)]);
            MessageBox.Show("You have sent your requist successfuly!!");

        }
    }
}
