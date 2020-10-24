namespace Assignment_2
{
    partial class Form1
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
            this.listPatients = new System.Windows.Forms.ListBox();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelShowSex = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelShowID = new System.Windows.Forms.Label();
            this.labelShowBirth = new System.Windows.Forms.Label();
            this.labelShowPhone = new System.Windows.Forms.Label();
            this.labelShowAddress = new System.Windows.Forms.Label();
            this.labelShowName = new System.Windows.Forms.Label();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.groupPersonal = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBirth = new System.Windows.Forms.TextBox();
            this.labelDayOfBirth = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textPatientID = new System.Windows.Forms.TextBox();
            this.labelPatientRecord = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.labelAddress = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.groupBoxInstructions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupPersonal.SuspendLayout();
            this.groupBoxInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPatients
            // 
            this.listPatients.FormattingEnabled = true;
            this.listPatients.ItemHeight = 16;
            this.listPatients.Location = new System.Drawing.Point(487, 30);
            this.listPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listPatients.Name = "listPatients";
            this.listPatients.Size = new System.Drawing.Size(159, 116);
            this.listPatients.TabIndex = 11;
            this.listPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listPatients_MouseClick);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(325, 78);
            this.buttonAddToList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(92, 28);
            this.buttonAddToList.TabIndex = 12;
            this.buttonAddToList.Text = "Add";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(21, 219);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(181, 28);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search Patient By ID";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 20);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 17);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Full Name : ";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(31, 55);
            this.labelAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(68, 17);
            this.labelAddress1.TabIndex = 15;
            this.labelAddress1.Text = "Address :";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(31, 91);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(111, 17);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Phone Number :";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(31, 132);
            this.labelBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(98, 17);
            this.labelBirth.TabIndex = 17;
            this.labelBirth.Text = "Date Of Birth :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelShowSex);
            this.groupBox1.Controls.Add(this.labelSex);
            this.groupBox1.Controls.Add(this.labelShowID);
            this.groupBox1.Controls.Add(this.labelShowBirth);
            this.groupBox1.Controls.Add(this.labelShowPhone);
            this.groupBox1.Controls.Add(this.labelShowAddress);
            this.groupBox1.Controls.Add(this.labelShowName);
            this.groupBox1.Controls.Add(this.labelPatientID);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelBirth);
            this.groupBox1.Controls.Add(this.labelAddress1);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Location = new System.Drawing.Point(21, 290);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(457, 229);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // labelShowSex
            // 
            this.labelShowSex.AutoSize = true;
            this.labelShowSex.Location = new System.Drawing.Point(167, 209);
            this.labelShowSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowSex.Name = "labelShowSex";
            this.labelShowSex.Size = new System.Drawing.Size(0, 17);
            this.labelShowSex.TabIndex = 25;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(31, 213);
            this.labelSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(43, 17);
            this.labelSex.TabIndex = 24;
            this.labelSex.Text = "Sex : ";
            // 
            // labelShowID
            // 
            this.labelShowID.AutoSize = true;
            this.labelShowID.Location = new System.Drawing.Point(167, 174);
            this.labelShowID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowID.Name = "labelShowID";
            this.labelShowID.Size = new System.Drawing.Size(0, 17);
            this.labelShowID.TabIndex = 23;
            // 
            // labelShowBirth
            // 
            this.labelShowBirth.AutoSize = true;
            this.labelShowBirth.Location = new System.Drawing.Point(167, 132);
            this.labelShowBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowBirth.Name = "labelShowBirth";
            this.labelShowBirth.Size = new System.Drawing.Size(0, 17);
            this.labelShowBirth.TabIndex = 22;
            // 
            // labelShowPhone
            // 
            this.labelShowPhone.AutoSize = true;
            this.labelShowPhone.Location = new System.Drawing.Point(167, 91);
            this.labelShowPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowPhone.Name = "labelShowPhone";
            this.labelShowPhone.Size = new System.Drawing.Size(0, 17);
            this.labelShowPhone.TabIndex = 21;
            // 
            // labelShowAddress
            // 
            this.labelShowAddress.AutoSize = true;
            this.labelShowAddress.Location = new System.Drawing.Point(167, 55);
            this.labelShowAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowAddress.Name = "labelShowAddress";
            this.labelShowAddress.Size = new System.Drawing.Size(0, 17);
            this.labelShowAddress.TabIndex = 20;
            // 
            // labelShowName
            // 
            this.labelShowName.AutoSize = true;
            this.labelShowName.Location = new System.Drawing.Point(167, 20);
            this.labelShowName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShowName.Name = "labelShowName";
            this.labelShowName.Size = new System.Drawing.Size(0, 17);
            this.labelShowName.TabIndex = 19;
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Location = new System.Drawing.Point(31, 174);
            this.labelPatientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(119, 17);
            this.labelPatientID.TabIndex = 18;
            this.labelPatientID.Text = "Patient Record ID";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(211, 219);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(159, 22);
            this.textSearch.TabIndex = 19;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(211, 254);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(72, 28);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(131, 254);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(72, 28);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(23, 254);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(100, 28);
            this.buttonFirst.TabIndex = 22;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(291, 254);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(100, 28);
            this.buttonLast.TabIndex = 23;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // groupPersonal
            // 
            this.groupPersonal.Controls.Add(this.buttonUpdate);
            this.groupPersonal.Controls.Add(this.textBirth);
            this.groupPersonal.Controls.Add(this.labelDayOfBirth);
            this.groupPersonal.Controls.Add(this.buttonEdit);
            this.groupPersonal.Controls.Add(this.textPatientID);
            this.groupPersonal.Controls.Add(this.labelPatientRecord);
            this.groupPersonal.Controls.Add(this.labelFullName);
            this.groupPersonal.Controls.Add(this.textFullName);
            this.groupPersonal.Controls.Add(this.radioFemale);
            this.groupPersonal.Controls.Add(this.labelAddress);
            this.groupPersonal.Controls.Add(this.radioMale);
            this.groupPersonal.Controls.Add(this.buttonAddToList);
            this.groupPersonal.Controls.Add(this.textAddress);
            this.groupPersonal.Controls.Add(this.textPhoneNumber);
            this.groupPersonal.Controls.Add(this.labelPhoneNumber);
            this.groupPersonal.Location = new System.Drawing.Point(16, 15);
            this.groupPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPersonal.Name = "groupPersonal";
            this.groupPersonal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPersonal.Size = new System.Drawing.Size(463, 182);
            this.groupPersonal.TabIndex = 24;
            this.groupPersonal.TabStop = false;
            this.groupPersonal.Text = "Personal Information";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(325, 145);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(92, 28);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBirth
            // 
            this.textBirth.Location = new System.Drawing.Point(159, 145);
            this.textBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBirth.Name = "textBirth";
            this.textBirth.Size = new System.Drawing.Size(132, 22);
            this.textBirth.TabIndex = 12;
            // 
            // labelDayOfBirth
            // 
            this.labelDayOfBirth.AutoSize = true;
            this.labelDayOfBirth.Location = new System.Drawing.Point(8, 151);
            this.labelDayOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDayOfBirth.Name = "labelDayOfBirth";
            this.labelDayOfBirth.Size = new System.Drawing.Size(90, 17);
            this.labelDayOfBirth.TabIndex = 9;
            this.labelDayOfBirth.Text = "Date Of Birth";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(325, 110);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 28);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textPatientID
            // 
            this.textPatientID.Location = new System.Drawing.Point(159, 112);
            this.textPatientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPatientID.Name = "textPatientID";
            this.textPatientID.Size = new System.Drawing.Size(132, 22);
            this.textPatientID.TabIndex = 10;
            // 
            // labelPatientRecord
            // 
            this.labelPatientRecord.AutoSize = true;
            this.labelPatientRecord.Location = new System.Drawing.Point(8, 116);
            this.labelPatientRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatientRecord.Name = "labelPatientRecord";
            this.labelPatientRecord.Size = new System.Drawing.Size(119, 17);
            this.labelPatientRecord.TabIndex = 9;
            this.labelPatientRecord.Text = "Patient Record ID";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(8, 20);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(71, 17);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full Name";
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(159, 16);
            this.textFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(132, 22);
            this.textFullName.TabIndex = 1;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(339, 48);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(75, 21);
            this.radioFemale.TabIndex = 7;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(8, 52);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(339, 16);
            this.radioMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(59, 21);
            this.radioMale.TabIndex = 6;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(159, 48);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(132, 22);
            this.textAddress.TabIndex = 3;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(159, 80);
            this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.textPhoneNumber.TabIndex = 5;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(8, 84);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // groupBoxInstructions
            // 
            this.groupBoxInstructions.Controls.Add(this.label3);
            this.groupBoxInstructions.Controls.Add(this.label2);
            this.groupBoxInstructions.Controls.Add(this.label1);
            this.groupBoxInstructions.Location = new System.Drawing.Point(487, 166);
            this.groupBoxInstructions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInstructions.Name = "groupBoxInstructions";
            this.groupBoxInstructions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInstructions.Size = new System.Drawing.Size(193, 174);
            this.groupBoxInstructions.TabIndex = 25;
            this.groupBoxInstructions.TabStop = false;
            this.groupBoxInstructions.Text = "Instructions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "- Search patients using\r\npatient\'s ID.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "- All blanks must be \r\nfilled in before adding or\r\nediting.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "- No duplicates between\r\npatients name and ID.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 533);
            this.Controls.Add(this.groupBoxInstructions);
            this.Controls.Add(this.groupPersonal);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listPatients);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupPersonal.ResumeLayout(false);
            this.groupPersonal.PerformLayout();
            this.groupBoxInstructions.ResumeLayout(false);
            this.groupBoxInstructions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listPatients;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelShowID;
        private System.Windows.Forms.Label labelShowBirth;
        private System.Windows.Forms.Label labelShowPhone;
        private System.Windows.Forms.Label labelShowAddress;
        private System.Windows.Forms.Label labelShowName;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.GroupBox groupPersonal;
        private System.Windows.Forms.Label labelPatientRecord;
        private System.Windows.Forms.Label labelFullName;
        public System.Windows.Forms.TextBox textBirth;
        private System.Windows.Forms.Label labelDayOfBirth;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textPatientID;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelShowSex;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.GroupBox groupBoxInstructions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

