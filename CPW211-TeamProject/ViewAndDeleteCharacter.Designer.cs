namespace CPW211_TeamProject
{
    partial class ViewAndDeleteCharacter
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
            btnUpdateCharacter = new Button();
            btnDeleteCharacter = new Button();
            lsbxCharacterList = new ListBox();
            groupBox1 = new GroupBox();
            dtpDebutDate = new DateTimePicker();
            txtDebutIssue = new TextBox();
            label7 = new Label();
            txtCharacterRival = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCharacterName = new TextBox();
            txtCharacterPower = new TextBox();
            label1 = new Label();
            txtCharacterAge = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateCharacter
            // 
            btnUpdateCharacter.Location = new Point(311, 95);
            btnUpdateCharacter.Name = "btnUpdateCharacter";
            btnUpdateCharacter.Size = new Size(112, 38);
            btnUpdateCharacter.TabIndex = 0;
            btnUpdateCharacter.Text = "Update Character";
            btnUpdateCharacter.UseVisualStyleBackColor = true;
            btnUpdateCharacter.Click += btnUpdateCharacter_Click;
            // 
            // btnDeleteCharacter
            // 
            btnDeleteCharacter.Location = new Point(311, 197);
            btnDeleteCharacter.Name = "btnDeleteCharacter";
            btnDeleteCharacter.Size = new Size(112, 38);
            btnDeleteCharacter.TabIndex = 2;
            btnDeleteCharacter.Text = "Delete Character";
            btnDeleteCharacter.UseVisualStyleBackColor = true;
            btnDeleteCharacter.Click += btnDeleteCharacter_Click;
            // 
            // lsbxCharacterList
            // 
            lsbxCharacterList.FormattingEnabled = true;
            lsbxCharacterList.ItemHeight = 15;
            lsbxCharacterList.Location = new Point(37, 30);
            lsbxCharacterList.Name = "lsbxCharacterList";
            lsbxCharacterList.Size = new Size(236, 274);
            lsbxCharacterList.TabIndex = 3;
            lsbxCharacterList.SelectedIndexChanged += lsbxCharacterList_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDebutDate);
            groupBox1.Controls.Add(txtDebutIssue);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCharacterRival);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCharacterName);
            groupBox1.Controls.Add(txtCharacterPower);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCharacterAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(456, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 274);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Character Details";
            // 
            // dtpDebutDate
            // 
            dtpDebutDate.Location = new Point(155, 195);
            dtpDebutDate.MaxDate = new DateTime(2024, 8, 14, 0, 0, 0, 0);
            dtpDebutDate.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtpDebutDate.Name = "dtpDebutDate";
            dtpDebutDate.Size = new Size(100, 23);
            dtpDebutDate.TabIndex = 15;
            dtpDebutDate.Value = new DateTime(2024, 8, 13, 0, 0, 0, 0);
            // 
            // txtDebutIssue
            // 
            txtDebutIssue.Location = new Point(155, 233);
            txtDebutIssue.Name = "txtDebutIssue";
            txtDebutIssue.Size = new Size(100, 23);
            txtDebutIssue.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 236);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 13;
            label7.Text = "Debut Issue:";
            // 
            // txtCharacterRival
            // 
            txtCharacterRival.Location = new Point(155, 151);
            txtCharacterRival.Name = "txtCharacterRival";
            txtCharacterRival.Size = new Size(100, 23);
            txtCharacterRival.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 150);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 195);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "Debut Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 154);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Main Rival:";
            // 
            // txtCharacterName
            // 
            txtCharacterName.Location = new Point(155, 25);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(100, 23);
            txtCharacterName.TabIndex = 5;
            // 
            // txtCharacterPower
            // 
            txtCharacterPower.Location = new Point(155, 107);
            txtCharacterPower.Name = "txtCharacterPower";
            txtCharacterPower.Size = new Size(100, 23);
            txtCharacterPower.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 2;
            label1.Text = "Character's Name:";
            // 
            // txtCharacterAge
            // 
            txtCharacterAge.Location = new Point(155, 66);
            txtCharacterAge.Name = "txtCharacterAge";
            txtCharacterAge.Size = new Size(100, 23);
            txtCharacterAge.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 69);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 3;
            label2.Text = "Character's Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 110);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 4;
            label3.Text = "Character's Power:";
            // 
            // ViewAndDeleteCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(789, 362);
            Controls.Add(groupBox1);
            Controls.Add(lsbxCharacterList);
            Controls.Add(btnDeleteCharacter);
            Controls.Add(btnUpdateCharacter);
            Name = "ViewAndDeleteCharacter";
            Text = "View/Delete Character";
            Load += ViewAndDeleteCharacter_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateCharacter;
        private Button btnDeleteCharacter;
        private ListBox lsbxCharacterList;
        private GroupBox groupBox1;
        private TextBox txtDebutIssue;
        private Label label7;
        private TextBox txtCharacterRival;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtCharacterName;
        private TextBox txtCharacterPower;
        private Label label1;
        private TextBox txtCharacterAge;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDebutDate;
    }
}