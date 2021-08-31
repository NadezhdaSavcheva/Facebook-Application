
namespace Facebook.Views
{
    partial class CreatePost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePost));
            this.createPostLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.homePageButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createPostLabel
            // 
            this.createPostLabel.AutoSize = true;
            this.createPostLabel.BackColor = System.Drawing.Color.Transparent;
            this.createPostLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPostLabel.Location = new System.Drawing.Point(309, 26);
            this.createPostLabel.Name = "createPostLabel";
            this.createPostLabel.Size = new System.Drawing.Size(183, 37);
            this.createPostLabel.TabIndex = 0;
            this.createPostLabel.Text = "Create Post";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(131, 89);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "What are you thinking about?";
            this.descriptionTextBox.Size = new System.Drawing.Size(538, 27);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.createButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(353, 394);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 29);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.homePageButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.000003F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homePageButton.ForeColor = System.Drawing.Color.White;
            this.homePageButton.Location = new System.Drawing.Point(131, 394);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(89, 25);
            this.homePageButton.TabIndex = 16;
            this.homePageButton.Text = "Home Page";
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.profileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Location = new System.Drawing.Point(604, 394);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(65, 25);
            this.profileButton.TabIndex = 17;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("uploadPictureBox.Image")));
            this.uploadPictureBox.Location = new System.Drawing.Point(131, 140);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(538, 227);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.uploadPictureBox.TabIndex = 18;
            this.uploadPictureBox.TabStop = false;
            this.uploadPictureBox.Click += new System.EventHandler(this.uploadPictureBox_Click);
            // 
            // CreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uploadPictureBox);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.createPostLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "CreatePost";
            this.Text = "CreatePost";
            this.Load += new System.EventHandler(this.CreatePost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPostLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button homePageButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.PictureBox uploadPictureBox;
    }
}