using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CS_ASP_012_Challenge;

namespace CS_ASP_012_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string prePendString = "You selected a ";

            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = prePendString + pencilRadioButton.Text;
                resultImage.ImageUrl = "~/Images/pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                resultLabel.Text = prePendString + penRadioButton.Text;
                resultImage.ImageUrl = "~/Images/pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = prePendString + phoneRadioButton.Text;
                resultImage.ImageUrl = "~/Images/phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = prePendString + tabletRadioButton.Text;
                resultImage.ImageUrl = "~/Images/tablet.png";
            }
            else
            {
                resultLabel.Text = "Please select an option";
            }

        }
    }
}