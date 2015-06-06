using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppWithDatabase.BLL;

namespace WebAppWithDatabase
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Student student=new Student();

        StudentManager studentManager=new StudentManager();
        protected void addButton_OnClick(object sender, EventArgs e)
        {
            string message;
            student.Name = Request.Form["nameInput"];
            student.Email = Request.Form["emailInput"];
            student.ContactNo = contactNoTextBox.Text;
            message = studentManager.Save(student);
          
            Label1.Text = message;

        }
    }
}