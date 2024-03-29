﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TAJ2
{
    public partial class YourVehicles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateRegistration_Click(object sender, EventArgs e)
        {
            //Pressing the Button selects a vehicle that the user wants to update the registration for and then redirects to the update registration page
            Button Button1 = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)Button1.NamingContainer;
            Session["Chassi"] = selectedRow.Cells[0].Text;
            Session["RegistrationExpiry"] = selectedRow.Cells[7].Text;
            Response.Redirect("UpdateRegistration.aspx");

        }
    }
}