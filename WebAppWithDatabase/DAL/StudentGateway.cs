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

            string query = "INSERT INTO student VALUES('"+student.Name+"','"+student.Email+"','"+student.ContactNo+"')";

            SqlCommand command=new SqlCommand(query,connection);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowsAffected;
        }


        public List<Student> GetAllStudents()
        {
            List<Student> students=new List<Student>();

            string query = "SELECT * FROM student";

            SqlConnection connection=new SqlConnection(ConnectionString);

            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student student=new Student();

                student.Id = int.Parse(reader["Id"].ToString());
                student.Name = reader["Name"].ToString();
                student.Email = reader["Email"].ToString();
                student.ContactNo = reader["ContactNo"].ToString();
                students.Add(student);
            }

            reader.Close();
            connection.Close();

            return students;
        }
    }
}