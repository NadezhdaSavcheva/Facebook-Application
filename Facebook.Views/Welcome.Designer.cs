
namespace Facebook.Views
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.facebookPictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.welcomeContinueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facebookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // facebookPictureBox
            // 
            this.facebookPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("facebookPictureBox.Image")));
            this.facebookPictureBox.Location = new System.Drawing.Point(235, 71);
            this.facebookPictureBox.Name = "facebookPictureBox";
            this.facebookPictureBox.Size = new System.Drawing.Size(150, 150);
            this.facebookPictureBox.TabIndex = 0;
            this.facebookPictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(149, 240);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(337, 34);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Facebook!";
            // 
            // continueButton
            // 
            this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.continueButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.continueButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(-1647, 292);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(303, 48);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            // 
            // welcomeContinueButton
            // 
            this.welcomeContinueButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.welcomeContinueButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeContinueButton.ForeColor = System.Drawing.Color.White;
            this.welcomeContinueButton.Location = new System.Drawing.Point(72, 338);
            this.welcomeContinueButton.Name = "welcomeContinueButton";
            this.welcomeContinueButton.Size = new System.Drawing.Size(475, 48);
            this.welcomeContinueButton.TabIndex = 3;
            this.welcomeContinueButton.Text = "Continue";
            this.welcomeContinueButton.UseVisualStyleBackColor = false;
            this.welcomeContinueButton.Click += new System.EventHandler(this.welcomeContinueButton_Click);
            // 
            // Welcome
            // 
            this.AcceptButton = this.welcomeContinueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 462);
            this.Controls.Add(this.welcomeContinueButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.facebookPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(646, 509);
            this.MinimumSize = new System.Drawing.Size(646, 509);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Welcome_FormClosing);
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facebookPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox facebookPictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button welcomeContinueButton;
    }
}