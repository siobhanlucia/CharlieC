namespace CharlieC
{
    partial class MeetingAim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblSpecify = new System.Windows.Forms.Label();
            this.RadioButtonStudentInterview = new System.Windows.Forms.RadioButton();
            this.RadioButtonSalesAppointment = new System.Windows.Forms.RadioButton();
            this.RadioButtonSiteVisit = new System.Windows.Forms.RadioButton();
            this.RadioButtonMeeting = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(226, 260);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 28);
            this.BtnOK.TabIndex = 27;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(101, 260);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 28);
            this.BtnCancel.TabIndex = 26;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // LblSpecify
            // 
            this.LblSpecify.AutoSize = true;
            this.LblSpecify.Location = new System.Drawing.Point(48, 50);
            this.LblSpecify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSpecify.Name = "LblSpecify";
            this.LblSpecify.Size = new System.Drawing.Size(248, 16);
            this.LblSpecify.TabIndex = 25;
            this.LblSpecify.Text = "Please specify the nature of this meeting:";
            // 
            // RadioButtonStudentInterview
            // 
            this.RadioButtonStudentInterview.AutoSize = true;
            this.RadioButtonStudentInterview.Location = new System.Drawing.Point(202, 194);
            this.RadioButtonStudentInterview.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonStudentInterview.Name = "RadioButtonStudentInterview";
            this.RadioButtonStudentInterview.Size = new System.Drawing.Size(128, 20);
            this.RadioButtonStudentInterview.TabIndex = 24;
            this.RadioButtonStudentInterview.TabStop = true;
            this.RadioButtonStudentInterview.Text = "Student Interview";
            this.RadioButtonStudentInterview.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSalesAppointment
            // 
            this.RadioButtonSalesAppointment.AutoSize = true;
            this.RadioButtonSalesAppointment.Location = new System.Drawing.Point(202, 106);
            this.RadioButtonSalesAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonSalesAppointment.Name = "RadioButtonSalesAppointment";
            this.RadioButtonSalesAppointment.Size = new System.Drawing.Size(141, 20);
            this.RadioButtonSalesAppointment.TabIndex = 23;
            this.RadioButtonSalesAppointment.TabStop = true;
            this.RadioButtonSalesAppointment.Text = "Sales Appointment";
            this.RadioButtonSalesAppointment.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSiteVisit
            // 
            this.RadioButtonSiteVisit.AutoSize = true;
            this.RadioButtonSiteVisit.Location = new System.Drawing.Point(56, 194);
            this.RadioButtonSiteVisit.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonSiteVisit.Name = "RadioButtonSiteVisit";
            this.RadioButtonSiteVisit.Size = new System.Drawing.Size(79, 20);
            this.RadioButtonSiteVisit.TabIndex = 22;
            this.RadioButtonSiteVisit.TabStop = true;
            this.RadioButtonSiteVisit.Text = "Site Visit";
            this.RadioButtonSiteVisit.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMeeting
            // 
            this.RadioButtonMeeting.AutoSize = true;
            this.RadioButtonMeeting.Location = new System.Drawing.Point(56, 106);
            this.RadioButtonMeeting.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonMeeting.Name = "RadioButtonMeeting";
            this.RadioButtonMeeting.Size = new System.Drawing.Size(76, 20);
            this.RadioButtonMeeting.TabIndex = 21;
            this.RadioButtonMeeting.TabStop = true;
            this.RadioButtonMeeting.Text = "Meeting";
            this.RadioButtonMeeting.UseVisualStyleBackColor = true;
            // 
            // MeetingAim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 333);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblSpecify);
            this.Controls.Add(this.RadioButtonStudentInterview);
            this.Controls.Add(this.RadioButtonSalesAppointment);
            this.Controls.Add(this.RadioButtonSiteVisit);
            this.Controls.Add(this.RadioButtonMeeting);
            this.Name = "MeetingAim";
            this.Text = "MeetingAim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblSpecify;
        private System.Windows.Forms.RadioButton RadioButtonStudentInterview;
        private System.Windows.Forms.RadioButton RadioButtonSalesAppointment;
        private System.Windows.Forms.RadioButton RadioButtonSiteVisit;
        private System.Windows.Forms.RadioButton RadioButtonMeeting;
        public System.Windows.Forms.Button BtnOK;
    }
}