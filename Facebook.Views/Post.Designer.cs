
namespace Facebook.Views
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            this.backButton = new System.Windows.Forms.Button();
            this.postPictureBox = new System.Windows.Forms.PictureBox();
            this.authorPictureBox = new System.Windows.Forms.PictureBox();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(694, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // postPictureBox
            // 
            this.postPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("postPictureBox.Image")));
            this.postPictureBox.Location = new System.Drawing.Point(123, 202);
            this.postPictureBox.Name = "postPictureBox";
            this.postPictureBox.Size = new System.Drawing.Size(538, 227);
            this.postPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.postPictureBox.TabIndex = 19;
            this.postPictureBox.TabStop = false;
            // 
            // authorPictureBox
            // 
            this.authorPictureBox.Location = new System.Drawing.Point(12, 12);
            this.authorPictureBox.MaximumSize = new System.Drawing.Size(50, 50);
            this.authorPictureBox.MinimumSize = new System.Drawing.Size(50, 50);
            this.authorPictureBox.Name = "authorPictureBox";
            this.authorPictureBox.Size = new System.Drawing.Size(50, 50);
            this.authorPictureBox.TabIndex = 20;
            this.authorPictureBox.TabStop = false;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(68, 27);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(148, 20);
            this.authorNameLabel.TabIndex = 21;
            this.authorNameLabel.Text = "First name Last name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(80, 84);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(634, 100);
            this.descriptionLabel.TabIndex = 22;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.authorPictureBox);
            this.Controls.Add(this.postPictureBox);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Post";
            this.Text = "Post";
            this.Load += new System.EventHandler(this.Post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox postPictureBox;
        private System.Windows.Forms.PictureBox authorPictureBox;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}