using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karan\source\repos\WebApplication5\App_Data\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }




        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedIndex == 0)
            {
                DropDownList2.Enabled = false;
                DropDownList2.SelectedIndex = 0;

            }
            else if (DropDownList3.SelectedIndex != 0)
            {
                DropDownList2.Enabled = true;
                if (DropDownList3.SelectedValue == "Division of Telecommunications Extranet Development")
                {
                    
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Roma Marcell", "1");
                        ListItem d3 = new ListItem("Janelle Newberg", "2");
                        ListItem d4 = new ListItem("Linh Leitzel", "3");
                        ListItem d5 = new ListItem("Alissa Perlman", "4");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.Items.Insert(3, d4);
                        DropDownList2.Items.Insert(4, d5);
                        DropDownList2.DataBind();
                  }
                    else if (DropDownList3.SelectedValue == "Extranet Multimedia Connectivity and Security Division")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Hugo Wess", "1");
                        ListItem d3 = new ListItem("Leola Thornburg", "2");
                        ListItem d4 = new ListItem("Delorse Searle", "3");
                        ListItem d5 = new ListItem("Thresa Levins", "4");
                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.Items.Insert(3, d4);
                        DropDownList2.Items.Insert(4, d5);
                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Branch of Extranet Implementation")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Kelvin Lahr", "1");
                        ListItem d3 = new ListItem("Idella Dallman", "2");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);

                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Branch of Intranet Computer Maintenance and E-Commerce PC Programming")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Mellie Lombard", "1");
                        ListItem d3 = new ListItem("Shawna Hood", "2");
                        ListItem d4 = new ListItem("Kenneth Bowie", "3");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.Items.Insert(3, d4);
                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Wireless Extranet Backup Team")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Reita Abshire", "1");
                        ListItem d3 = new ListItem("Janice Skipper", "2");
                        ListItem d4 = new ListItem("Tawna Blackmore", "3");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.Items.Insert(3, d4);
                        DropDownList2.DataBind();
                    }
                    else if (DropDownList3.SelectedValue == "Multimedia Troubleshooting and Maintenance Team")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Ione Tomlin", "1");
                        ListItem d3 = new ListItem("Hilario Masterson", "2");
                        ListItem d4 = new ListItem("Sage Bow", "3");
                        ListItem d5 = new ListItem("Kasie Barclay", "4");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.Items.Insert(3, d4);
                        DropDownList2.Items.Insert(4, d5);
                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Office of Statistical Data Connectivity")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Keren Gillespi", "1");
                        ListItem d3 = new ListItem("Alexandra Brendle", "2");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Division of Application Security")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Rosalia Ayoub", "1");
                        ListItem d3 = new ListItem("Olympia Vien", "2");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "PC Maintenance Department")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Olene Pyron", "1");


                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);

                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Bureau of Business-Oriented PC Backup and Wireless Telecommunications Control")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Greta Quigg", "1");


                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Software Technology and Networking Department")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Diego Hasbrouck", "1");


                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Database Programming Branch")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Tomoko Gale", "1");
                        ListItem d3 = new ListItem("Marcelo Paris", "2");
                        ListItem d4 = new ListItem("Dalila Vickrey", "3");


                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.Items.Insert(3, d4);
                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Network Maintenance and Multimedia Implementation Committee")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Wilfredo Stumpf", "1");
                        ListItem d3 = new ListItem("Boyce Perales", "2");
                        ListItem d4 = new ListItem("Latoyia Kremer", "3");
                        ListItem d5 = new ListItem("Katheryn Lepak", "4");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.Items.Insert(3, d4);
                        DropDownList2.Items.Insert(4, d5);

                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Hardware Backup Department")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Farah Eldridge", "1");
                        ListItem d3 = new ListItem("Lana Montes", "2");
                        ListItem d4 = new ListItem("Claudine Valderrama", "3");
                        ListItem d5 = new ListItem("Altha Rudisill", "4");
                        ListItem d6 = new ListItem("Colton Kranz", "5");

                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.Items.Insert(2, d3);
                        DropDownList2.Items.Insert(3, d4);
                        DropDownList2.Items.Insert(4, d5);
                        DropDownList2.Items.Insert(5, d6);

                        DropDownList2.DataBind();
                    }

                    else if (DropDownList3.SelectedValue == "Mainframe PC Development and Practacal Source Code Acquisition Team")
                    {
                        DropDownList2.Items.Clear();
                        ListItem d1 = new ListItem("---Please Select Employee---", "0");
                        ListItem d2 = new ListItem("Luciano Riddell", "1");
                        DropDownList2.Items.Insert(0, d1);
                        DropDownList2.Items.Insert(1, d2);
                        DropDownList2.DataBind();
                    }

                }
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedIndex != 0 && DropDownList2.SelectedIndex != 0)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into details values('" + TextBox1.Text + "','" + DropDownList3.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox2.Text+ "','"+ Convert.ToDateTime(DateTime.Now) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("./WebForm2.aspx");
            }
            else
            {
                Label5.Text = "Please choose Appropriate items from the DropDownList";
            }
        }
    }

    
    } 