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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection _connection = new SqlConnection("Data Source = VISHAKHA; Initial Catalog = Courses; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {

            string email = Email.Text;
            _connection.Open();
            SqlCommand cmd = new SqlCommand($"select*from userstbl where uemail='{email}'", _connection);
            SqlDataReader dr = cmd.ExecuteReader();

            
            if (dr.Read())
            {
                if (dr["uPassword"].ToString() ==Password.Text)
                {
                    Session["uid"] = dr["uid"].ToString();
                    Response.Redirect("default.aspx");
                    
                }
                else
                {
                    Response.Write("<script>alert('Invalid Password')</script>");
                }

            }
            


        }
        protected void LoginBtn_CLick(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
        protected void ForgetPasswordBtn_CLick(object sender, EventArgs e)
        {
            Response.Redirect("ForgetPassword.aspx");
        }





    }
}