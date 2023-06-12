using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;

namespace Course
{
    public class DbWork
    {
        SqlConnection _connection = new SqlConnection("Data Source = VISHAKHA; Initial Catalog = Courses; Integrated Security = True");
        public SqlDataReader reader;
        public SqlDataReader getusersinfo()
        {
            _connection.Open();
            string users = $"select*from userstbl";
            return new SqlCommand(users, _connection).ExecuteReader();
        }
        public SqlDataReader getcourseinfo()
        {
            _connection.Open();
            string course = $"select*from coursetbl";
            return new SqlCommand(course, _connection).ExecuteReader();
        }
        public static string genslug(string text)
        {
            text = text.Trim();
            text = text.Replace(" ", "-");
            text = AddRandomNumbers(text);
            return text;
        }
        private static string AddRandomNumbers(string text)
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 99); // Generate a random 4-digit number

            text += "-" + randomNumber.ToString();

            return text;
        }
        public SqlDataReader orderdetail(string uid)
        {
            _connection.Open();
            string query = $"select*from coursetbl join buycoursetbl on coursetbl.slug=buycoursetbl.coslug where uid='{uid}' order by orderid DESC ";
            return new SqlCommand(query, _connection).ExecuteReader();

        }
        public SqlDataReader getonecourseinfo(string cid)
        {
            _connection.Open();
            string course = $"select*from coursetbl where coid='{cid}'";
            return new SqlCommand(course, _connection).ExecuteReader();
        }

    }
}