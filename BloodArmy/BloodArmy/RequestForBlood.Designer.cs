namespace BloodArmy
{
    partial class RequestForBlood
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.labelBloodGroup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxThana = new System.Windows.Forms.ComboBox();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.comboBoxDivision = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxNoOfRequests = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Name";
            this.label1.Click += new System.EventHandler(this.labelContactName);
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.Location = new System.Drawing.Point(29, 66);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactName.TabIndex = 1;
            this.textBoxContactName.TextChanged += new System.EventHandler(this.textBoxContactName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(29, 141);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactNumber.TabIndex = 3;
            this.textBoxContactNumber.TextChanged += new System.EventHandler(this.textBoxContactNumber_TextChanged);
            // 
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.FormattingEnabled = true;
            this.comboBoxBloodGroup.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "B+",
            "B-"});
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(29, 217);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBloodGroup.TabIndex = 4;
            this.comboBoxBloodGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxBloodGroup_SelectedIndexChanged);
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.Location = new System.Drawing.Point(29, 198);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.labelBloodGroup.TabIndex = 5;
            this.labelBloodGroup.Text = "Blood Group";
            this.labelBloodGroup.Click += new System.EventHandler(this.labelBloodGroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "No. Of Units";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxThana
            // 
            this.comboBoxThana.FormattingEnabled = true;
            this.comboBoxThana.Location = new System.Drawing.Point(29, 499);
            this.comboBoxThana.Name = "comboBoxThana";
            this.comboBoxThana.Size = new System.Drawing.Size(121, 21);
            this.comboBoxThana.TabIndex = 33;
            this.comboBoxThana.SelectedIndexChanged += new System.EventHandler(this.comboBoxThana_SelectedIndexChanged);
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(29, 436);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDistrict.TabIndex = 32;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // comboBoxDivision
            // 
            this.comboBoxDivision.FormattingEnabled = true;
            this.comboBoxDivision.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Sylhet ",
            "Rajshah",
            "Barisal",
            "Khulna",
            "Rangpur",
            "Mymensingh"});
            this.comboBoxDivision.Location = new System.Drawing.Point(29, 366);
            this.comboBoxDivision.Name = "comboBoxDivision";
            this.comboBoxDivision.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDivision.TabIndex = 31;
            this.comboBoxDivision.SelectedIndexChanged += new System.EventHandler(this.comboBoxDivision_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Thana";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "District";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Division";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonRequest);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Edit Profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonEditProfile);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonLogOut);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "name:";
            this.label4.Click += new System.EventHandler(this.labelNameOfUser);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "No. Of Requests";
            // 
            // comboBoxNoOfRequests
            // 
            this.comboBoxNoOfRequests.FormattingEnabled = true;
            this.comboBoxNoOfRequests.Items.AddRange(new object[] {
            "Accept",
            "Reject"});
            this.comboBoxNoOfRequests.Location = new System.Drawing.Point(247, 141);
            this.comboBoxNoOfRequests.Name = "comboBoxNoOfRequests";
            this.comboBoxNoOfRequests.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoOfRequests.TabIndex = 39;
            this.comboBoxNoOfRequests.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RequestForBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 573);
            this.Controls.Add(this.comboBoxNoOfRequests);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxThana);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.comboBoxDivision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelBloodGroup);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.textBoxContactNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContactName);
            this.Controls.Add(this.label1);
            this.Name = "RequestForBlood";
            this.Text = "RequestForBlood";
            this.Load += new System.EventHandler(this.RequestForBlood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.Label labelBloodGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxThana;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.ComboBox comboBoxDivision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxNoOfRequests;
    }
}