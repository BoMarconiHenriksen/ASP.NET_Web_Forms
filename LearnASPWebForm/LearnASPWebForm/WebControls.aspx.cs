using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPWebForm
{
    public partial class WebControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // Will iterate through all the web validation server controls and validation each one.
            Page.Validate();

            if (Page.IsValid) // If one of the validations is false then it will show the error message. So now need for the else statement.
            {
                // Get the input from the first name textbox.
                var fname = FirstNameTextBox.Text;
                var lname = LastNameTextBox.Text;
                var state = StatesDropDown.SelectedValue;

                OutputLabel.Text = fname + " " + lname + " " + state;
            }

            
        }
    }
}