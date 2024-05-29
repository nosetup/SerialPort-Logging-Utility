using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities
{
    public class MyForms
    {
        #region Constructor
        public MyForms()
        {
        }
        #endregion // Constructor

        #region Local Methods

        public void InitializeSingleInstanceForm(Form mdiParentForm, Form singleInstanceForm)
        {
            if (singleInstanceForm == null)
            {
                return; // Exit if singleInstanceForm is null
            }

            // Set the MDI parent
            singleInstanceForm.MdiParent = mdiParentForm;

            // Set the position of the single instance form relative to the MDI parent form
            singleInstanceForm.StartPosition = FormStartPosition.Manual;
            singleInstanceForm.Location = new Point(
                (mdiParentForm.ClientSize.Width - singleInstanceForm.Width) / 2,
                (mdiParentForm.ClientSize.Height - singleInstanceForm.Height) / 2
            );
            singleInstanceForm.WindowState = FormWindowState.Maximized; // Set to maximized by default
        }

        public void OpenMultiInstanceForm(Form mainForm, Form secondaryForm)
        {
            if (secondaryForm == null)
            {
                return; // Exit if secondaryForm is null
            }

            // Set the position of the secondary form relative to the main form
            secondaryForm.StartPosition = FormStartPosition.Manual;
            secondaryForm.Location = new Point(
                mainForm.Location.X + (mainForm.Width - secondaryForm.Width) / 2,
                mainForm.Location.Y + (mainForm.Height - secondaryForm.Height) / 2
            );

            // Show the secondary form
            secondaryForm.Show();
        }

        public void OpenSingleInstanceForm(Form mdiParentForm, Form singleInstanceForm)
        {
            if (singleInstanceForm == null)
            {
                return; // Exit if singleInstanceForm is null
            }

            // Set the MDI parent
            singleInstanceForm.MdiParent = mdiParentForm;

            // Check if the form is already open
            if (singleInstanceForm.MdiParent != null)
            {
                // Bring the form to the front
                singleInstanceForm.BringToFront();
                //singleInstanceForm.WindowState = FormWindowState.Maximized;
                singleInstanceForm.Show(); // Show the form if it's hidden
            }
            else
            {
                // Set the position of the single instance form relative to the MDI parent form
                singleInstanceForm.StartPosition = FormStartPosition.Manual;
                singleInstanceForm.Location = new Point(
                    (mdiParentForm.ClientSize.Width - singleInstanceForm.Width) / 2,
                    (mdiParentForm.ClientSize.Height - singleInstanceForm.Height) / 2
                );
                //singleInstanceForm.WindowState = FormWindowState.Maximized;
                // Show the single instance form as a child of the MDI parent
                singleInstanceForm.Show();
            }
        }

        public void OpenSingleInstanceFormToPanel(Panel parentPanel, Form singleInstanceForm)
        {
            if (singleInstanceForm == null)
            {
                return; // Exit if singleInstanceForm is null
            }

            // Check if the form is already open
            if (singleInstanceForm.Visible)
            {
                // Bring the form to the front
                singleInstanceForm.BringToFront();
            }
            else
            {
                // Set the position of the single instance form relative to the panel
                singleInstanceForm.TopLevel = false; // Set TopLevel to false to make it a child form
                singleInstanceForm.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border if needed
                singleInstanceForm.Dock = DockStyle.Fill; // Fill the entire panel
                parentPanel.Controls.Add(singleInstanceForm); // Add form to the panel

                // Show the single instance form
                singleInstanceForm.Show();
            }
        }


        #endregion // Local Methods
    }
}
