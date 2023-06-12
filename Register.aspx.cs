using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Course
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection _connection = new SqlConnection("Data Source = VISHAKHA; Initial Catalog = Courses; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            _connection.Open();
            string check = $"Select*from userstbl where uemail='{email}'";
            if (new SqlCommand(check, _connection).ExecuteReader().Read())
            {
                Response.Write("<Script>alert('Email is already registered!')</script>");
            }
            else
            {

                _connection.Close();
                UImage.SaveAs(Server.MapPath("~/Images/usersimg/" + UImage.FileName));
                string name = Name.Text;

                string password = Password.Text;
                string mobile = Mobile.Text;
                string dob = Dob.Text;
                string gender = Gender.Text;
                string address = Address.Text;
                string city = City.Text;
                string state = State.Text;
                string zip = ZipCode.Text;
                string Aimg = UImage.FileName;
                _connection.Open();
                string query = $"insert into userstbl(uname, uemail, upassword, umobile, udob, ugender, uaddress, ucity, ustate, uzipCode, uimage) Values('{name}','{email}','{password}','{mobile}','{dob}','{gender}','{address}','{city}','{state}','{zip}','{Aimg}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                Response.Redirect("Login.aspx");
            }
            _connection.Close();

        }
    }
}