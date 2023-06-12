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
    public partial class profile : System.Web.UI.Page
    {

        SqlConnection _connection = new SqlConnection("Data Source = VISHAKHA; Initial Catalog = Courses; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            string uid = Session["uid"].ToString();

            if (uid== null)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                _connection.Open();

                string query = $"select*from userstbl where uid='{uid}'";
                SqlDataReader dr = new SqlCommand(query, _connection).ExecuteReader();
                if (dr.Read())
                {
                    string name = dr["uname"].ToString();
                    string email = dr["uemail"].ToString();
                    string mobile = dr["umobile"].ToString();
                    string dob = dr["udob"].ToString();
                    
                    string address = dr["uaddress"].ToString();
                    string city = dr["ucity"].ToString();
                    string state = dr["ustate"].ToString();
                    string zip = dr["uzipcode"].ToString();


                    uimg.Src="/images/usersimg/"+dr["uimage"].ToString();
                    Email.InnerText = email;
                    Name.InnerText = name;
                    Mobile.InnerText = mobile;
                    Dob.InnerText = dob;
                    Address.InnerText = address;
                    City.InnerText = city;
                    State.InnerText = state;
                    ZipCode.InnerText = zip;

                    

                }


            }
        }
    }
}