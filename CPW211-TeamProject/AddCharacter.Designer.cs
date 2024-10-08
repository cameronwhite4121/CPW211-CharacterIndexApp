﻿namespace CPW211_TeamProject
{
    partial class AddCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCharacter));
            btnAddCharacter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCharacterName = new TextBox();
            txtCharacterAge = new TextBox();
            groupBox1 = new GroupBox();
            rtxtPower = new RichTextBox();
            DTPDebutDate = new DateTimePicker();
            txtDebutIssue = new TextBox();
            label7 = new Label();
            txtCharacterRival = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddCharacter
            // 
            btnAddCharacter.Location = new Point(287, 238);
            btnAddCharacter.Name = "btnAddCharacter";
            btnAddCharacter.Size = new Size(106, 34);
            btnAddCharacter.TabIndex = 7;
            btnAddCharacter.Text = "Add Character";
            btnAddCharacter.UseVisualStyleBackColor = true;
            btnAddCharacter.Click += btnAddCharacter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 2;
            label1.Text = "Character's Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 78);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 3;
            label2.Text = "Character's Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 113);
            label3.Name = "label3";
            label3.Size = new Size(66, 30);
            label3.TabIndex = 4;
            label3.Text = "Character's\r\nPowers:";
            // 
            // txtCharacterName
            // 
            txtCharacterName.Location = new Point(157, 32);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(100, 23);
            txtCharacterName.TabIndex = 1;
            // 
            // txtCharacterAge
            // 
            txtCharacterAge.Location = new Point(157, 75);
            txtCharacterAge.Name = "txtCharacterAge";
            txtCharacterAge.Size = new Size(100, 23);
            txtCharacterAge.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtxtPower);
            groupBox1.Controls.Add(DTPDebutDate);
            groupBox1.Controls.Add(txtDebutIssue);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCharacterRival);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCharacterName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCharacterAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(33, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 191);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Character Details";
            // 
            // rtxtPower
            // 
            rtxtPower.Location = new Point(371, 110);
            rtxtPower.Name = "rtxtPower";
            rtxtPower.Size = new Size(212, 62);
            rtxtPower.TabIndex = 6;
            rtxtPower.Text = "";
            // 
            // DTPDebutDate
            // 
            DTPDebutDate.Location = new Point(371, 71);
            DTPDebutDate.MaxDate = new DateTime(2024, 8, 14, 0, 0, 0, 0);
            DTPDebutDate.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            DTPDebutDate.Name = "DTPDebutDate";
            DTPDebutDate.Size = new Size(212, 23);
            DTPDebutDate.TabIndex = 5;
            DTPDebutDate.Value = new DateTime(2024, 8, 13, 0, 0, 0, 0);
            // 
            // txtDebutIssue
            // 
            txtDebutIssue.Location = new Point(371, 32);
            txtDebutIssue.Name = "txtDebutIssue";
            txtDebutIssue.Size = new Size(212, 23);
            txtDebutIssue.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(283, 35);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 13;
            label7.Text = "Debut Issue:";
            // 
            // txtCharacterRival
            // 
            txtCharacterRival.Location = new Point(157, 120);
            txtCharacterRival.Name = "txtCharacterRival";
            txtCharacterRival.Size = new Size(100, 23);
            txtCharacterRival.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 128);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 79);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "Debut Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 123);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Main Rival:";
            // 
            // AddCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(698, 313);
            Controls.Add(groupBox1);
            Controls.Add(btnAddCharacter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCharacter";
            Text = "Add Character";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddCharacter;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCharacterName;
        private TextBox txtCharacterAge;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox txtCharacterRival;
        private Label label6;
        private TextBox txtDebutIssue;
        private Label label7;
        private DateTimePicker DTPDebutDate;
        private RichTextBox rtxtPower;
    }
}