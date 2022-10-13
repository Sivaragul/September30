using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bal_Lib;

namespace WebApplication1
{
    public partial class SignUpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox8.Text = Calendar1.SelectedDate.ToLongDateString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer c=new Customer();
            c.FName=TextBox2.Text;
            c.LName = TextBox3.Text;
            //TextBox8.Text = Calendar1.SelectedDate.ToLongDateString();
            c.DateOfBirth= Calendar1.SelectedDate;
            c.City= TextBox5.Text;
            c.State = TextBox6.Text;
            HttpCookie k = new HttpCookie("customerdata");
            k.Expires = DateTime.Now.AddMinutes(20);
            k.Values.Add("FName", c.FName);
            k.Values.Add("LName", c.LName);
            k.Values.Add("DateOfBirth", c.DateOfBirth.ToLongDateString());
            k.Values.Add("City", c.City);
            k.Values.Add("State", c.State);
            TextBox7.Text = c.FName;
            Response.Write(c.FName);
            Response.Cookies.Add(k);

        }
    }
}