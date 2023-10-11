namespace WindowsFormsApp16
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
            this.groupBoxAnket = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.phoneMtb = new System.Windows.Forms.MaskedTextBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.fileNametxtb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.groupBoxAnket.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnket
            // 
            this.groupBoxAnket.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxAnket.Controls.Add(this.button1);
            this.groupBoxAnket.Controls.Add(this.dateTimePicker1);
            this.groupBoxAnket.Controls.Add(this.emailTxtb);
            this.groupBoxAnket.Controls.Add(this.surnameTxtb);
            this.groupBoxAnket.Controls.Add(this.nameTxtb);
            this.groupBoxAnket.Controls.Add(this.phoneMtb);
            this.groupBoxAnket.Controls.Add(this.changeBtn);
            this.groupBoxAnket.Controls.Add(this.addBtn);
            this.groupBoxAnket.Controls.Add(this.clearBtn);
            this.groupBoxAnket.Controls.Add(this.label1);
            this.groupBoxAnket.Controls.Add(this.lblPhone);
            this.groupBoxAnket.Controls.Add(this.lblEmail);
            this.groupBoxAnket.Controls.Add(this.lblSurname);
            this.groupBoxAnket.Controls.Add(this.lblName);
            this.groupBoxAnket.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxAnket.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAnket.Name = "groupBoxAnket";
            this.groupBoxAnket.Size = new System.Drawing.Size(445, 501);
            this.groupBoxAnket.TabIndex = 0;
            this.groupBoxAnket.TabStop = false;
            this.groupBoxAnket.Text = "A n k e t";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 38);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // emailTxtb
            // 
            this.emailTxtb.Location = new System.Drawing.Point(186, 189);
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(240, 38);
            this.emailTxtb.TabIndex = 9;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.Location = new System.Drawing.Point(186, 119);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(240, 38);
            this.surnameTxtb.TabIndex = 7;
            // 
            // nameTxtb
            // 
            this.nameTxtb.Location = new System.Drawing.Point(186, 54);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(240, 38);
            this.nameTxtb.TabIndex = 8;
            // 
            // phoneMtb
            // 
            this.phoneMtb.Location = new System.Drawing.Point(186, 266);
            this.phoneMtb.Name = "phoneMtb";
            this.phoneMtb.Size = new System.Drawing.Size(240, 38);
            this.phoneMtb.TabIndex = 4;
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeBtn.ForeColor = System.Drawing.Color.Black;
            this.changeBtn.Location = new System.Drawing.Point(242, 383);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(184, 53);
            this.changeBtn.TabIndex = 1;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(13, 383);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(183, 53);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(13, 442);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(183, 53);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birth Date :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 266);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(161, 38);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "       Phone :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(161, 38);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "        Email :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(6, 119);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(160, 38);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "  Surname :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(156, 38);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "       Name :";
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListBox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 31;
            this.ListBox.Location = new System.Drawing.Point(470, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(366, 376);
            this.ListBox.TabIndex = 1;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(464, 403);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(125, 31);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "File name";
            // 
            // fileNametxtb
            // 
            this.fileNametxtb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNametxtb.Location = new System.Drawing.Point(605, 403);
            this.fileNametxtb.Multiline = true;
            this.fileNametxtb.Name = "fileNametxtb";
            this.fileNametxtb.Size = new System.Drawing.Size(231, 31);
            this.fileNametxtb.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.saveBtn.Location = new System.Drawing.Point(470, 455);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(153, 59);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "S a v e";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.Yellow;
            this.loadBtn.Location = new System.Drawing.Point(671, 455);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(165, 59);
            this.loadBtn.TabIndex = 6;
            this.loadBtn.Text = "L o a d";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 526);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fileNametxtb);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.groupBoxAnket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAnket.ResumeLayout(false);
            this.groupBoxAnket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAnket;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.MaskedTextBox phoneMtb;
        private System.Windows.Forms.TextBox fileNametxtb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}

