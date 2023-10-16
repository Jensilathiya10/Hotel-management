using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hotelmanagement
{
    public partial class updatepass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnsign_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lenovo\\Documents\\hotelmanagement\\App_Data\\hotel.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set password=@pass where loginid=@loginid", conn);
            cmd.Parameters.AddWithValue("@pass", TextBox1.Text);
            cmd.Parameters.AddWithValue("@loginid", Convert.ToString(Session["User"]));
            cmd.ExecuteNonQuery();
        }
    }
}