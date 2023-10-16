using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace hotelmanagement
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnsign_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lenovo\\Documents\\hotelmanagement\\App_Data\\hotel.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from customer where loginid=@loginid and password=@password", conn);
                cmd.Parameters.AddWithValue("@loginid", TextBox1.Text);
                cmd.Parameters.AddWithValue("@password", TextBox2.Text);

                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    Session["User"] = TextBox1.Text;
                    Response.Redirect("homepage.aspx");
                }
                else
                {
                    Label4.Text = "LoginId & Password Is not correct Try again..!!";
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}