namespace Hash_Table_Abonent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonBirthday = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBadHash = new System.Windows.Forms.CheckBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKeyFind = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(12, 37);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(144, 29);
            this.radioButtonName.TabIndex = 0;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Name (string)";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhone
            // 
            this.radioButtonPhone.AutoSize = true;
            this.radioButtonPhone.Location = new System.Drawing.Point(12, 72);
            this.radioButtonPhone.Name = "radioButtonPhone";
            this.radioButtonPhone.Size = new System.Drawing.Size(165, 29);
            this.radioButtonPhone.TabIndex = 1;
            this.radioButtonPhone.TabStop = true;
            this.radioButtonPhone.Text = "Phone (numeric)";
            this.radioButtonPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonBirthday
            // 
            this.radioButtonBirthday.AutoSize = true;
            this.radioButtonBirthday.Location = new System.Drawing.Point(12, 107);
            this.radioButtonBirthday.Name = "radioButtonBirthday";
            this.radioButtonBirthday.Size = new System.Drawing.Size(180, 29);
            this.radioButtonBirthday.TabIndex = 2;
            this.radioButtonBirthday.TabStop = true;
            this.radioButtonBirthday.Text = "Birthday (numeric)";
            this.radioButtonBirthday.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select keys:";
            // 
            // checkBoxBadHash
            // 
            this.checkBoxBadHash.AutoSize = true;
            this.checkBoxBadHash.Location = new System.Drawing.Point(12, 142);
            this.checkBoxBadHash.Name = "checkBoxBadHash";
            this.checkBoxBadHash.Size = new System.Drawing.Size(158, 29);
            this.checkBoxBadHash.TabIndex = 4;
            this.checkBoxBadHash.Text = "Use \"Bad hash\"";
            this.checkBoxBadHash.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 177);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(193, 44);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key to find:";
            // 
            // textBoxKeyFind
            // 
            this.textBoxKeyFind.Location = new System.Drawing.Point(12, 289);
            this.textBoxKeyFind.Name = "textBoxKeyFind";
            this.textBoxKeyFind.Size = new System.Drawing.Size(193, 31);
            this.textBoxKeyFind.TabIndex = 7;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 326);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(193, 42);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(211, 563);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 25);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name: null";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(211, 588);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(99, 25);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Phone: null";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(211, 613);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(114, 25);
            this.labelBirthday.TabIndex = 11;
            this.labelBirthday.Text = "Birthday: null";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(12, 510);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(124, 25);
            this.labelSteps.TabIndex = 12;
            this.labelSteps.Text = "- steps to find";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(211, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 529);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(12, 374);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(193, 133);
            this.textBoxInfo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 675);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxKeyFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.checkBoxBadHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonBirthday);
            this.Controls.Add(this.radioButtonPhone);
            this.Controls.Add(this.radioButtonName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButtonName;
        private RadioButton radioButtonPhone;
        private RadioButton radioButtonBirthday;
        private Label label1;
        private CheckBox checkBoxBadHash;
        private Button buttonLoad;
        private Label label2;
        private TextBox textBoxKeyFind;
        private Button buttonFind;
        private Label labelName;
        private Label labelPhone;
        private Label labelBirthday;
        private Label labelSteps;
        private PictureBox pictureBox1;
        private TextBox textBoxInfo;
    }
}