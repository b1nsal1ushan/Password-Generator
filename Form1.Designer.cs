namespace PasswordManagerDesktop
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
            this.btnShowPass = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowPass
            // 
            this.btnShowPass.Location = new System.Drawing.Point(36, 104);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(96, 39);
            this.btnShowPass.TabIndex = 0;
            this.btnShowPass.Text = "Generate Password";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(174, 114);
            this.newPassword.Name = "newPassword";
            this.newPassword.ReadOnly = true;
            this.newPassword.Size = new System.Drawing.Size(259, 20);
            this.newPassword.TabIndex = 1;
            this.newPassword.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.btnShowPass);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.TextBox newPassword;
    }
}

