using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class studentLogin : System.Web.UI.Page
    {
        System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(@"Data Source=CIQGUR-ATD128\SQLEXPRESS;Initial Catalog=workshop2;Integrated Security=True;Pooling=False");
        SqlDataReader sqlDataReader;
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            
        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection;
        }
        protected void login(object sender, EventArgs e)
        {
            string abc = validate();
            if (abc == "yes")
            {
               // Response.Redirect();  // redirect to the page on which you want;
                Response.Write(@"<script language='javascript'>alert('Successfully logged In..!');</script>");
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Wrong username or password..!!');</script>");
            }
        }

        string validate()
        {
            string username = textbase_username.Text;
            string password = textbox_password.Text;

            string query = "select username,password from studentTable";
            cmd.CommandText = query;
            sqlConnection.Open();

            sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader.GetString(0) == username && sqlDataReader.GetString(1) == password)
                    {
                        sqlConnection.Close();
                        return "yes";
                    }
                }
            }


            sqlConnection.Close();
            
            return "no";
        }

    }
}