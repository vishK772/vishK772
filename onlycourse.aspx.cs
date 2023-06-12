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
    public partial class onlycourse : System.Web.UI.Page
    {
        SqlConnection _connection = new SqlConnection("Data Source = VISHAKHA; Initial Catalog = Courses; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            string slug = Request.QueryString["Slug"];
            if (slug != null)
            {
                _connection.Open();

                string query = $"select*from coursetbl where slug='{slug}'";
                SqlDataReader dr = new SqlCommand(query, _connection).ExecuteReader();
                if (dr.Read())
                {
                    string coname = dr["coname"].ToString();
                    string codesc = dr["codesc"].ToString();

                    string coprice = dr["coprice"].ToString();
                    string coduration = dr["coduration"].ToString();
                    CONAME.InnerText = coname;
                    CODESC.InnerText = codesc;
                    COPRICE.InnerText = coprice;
                    CODURATION.InnerText = coduration;
                    coimage.Src = "/admin/image/courseimg" + dr["coimage"].ToString();

                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
                _connection.Close();


            }
            else
            {
                Response.Redirect("default.aspx");
            }



           
        }


        protected void BuyBtn_Click(object sender, EventArgs e)
        {
            string date1 = DateTime.Now.ToString();
            string uid = Session["uid"].ToString();
            string slug = Request.QueryString["Slug"];

            _connection.Open();
            string query = $"insert into buycoursetbl(uid,coslug,orderdate) values('{uid}','{slug}','{date1}')";
            SqlCommand cmd=new SqlCommand(query, _connection);
            cmd.ExecuteNonQuery();

            _connection.Close();
        }
    }
}