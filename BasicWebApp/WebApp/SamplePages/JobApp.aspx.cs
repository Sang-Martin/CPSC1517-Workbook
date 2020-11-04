using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class JobApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear our old message regardless of the event
            MessageLabel.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //not worry about validation in this example
            string msg = "";
            msg += "Name: " + FullName.Text;
            msg += "\nEmail: " + EmailAddress.Text;
            msg += "\nPhone: " + Phone.Text;
            // ALWAYS condiser usually the .SelectedValue over .SelectedIndex
            msg += "\nTime: " + (FullOrPartTime.SelectedValue == "1" ? "Full Time" : (FullOrPartTime.SelectedValue == "2" ? "Part Time" : "Either"));

            //handle the CheckBoxList
            //traverse the checkbox list, review one item
            //  at at time and add those items selected to the message
            //if no items were choosen, then add an appropriate message stating that no items were choosen
            msg += "\nJobs:";

            //basic search of a list
            //set my found flag to "nothing found" (false)
            bool found = false;
            //loop processing
            //if something is found then set the found flag to true
            foreach(ListItem jobrow in JobLists.Items)
            {
                //or if item is checked
                if(jobrow.Selected)
                {
                    msg += jobrow.Text + " ";
                    found = true;
                }
            }

            //check your flag
            if(!found)
            {
                msg += "You did not select a job. Application rejected.";
            }

            MessageLabel.Text = msg;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FullName.Text = "";
            EmailAddress.Text = "";
            Phone.Text = "";
            //for  Lists there are a couple of ways to reset
            // a) manually reset the control SelectionIndex
            //      for the RadioButtonList, set the index -1
            FullOrPartTime.SelectedIndex = -1;
            // b) most list controls have a bult in method to clear
            //      this clearing can be the selection and /or the item contents
            JobLists.ClearSelection();

        }
    }
}