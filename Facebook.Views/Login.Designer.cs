
namespace Facebook.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.facebookLoginPictureBox = new System.Windows.Forms.PictureBox();
            this.emailLoginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.entranceButton = new System.Windows.Forms.Button();
            this.forgottenPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // facebookLoginPictureBox
            // 
            this.facebookLoginPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facebookLoginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("facebookLoginPictureBox.Image")));
            this.facebookLoginPictureBox.Location = new System.Drawing.Point(283, 50);
            this.facebookLoginPictureBox.Name = "facebookLoginPictureBox";
            this.facebookLoginPictureBox.Size = new System.Drawing.Size(62, 62);
            this.facebookLoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.facebookLoginPictureBox.TabIndex = 0;
            this.facebookLoginPictureBox.TabStop = false;
            this.facebookLoginPictureBox.Click += new System.EventHandler(this.facebookLoginPictureBox_Click);
            // 
            // emailLoginTextBox
            // 
            this.emailLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLoginTextBox.Location = new System.Drawing.Point(77, 149);
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.PlaceholderText = "Mobile number or email";
            this.emailLoginTextBox.Size = new System.Drawing.Size(475, 27);
            this.emailLoginTextBox.TabIndex = 1;
            // 
            // passwordLoginTextBox
            // 
            this.passwordLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLoginTextBox.Location = new System.Drawing.Point(77, 182);
            this.passwordLoginTextBox.Name = "passwordLoginTextBox";
            this.passwordLoginTextBox.PlaceholderText = "Password";
            this.passwordLoginTextBox.Size = new System.Drawing.Size(475, 27);
            this.passwordLoginTextBox.TabIndex = 2;
            // 
            // entranceButton
            // 
            this.entranceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entranceButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.entranceButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.entranceButton.ForeColor = System.Drawing.Color.White;
            this.entranceButton.Location = new System.Drawing.Point(77, 265);
            this.entranceButton.Name = "entranceButton";
            this.entranceButton.Size = new System.Drawing.Size(475, 48);
            this.entranceButton.TabIndex = 3;
            this.entranceButton.Text = "Entrance";
            this.entranceButton.UseVisualStyleBackColor = false;
            this.entranceButton.Click += new System.EventHandler(this.entranceButton_Click);
            // 
            // forgottenPasswordLinkLabel
            // 
            this.forgottenPasswordLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forgottenPasswordLinkLabel.AutoSize = true;
            this.forgottenPasswordLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgottenPasswordLinkLabel.LinkColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.forgottenPasswordLinkLabel.Location = new System.Drawing.Point(241, 321);
            this.forgottenPasswordLinkLabel.Name = "forgottenPasswordLinkLabel";
            this.forgottenPasswordLinkLabel.Size = new System.Drawing.Size(148, 20);
            this.forgottenPasswordLinkLabel.TabIndex = 4;
            this.forgottenPasswordLinkLabel.TabStop = true;
            this.forgottenPasswordLinkLabel.Text = "Forgotten password?";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newAccountButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.newAccountButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newAccountButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.newAccountButton.Location = new System.Drawing.Point(223, 366);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(183, 56);
            this.newAccountButton.TabIndex = 5;
            this.newAccountButton.Text = "Create a new account";
            this.newAccountButton.UseVisualStyleBackColor = false;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(77, 212);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(347, 20);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "You have entered an invalid username or password.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 462);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.forgottenPasswordLinkLabel);
            this.Controls.Add(this.entranceButton);
            this.Controls.Add(this.passwordLoginTextBox);
            this.Controls.Add(this.emailLoginTextBox);
            this.Controls.Add(this.facebookLoginPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(646, 509);
            this.MinimumSize = new System.Drawing.Size(646, 509);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.facebookLoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox facebookLoginPictureBox;
        private System.Windows.Forms.TextBox emailLoginTextBox;
        private System.Windows.Forms.TextBox passwordLoginTextBox;
        private System.Windows.Forms.Button entranceButton;
        private System.Windows.Forms.LinkLabel forgottenPasswordLinkLabel;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

