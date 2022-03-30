using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace CharlieC
{
    public partial class VisitorRegistration : Form
    {
        public static VisitorRegistration Self;

        MeetingAim aim = new MeetingAim();

        public VisitorRegistration()
        {
            InitializeComponent();
            Self = this;
        }

        public void BtnSignIn_Click(object sender, EventArgs e)
        {
            //Information will be added to listr box should all the requirements be met
            if (TextBoxName.Text == "") //First Name
            {
                TextBoxName.Focus(); //keeping the focus/readkey on this textbox when returning after error message
                MessageBox.Show("First name is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //pop-out error message
            }
            else if (TextBoxSurname.Text == "") //Surname
            {
                TextBoxSurname.Focus();
                MessageBox.Show("Surname is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextBoxMobile.Text == "") //Mobile
            {
                TextBoxMobile.Focus();
                MessageBox.Show("Mobile is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextBoxEmail.Text == "") //Email
            {
                TextBoxEmail.Focus();
                MessageBox.Show("Email is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DateTimePicker.Value < DateTime.Today) //Date
            {
                MessageBox.Show("Meeting Date is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NumericUpDownHour.Text == "") //Time Hour
            {
                NumericUpDownHour.Focus();
                MessageBox.Show("Meeting Hour is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NumericUpDownMinute.Text == "") //Time Minute
            {
                NumericUpDownMinute.Focus();
                MessageBox.Show("Meeting Minutes is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ComboBoxMeetingWith.Text == "") //Meeting With
            {
                MessageBox.Show("Meeting With is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BtnMeetingAim.Text == "Meeting Aim") //Meeting Aim
            {
                MessageBox.Show("Meeting Aim is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTimePicker.MinDate = DateTime.Now;
                UserDetailsListBox.Items.Add("Vistor Full Name: " + TextBoxName.Text + " " + TextBoxSurname.Text);
                UserDetailsListBox.Items.Add("Visitor Mobile: " + TextBoxMobile.Text);
                UserDetailsListBox.Items.Add("Visitor Email: " + TextBoxEmail.Text);
                UserDetailsListBox.Items.Add("Meeting Date: " + DateTimePicker.Text);
                UserDetailsListBox.Items.Add("Meeting Time: " + NumericUpDownHour.Text + ":" + NumericUpDownMinute.Text);
                UserDetailsListBox.Items.Add("Meeting With: " + ComboBoxMeetingWith.Text);
                UserDetailsListBox.Items.Add("Meeting Aim: " + BtnMeetingAim.Text);
                Clear();  //clear all fields after pressing Sign In
            }
        }
        void Clear()
        {
            //clear all inputs upon clicking Sign In Button
            TextBoxName.Clear();
            TextBoxSurname.Clear();
            TextBoxMobile.Clear();
            TextBoxEmail.Clear();
            DateTimePicker.Text = "";
            NumericUpDownHour.Text = "";
            NumericUpDownMinute.Text = "";
            ComboBoxMeetingWith.Text = "";
            BtnMeetingAim.Text = "Meeting Aim";
            TextBoxName.Focus();
        }

        private void BtnMeetingAim_Click_1(object sender, EventArgs e)
        {
            // Opens Meeting Aim Window
            MeetingAim aim = new MeetingAim();
            aim.Show();
        }

        private void TextBoxMobile_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A mobile number cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxEmail_Validating_1(object sender, CancelEventArgs e)
        {
            //regex defining necessary elements 
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+.[a-zA-Z0-9.-]$");
            //producing error message if requirements are not met
            if (TextBoxEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(TextBoxEmail.Text))
                {
                    MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxEmail.SelectAll();
                    //cancel closes error message and returns to Visitor Registration
                    e.Cancel = true;
                }
            }
        }
        //selctor visitor so receptionist can delete from listbox
        private void UserDetailsListBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete) //press delete key
            {
                while (UserDetailsListBox.SelectedItems.Count > 0)
                {
                    UserDetailsListBox.Items.Remove(UserDetailsListBox.SelectedItems[0]);
                }
            }
        }
    }
}


