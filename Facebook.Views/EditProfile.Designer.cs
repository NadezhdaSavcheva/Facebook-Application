
namespace Facebook.Views
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.editProfileLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.schoolLabel = new System.Windows.Forms.Label();
            this.workplaceLabel = new System.Windows.Forms.Label();
            this.cityCountryLabel = new System.Windows.Forms.Label();
            this.hobbiesLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cityCountryTextBox = new System.Windows.Forms.TextBox();
            this.hobbiesTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.workplaceTextBox = new System.Windows.Forms.TextBox();
            this.schoolTextBox = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editProfileLabel
            // 
            this.editProfileLabel.AutoSize = true;
            this.editProfileLabel.BackColor = System.Drawing.Color.Transparent;
            this.editProfileLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editProfileLabel.Location = new System.Drawing.Point(315, 22);
            this.editProfileLabel.Name = "editProfileLabel";
            this.editProfileLabel.Size = new System.Drawing.Size(164, 37);
            this.editProfileLabel.TabIndex = 0;
            this.editProfileLabel.Text = "Edit Profile";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(47, 83);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(112, 21);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description:";
            // 
            // schoolLabel
            // 
            this.schoolLabel.AutoSize = true;
            this.schoolLabel.BackColor = System.Drawing.Color.Transparent;
            this.schoolLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.schoolLabel.Location = new System.Drawing.Point(47, 132);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(74, 21);
            this.schoolLabel.TabIndex = 2;
            this.schoolLabel.Text = "School:";
            // 
            // workplaceLabel
            // 
            this.workplaceLabel.AutoSize = true;
            this.workplaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.workplaceLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workplaceLabel.Location = new System.Drawing.Point(47, 189);
            this.workplaceLabel.Name = "workplaceLabel";
            this.workplaceLabel.Size = new System.Drawing.Size(109, 21);
            this.workplaceLabel.TabIndex = 3;
            this.workplaceLabel.Text = "Workplace:";
            // 
            // cityCountryLabel
            // 
            this.cityCountryLabel.AutoSize = true;
            this.cityCountryLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityCountryLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityCountryLabel.Location = new System.Drawing.Point(47, 244);
            this.cityCountryLabel.Name = "cityCountryLabel";
            this.cityCountryLabel.Size = new System.Drawing.Size(133, 21);
            this.cityCountryLabel.TabIndex = 4;
            this.cityCountryLabel.Text = "City, Country:";
            // 
            // hobbiesLabel
            // 
            this.hobbiesLabel.AutoSize = true;
            this.hobbiesLabel.BackColor = System.Drawing.Color.Transparent;
            this.hobbiesLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hobbiesLabel.Location = new System.Drawing.Point(47, 297);
            this.hobbiesLabel.Name = "hobbiesLabel";
            this.hobbiesLabel.Size = new System.Drawing.Size(85, 21);
            this.hobbiesLabel.TabIndex = 5;
            this.hobbiesLabel.Text = "Hobbies:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(47, 349);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 21);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(186, 81);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(541, 27);
            this.descriptionTextBox.TabIndex = 7;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // cityCountryTextBox
            // 
            this.cityCountryTextBox.Location = new System.Drawing.Point(186, 242);
            this.cityCountryTextBox.Name = "cityCountryTextBox";
            this.cityCountryTextBox.Size = new System.Drawing.Size(541, 27);
            this.cityCountryTextBox.TabIndex = 8;
            this.cityCountryTextBox.TextChanged += new System.EventHandler(this.cityCountryTextBox_TextChanged);
            // 
            // hobbiesTextBox
            // 
            this.hobbiesTextBox.Location = new System.Drawing.Point(186, 295);
            this.hobbiesTextBox.Name = "hobbiesTextBox";
            this.hobbiesTextBox.Size = new System.Drawing.Size(541, 27);
            this.hobbiesTextBox.TabIndex = 9;
            this.hobbiesTextBox.TextChanged += new System.EventHandler(this.hobbiesTextBox_TextChanged);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(186, 347);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(541, 27);
            this.statusTextBox.TabIndex = 10;
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
            // 
            // workplaceTextBox
            // 
            this.workplaceTextBox.Location = new System.Drawing.Point(186, 183);
            this.workplaceTextBox.Name = "workplaceTextBox";
            this.workplaceTextBox.Size = new System.Drawing.Size(541, 27);
            this.workplaceTextBox.TabIndex = 11;
            this.workplaceTextBox.TextChanged += new System.EventHandler(this.workplaceTextBox_TextChanged);
            // 
            // schoolTextBox
            // 
            this.schoolTextBox.Location = new System.Drawing.Point(186, 130);
            this.schoolTextBox.Name = "schoolTextBox";
            this.schoolTextBox.Size = new System.Drawing.Size(541, 27);
            this.schoolTextBox.TabIndex = 12;
            this.schoolTextBox.TextChanged += new System.EventHandler(this.schoolTextBox_TextChanged);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.doneButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doneButton.ForeColor = System.Drawing.Color.White;
            this.doneButton.Location = new System.Drawing.Point(352, 400);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(94, 29);
            this.doneButton.TabIndex = 13;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.schoolTextBox);
            this.Controls.Add(this.workplaceTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.hobbiesTextBox);
            this.Controls.Add(this.cityCountryTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.cityCountryLabel);
            this.Controls.Add(this.workplaceLabel);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.editProfileLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "EditProfile";
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editProfileLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.Label workplaceLabel;
        private System.Windows.Forms.Label cityCountryLabel;
        private System.Windows.Forms.Label hobbiesLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox cityCountryTextBox;
        private System.Windows.Forms.TextBox hobbiesTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox workplaceTextBox;
        private System.Windows.Forms.TextBox schoolTextBox;
        private System.Windows.Forms.Button doneButton;
    }
}