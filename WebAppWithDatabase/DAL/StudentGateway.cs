using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebAppWithDatabase.DAL
{

    public class StudentGateway
    {

        private  string ConnectionString=WebConfigurationManager.ConnectionStrings["StudentConString"].ConnectionString;

        public int Save(Student student)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);

            string query = "INSERT INTO student VALUES('"+student.Name+"','"+student.Email+"','"+student.Email+"')";

            SqlCommand command=new SqlCommand(query,connection);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowsAffected;
        }
    }
}