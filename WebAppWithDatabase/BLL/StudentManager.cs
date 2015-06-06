using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppWithDatabase.DAL;

namespace WebAppWithDatabase.BLL
{
    public class StudentManager
    {
        StudentGateway studentGateway=new StudentGateway();

        public string Save(Student student)
        {
            if (student.Name == string.Empty)
            {
                return "Name is missing";
            }


            else if (student.Email == string.Empty)
            {
                return "Email is missing";
            }

            else if (student.ContactNo == string.Empty)
            {
                return "Contact No. is missing";
            }

            else
            {
                int value = studentGateway.Save(student);

                if (value > 0)
                {
                    return "Save Successfully";
                }

                else
                {
                    return "Operation Failed";
                }
            }
            
        }


        public List<Student> GetAllStudents()
        {
            return studentGateway.GetAllStudents();
        } 
    }
}