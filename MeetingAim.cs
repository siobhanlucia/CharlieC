using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharlieC
{
    public partial class MeetingAim : Form
    {
        public MeetingAim()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (RadioButtonMeeting.Checked == true)
            {
                VisitorRegistration.Self.BtnMeetingAim.Text = RadioButtonMeeting.Text;
                MessageBox.Show(RadioButtonMeeting.Text + " selected");
            }

            else if (RadioButtonSalesAppointment.Checked == true)
            {
                MessageBox.Show(RadioButtonSalesAppointment.Text + " selected");
                VisitorRegistration.Self.BtnMeetingAim.Text = RadioButtonSalesAppointment.Text;
            }
            else if (RadioButtonSiteVisit.Checked == true)
            {
                MessageBox.Show(RadioButtonSiteVisit.Text + " selected");
                VisitorRegistration.Self.BtnMeetingAim.Text = RadioButtonSiteVisit.Text;
            }
            else if (RadioButtonStudentInterview.Checked == true)
            {
                MessageBox.Show(RadioButtonStudentInterview.Text + " selected");
                VisitorRegistration.Self.BtnMeetingAim.Text = RadioButtonStudentInterview.Text;
            }
            this.Close(); //close message box & Meeting aim
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meeting Aim is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close(); //close Meeting Aim Form
        }
    }
}