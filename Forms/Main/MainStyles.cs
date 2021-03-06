using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.Main
{
    public class MainStyles
    {
        Main caller;

        public MainStyles(Main caller)
        {
            this.caller = caller;
        }


        public void ChangeFormStyles(Button currentButton, Form currentForm)
        {
            currentForm.Dock = DockStyle.Fill;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.TopLevel = false;

            Label panelContent = (Label)((Panel)currentForm.Controls.Find("panelTitle", true)[0]).Controls.Find("labelTitle", true)[0];
            panelContent.Text = currentButton.Text;
        }

        public void EnableMenuButtons()
        {
            caller.buttonCollection.Enabled = Main.isLoggedIn;
            caller.buttonUsers.Enabled = Main.isLoggedIn;
            caller.buttonMyProfile.Enabled = Main.isLoggedIn;
        }
    }
}
