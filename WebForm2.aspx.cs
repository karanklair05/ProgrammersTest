using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karan\source\repos\WebApplication5\App_Data\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridBind();
            }

        }

        public void GridBind()
        {
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select * from details", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked==true)
            { 
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from details", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            }
            else if(RadioButton2.Checked == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from details where pname='" + TextBox1.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else if (RadioButton3.Checked == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from details where dname='" + TextBox1.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else if (RadioButton4.Checked == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from details where ename='" + TextBox1.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
            else if (RadioButton5.Checked == true)
            {
                con.Open();
                string query = "select * from details where description like '%" + TextBox1.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();                                            
                da.Fill(ds);
                con.Close();
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }

        }


    }
}