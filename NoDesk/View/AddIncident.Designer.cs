﻿namespace NoDesk.View
{
    partial class AddIncident
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
            this.btn_addIncident = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inpt_incident_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inpt_incident_subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inpt_incident_dueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.inpt_incident_assignedEmployee = new System.Windows.Forms.ComboBox();
            this.inpt_incident_summary = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_editIncident = new System.Windows.Forms.Button();
            this.lbl_UserEmail = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inpt_incident_email = new System.Windows.Forms.TextBox();
            this.inpt_incidentStatus = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addIncident
            // 
            this.btn_addIncident.BackColor = System.Drawing.Color.Silver;
            this.btn_addIncident.Location = new System.Drawing.Point(833, 421);
            this.btn_addIncident.Name = "btn_addIncident";
            this.btn_addIncident.Size = new System.Drawing.Size(271, 80);
            this.btn_addIncident.TabIndex = 0;
            this.btn_addIncident.Text = "Add Incident";
            this.btn_addIncident.UseVisualStyleBackColor = false;
            this.btn_addIncident.Click += new System.EventHandler(this.btn_addIncident_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(147, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 11;
            // 
            // inpt_incident_user
            // 
            this.inpt_incident_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inpt_incident_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpt_incident_user.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_incident_user.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inpt_incident_user.Location = new System.Drawing.Point(164, 99);
            this.inpt_incident_user.Name = "inpt_incident_user";
            this.inpt_incident_user.Size = new System.Drawing.Size(243, 23);
            this.inpt_incident_user.TabIndex = 10;
            this.inpt_incident_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Subject";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(590, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 14;
            // 
            // inpt_incident_subject
            // 
            this.inpt_incident_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inpt_incident_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpt_incident_subject.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_incident_subject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inpt_incident_subject.Location = new System.Drawing.Point(608, 95);
            this.inpt_incident_subject.Name = "inpt_incident_subject";
            this.inpt_incident_subject.Size = new System.Drawing.Size(243, 23);
            this.inpt_incident_subject.TabIndex = 13;
            this.inpt_incident_subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(504, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Due Date";
            // 
            // inpt_incident_dueDate
            // 
            this.inpt_incident_dueDate.Location = new System.Drawing.Point(608, 158);
            this.inpt_incident_dueDate.Name = "inpt_incident_dueDate";
            this.inpt_incident_dueDate.Size = new System.Drawing.Size(271, 22);
            this.inpt_incident_dueDate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Assigned Employee";
            // 
            // inpt_incident_assignedEmployee
            // 
            this.inpt_incident_assignedEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inpt_incident_assignedEmployee.FormattingEnabled = true;
            this.inpt_incident_assignedEmployee.Location = new System.Drawing.Point(231, 220);
            this.inpt_incident_assignedEmployee.Name = "inpt_incident_assignedEmployee";
            this.inpt_incident_assignedEmployee.Size = new System.Drawing.Size(189, 24);
            this.inpt_incident_assignedEmployee.TabIndex = 23;
            this.inpt_incident_assignedEmployee.SelectedIndexChanged += new System.EventHandler(this.inpt_incident_assignedEmployee_SelectedIndexChanged);
            // 
            // inpt_incident_summary
            // 
            this.inpt_incident_summary.BackColor = System.Drawing.Color.White;
            this.inpt_incident_summary.Location = new System.Drawing.Point(40, 308);
            this.inpt_incident_summary.Name = "inpt_incident_summary";
            this.inpt_incident_summary.Size = new System.Drawing.Size(695, 193);
            this.inpt_incident_summary.TabIndex = 24;
            this.inpt_incident_summary.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Summary";
            // 
            // btn_editIncident
            // 
            this.btn_editIncident.BackColor = System.Drawing.Color.Silver;
            this.btn_editIncident.Location = new System.Drawing.Point(833, 308);
            this.btn_editIncident.Name = "btn_editIncident";
            this.btn_editIncident.Size = new System.Drawing.Size(271, 84);
            this.btn_editIncident.TabIndex = 26;
            this.btn_editIncident.Text = "Edit Incident";
            this.btn_editIncident.UseVisualStyleBackColor = false;
            this.btn_editIncident.Click += new System.EventHandler(this.btn_editIncident_Click);
            // 
            // lbl_UserEmail
            // 
            this.lbl_UserEmail.AutoSize = true;
            this.lbl_UserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserEmail.ForeColor = System.Drawing.Color.White;
            this.lbl_UserEmail.Location = new System.Drawing.Point(38, 157);
            this.lbl_UserEmail.Name = "lbl_UserEmail";
            this.lbl_UserEmail.Size = new System.Drawing.Size(100, 20);
            this.lbl_UserEmail.TabIndex = 29;
            this.lbl_UserEmail.Text = "User email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(228, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 28;
            // 
            // inpt_incident_email
            // 
            this.inpt_incident_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inpt_incident_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpt_incident_email.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_incident_email.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inpt_incident_email.Location = new System.Drawing.Point(245, 155);
            this.inpt_incident_email.Name = "inpt_incident_email";
            this.inpt_incident_email.Size = new System.Drawing.Size(162, 23);
            this.inpt_incident_email.TabIndex = 27;
            this.inpt_incident_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inpt_incidentStatus
            // 
            this.inpt_incidentStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inpt_incidentStatus.FormattingEnabled = true;
            this.inpt_incidentStatus.Location = new System.Drawing.Point(608, 222);
            this.inpt_incidentStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inpt_incidentStatus.Name = "inpt_incidentStatus";
            this.inpt_incidentStatus.Size = new System.Drawing.Size(127, 24);
            this.inpt_incidentStatus.TabIndex = 31;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(504, 224);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(63, 20);
            this.status.TabIndex = 30;
            this.status.Text = "Status";
            // 
            // AddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1153, 532);
            this.Controls.Add(this.inpt_incidentStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lbl_UserEmail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.inpt_incident_email);
            this.Controls.Add(this.btn_editIncident);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inpt_incident_summary);
            this.Controls.Add(this.inpt_incident_assignedEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpt_incident_dueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.inpt_incident_subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inpt_incident_user);
            this.Controls.Add(this.btn_addIncident);
            this.Name = "AddIncident";
            this.Text = "AddIncident";
            this.Load += new System.EventHandler(this.AddIncident_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inpt_incident_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inpt_incident_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker inpt_incident_dueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inpt_incident_assignedEmployee;
        private System.Windows.Forms.RichTextBox inpt_incident_summary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_editIncident;
        private System.Windows.Forms.Label lbl_UserEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox inpt_incident_email;
        private System.Windows.Forms.ComboBox inpt_incidentStatus;
        private System.Windows.Forms.Label status;
    }
}