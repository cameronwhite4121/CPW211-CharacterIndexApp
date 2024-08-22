namespace CPW211_TeamProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnViewDeleteCharacterForm = new Button();
            btnAddCharacterForm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(452, 45);
            label1.TabIndex = 0;
            label1.Text = "Marvel/Dc Character Index";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 248);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnViewDeleteCharacterForm
            // 
            btnViewDeleteCharacterForm.Anchor = AnchorStyles.None;
            btnViewDeleteCharacterForm.Location = new Point(304, 396);
            btnViewDeleteCharacterForm.Name = "btnViewDeleteCharacterForm";
            btnViewDeleteCharacterForm.Size = new Size(124, 43);
            btnViewDeleteCharacterForm.TabIndex = 3;
            btnViewDeleteCharacterForm.Text = "View/Delete Character Form";
            btnViewDeleteCharacterForm.UseVisualStyleBackColor = true;
            btnViewDeleteCharacterForm.Click += btnViewDeleteCharacterForm_Click;
            // 
            // btnAddCharacterForm
            // 
            btnAddCharacterForm.Anchor = AnchorStyles.None;
            btnAddCharacterForm.Location = new Point(76, 396);
            btnAddCharacterForm.Name = "btnAddCharacterForm";
            btnAddCharacterForm.Size = new Size(124, 43);
            btnAddCharacterForm.TabIndex = 4;
            btnAddCharacterForm.Text = "Add Character Form";
            btnAddCharacterForm.UseVisualStyleBackColor = true;
            btnAddCharacterForm.Click += btnAddCharacterForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(499, 497);
            Controls.Add(btnAddCharacterForm);
            Controls.Add(btnViewDeleteCharacterForm);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Character Index";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnViewDeleteCharacterForm;
        private Button btnAddCharacterForm;
    }
}
