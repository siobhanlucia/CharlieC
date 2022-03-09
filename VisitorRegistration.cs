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
        public struct Visitor
        {
            public string Name;
            public string Surname;
            public string Mobile;
            public string Email;
            public string Date;
            public string Hour;
            public string Minute;
            public string MeetingPerson;
            public string MeetingAim;

        };

        public List<string> visitors = new List<string>();


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
            if (TextBoxName.Text == "")
            {
                TextBoxName.Focus(); //keeping the focus/readkey on this textbox when returning after error message
                MessageBox.Show("First name is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //pop-out error message
            }
            //else
            //{
            // //   UserDetailsListBox.Items.Add("Visitior First Name: " + TextBoxName.Text);//clarifying information
            //    visitors.Add(TextBoxName.Text);
            //}
            //Surname
            //string surname = TextBoxSurname.Text;
            else if (TextBoxSurname.Text == "")
            {
                TextBoxSurname.Focus();
                MessageBox.Show("Surname is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //{
            //    UserDetailsListBox.Items.Add("Visitior Surname: " + TextBoxSurname.Text);//clarifying information
            //    visitors.Add(TextBoxSurname.Text);
            //}
            //Mobile
            //string Mobile = TextBoxMobile.Text;
            else if (TextBoxMobile.Text == "")
            {
                TextBoxMobile.Focus();
                MessageBox.Show("Mobile is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //{
            //    UserDetailsListBox.Items.Add("Visitior Mobile: " + TextBoxMobile.Text);//clarifying information
            //    visitors.Add(TextBoxMobile.Text);
            //}

            //string email = TextBoxEmail.Text;
            else if (TextBoxEmail.Text == "")
            {
                TextBoxEmail.Focus();
                MessageBox.Show("Email is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //{
            //    UserDetailsListBox.Items.Add("Visitior Email: " + TextBoxEmail.Text);
            //    visitors.Add(TextBoxEmail.Text);
            //}

           else if (DateTimePicker.Text == "01/03/2022")
            {
                DateTimePicker.Focus();
                MessageBox.Show("Meeting Date is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //{
            //    UserDetailsListBox.Items.Add("Meeting Date is: " + DateTimePicker.Text);
            //    visitors.Add(DateTimePicker.Text);
            //}
            ////Meeting time
            //string date = NumericUpDownHour.Text;
           else if (NumericUpDownHour.Text == "")
            {
                NumericUpDownHour.Focus();
                MessageBox.Show("Meeting Hour is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (NumericUpDownMinute.Text == "")
            {
                NumericUpDownMinute.Focus();
                MessageBox.Show("Meeting Minutes is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //{
            //    UserDetailsListBox.Items.Add("Meeting time: " + NumericUpDownHour.Text + ":" + NumericUpDownMinute.Text);
            //    V.Hour =NumericUpDownHour.Text);
            //    V.Minute = NumericUpDownMinute.Text;
            //}
            //Meeting With
            //string meetingwith = ComboBoxMeetingWith.Text;
            else if (ComboBoxMeetingWith.Text == "")
            {
                MessageBox.Show("Meeting With is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //UserDetailsListBox.Items.Add("Meeting With: " + ComboBoxMeetingWith.Text);
                //V.MeetingPerson = ComboBoxMeetingWith.Text;
            }
            //else
            //{
            //    MessageBox.Show("Meeting With is mandatory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //Enter Meeting Aim into ist
            //UserDetailsListBox.Items.Add("Meeting Aim is: " + BtnMeetingAim.Text);
            //V.MeetingAim = BtnMeetingAim.Text;

            //if (V.Name != null && V.Surname != null &&
            //    V.Mobile != null && V.Email != null &&
            //    V.Date != null && V.MeetingPerson != null &&
            //    V.MeetingAim != null)
            //{
            //    visitors.Add(V);
            //    foreach (Visitor person in visitors)
            //    {
            //        UserDetailsListBox.Items.Add("Visitior First Name: " + TextBoxName.Text + " /n Visitior Surname: " + TextBoxSurname.Text);

            //    }
            //}
            else
            {
              UserDetailsListBox.Items.Add("Vistor Full Name: "+TextBoxName.Text +" "+ TextBoxSurname.Text + TextBoxMobile.Text + TextBoxEmail.Text + DateTimePicker.Text + NumericUpDownHour.Text + NumericUpDownMinute.Text + ComboBoxMeetingWith.Text + BtnMeetingAim.Text);
                Clear();  //clear all fields after pressing Sign In
            }

            
            //V = new Visitor();
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
            ComboBoxMeetingWith.Items.Clear();
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


        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
   
        }

        

        //selctor visitor so receptionist can delete from listbox
        private void UserDetailsListBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete) //press delete key
            {
                if (UserDetailsListBox.SelectedIndex != -1)
                {
                    UserDetailsListBox.Items.RemoveAt(UserDetailsListBox.SelectedIndex); //deletes selected information
                }
            }
        }

        private void UserDetailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}


