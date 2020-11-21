using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


#region Additional Namespaces
using System.Drawing;
using NorthWindSystem.BLL;
using NorthWindSystem.Entities;
#endregion

namespace WebAppClient.SamplePages
{
    public partial class SimpleQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLable.Text = "";
        }

        protected void RegionSearch_Click(object sender, EventArgs e)
        {
            //verify input exists
            if(string.IsNullOrEmpty(RegionArg.Text))
            {
                MessageLable.Text = "Enter a region id";
            }
            else
            {
                //you could do other validations such as: numeric check

                //standard loop
                try
                {
                    //connect to controller class by creating an instance
                    RegionController sysmgr = new RegionController();

                    //issue your call to the class instance
                    //NorthWindSystem.Entities.Region to navigate accurately to the property (not System.Drawing.Region)
                    NorthWindSystem.Entities.Region info = sysmgr.Region_FindByID(int.Parse(RegionArg.Text));

                    //test results and either display record or an appropriate message
                    if(info == null)
                    {
                        //not found
                        MessageLable.Text = "No region for supplied value";
                        RegionId.Text = "";
                        RegionDescription.Text = "";
                    }
                    else
                    {
                        //RegionId is a point to the label itself
                        //.Text is a property of the Label instance which allow one to change its contents
                        RegionId.Text = info.RegionID.ToString();
                        RegionDescription.Text = info.RegionDescription;
                    }
                }
                catch(Exception ex)
                {
                    MessageLable.Text = $"Error: {ex.Message}";
                }
            }
        }
    }
}