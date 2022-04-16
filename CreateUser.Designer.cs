namespace DCUFinalProject
{
    partial class CreateUser
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastName.Location = new System.Drawing.Point(12, 44);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(180, 29);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "LAST NAME";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(12, 79);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(180, 29);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "EMAIL";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 114);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(180, 29);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "PHONE NUMBER";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Location = new System.Drawing.Point(198, 44);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "User Last Name";
            this.txtName.Size = new System.Drawing.Size(296, 29);
            this.txtName.TabIndex = 6;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLastName.Location = new System.Drawing.Point(198, 79);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "User Email";
            this.txtLastName.Size = new System.Drawing.Size(296, 29);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Location = new System.Drawing.Point(198, 9);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "User Name";
            this.txtEmail.Size = new System.Drawing.Size(296, 29);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPhoneNumber.Location = new System.Drawing.Point(198, 114);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "User Phone Number";
            this.txtPhoneNumber.Size = new System.Drawing.Size(296, 29);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateUser.Location = new System.Drawing.Point(250, 149);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(180, 53);
            this.btnCreateUser.TabIndex = 10;
            this.btnCreateUser.Text = "CREATE USER";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(516, 214);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnCreateUser;
    }
}