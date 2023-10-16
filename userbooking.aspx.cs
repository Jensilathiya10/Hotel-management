using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hotelmanagement
{
    public partial class userbooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lenovo\\Documents\\hotelmanagement\\App_Data\\hotel.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomerBooking where loginid=@loginid", conn);
            cmd.Parameters.AddWithValue("@search", search.Text);
            cmd.Parameters.AddWithValue("@loginid", Convert.ToString(Session["User"]));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lenovo\\Documents\\hotelmanagement\\App_Data\\hotel.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomerBooking where loginid=@loginid and BookingId=@search", conn);
            cmd.Parameters.AddWithValue("@search", search.Text);
            cmd.Parameters.AddWithValue("@loginid", Convert.ToString(Session["User"]));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lenovo\\Documents\\hotelmanagement\\App_Data\\hotel.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from CustomerBooking where loginid=@loginid and BookingId=@search", conn);
            cmd.Parameters.AddWithValue("@search", search.Text);
            cmd.Parameters.AddWithValue("@loginid", Convert.ToString(Session["User"]));
            cmd.ExecuteNonQuery();
           
        }

        protected void showall_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lenovo\\Documents\\hotelmanagement\\App_Data\\hotel.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomerBooking where loginid=@loginid", conn);
            cmd.Parameters.AddWithValue("@search", search.Text);
            cmd.Parameters.AddWithValue("@loginid", Convert.ToString(Session["User"]));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            search.Text = "";
        }
    }
}