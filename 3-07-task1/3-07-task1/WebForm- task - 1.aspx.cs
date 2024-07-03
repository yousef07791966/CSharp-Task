using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task1
{
    public partial class task1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label7.Text = TextBox1.Text;
            Label8.Text = TextBox2.Text;
            Label9.Text = TextBox3.Text;

            if (RadioButtonList1.SelectedItem != null)
            {
                Label10.Text = RadioButtonList1.SelectedItem.Text;
            }
            else
            {
                Label10.Text = "";
            }

            //1 the short hand
            Label11.Text = CheckBox1.Checked ? CheckBox1.Text : "";
            //2 the if as we knew
            //if (CheckBox1.Checked)
            //{
            //    Label11.Text = CheckBox1.Text;
            //}
            //else
            //{
            //    Label11.Text = "";
            //}
            if (CheckBox2.Checked)
            {
                Label12.Text = CheckBox2.Text;
            }
            else
            {
                Label12.Text = "";
            }
            if (CheckBox3.Checked)
            {
                Label13.Text = CheckBox3.Text;
            }
            else
            {
                Label13.Text = "";
            }


            Label14.Text = TextBox4.Text;



        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}