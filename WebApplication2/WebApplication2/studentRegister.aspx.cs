using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class studentRegister : System.Web.UI.Page
    {
        string username, name, email, password, query;
        System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(@"Data Source=CIQGUR-ATD128\SQLEXPRESS;Initial Catalog=workshop2;Integrated Security=True;Pooling=False");
        SqlDataReader sqlDataReader;
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            
        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection;
        }
        protected void register(object sender, EventArgs e)
        {
            string abc = validate();

            int d = 0;

            if (textbox_email.Text != "" && textbox_name.Text != "" && textbox_password.Text != "")
            {
                d = 1;
            }

            if (abc == "yes")
            {
                if (d == 1)
                {
                    username = textbox_username.Text;
                    name = textbox_name.Text;
                    email = textbox_email.Text;
                    password = textbox_password.Text;

                    sqlConnection.Open();

                    query = "insert into studentTable(username,name,email,password) values ('" + username + "','" + name + "','" + email + "','" + password + "')";

                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();

                    textbox_email.Text = "";
                    textbox_name.Text = "";
                    textbox_password.Text = "";
                    textbox_username.Text = "";

                    //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Successfully Registered.!')", true);
                    Response.Write(@"<script language='javascript'>alert('Successfully Registered..!!');</script>");

                    Response.Redirect("studentLogin.aspx");
                }
                else
                {
                    Response.Write(@"<script language='javascript'>alert('All the fields are mandatory.!!');</script>");
                }
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Choose another Username..!');</script>");
            }
        }
        string validate()
        {
            int count = 0;
            username = textbox_username.Text;
            sqlConnection.Open();
            query = "select count(*) from studentTable where username like '" + username + "'";
            cmd.CommandText = query;

            sqlDataReader = cmd.ExecuteReader();

            if(sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    count = sqlDataReader.GetInt32(0);
                }
            }
            sqlConnection.Close();
            if (count == 0)
                return "yes";
            else
                return "no";
        }

    }
}