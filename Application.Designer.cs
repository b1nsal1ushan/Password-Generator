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
            this.components = new System.ComponentModel.Container();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.openPythonInterpreter = new System.Windows.Forms.OpenFileDialog();
            this.btnPythonInterpreter = new System.Windows.Forms.Button();
            this.btnOpenPswdGen = new System.Windows.Forms.Button();
            this.txtBoxPswGenPath = new System.Windows.Forms.TextBox();
            this.txtBoxPythonPath = new System.Windows.Forms.TextBox();
            this.openPythonGene = new System.Windows.Forms.OpenFileDialog();
            this.errorFile = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.errorSaveFile = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSaveFile)).BeginInit();
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
            // 
            // openPythonInterpreter
            // 
            this.openPythonInterpreter.FileName = "Python";
            this.openPythonInterpreter.Filter = "Python (*.exe)|*.exe";
            // 
            // btnPythonInterpreter
            // 
            this.btnPythonInterpreter.Location = new System.Drawing.Point(29, 415);
            this.btnPythonInterpreter.Name = "btnPythonInterpreter";
            this.btnPythonInterpreter.Size = new System.Drawing.Size(103, 23);
            this.btnPythonInterpreter.TabIndex = 2;
            this.btnPythonInterpreter.Text = "Open Python";
            this.btnPythonInterpreter.UseVisualStyleBackColor = true;
            this.btnPythonInterpreter.Click += new System.EventHandler(this.btnPythonInterpreter_Click);
            // 
            // btnOpenPswdGen
            // 
            this.btnOpenPswdGen.Location = new System.Drawing.Point(29, 386);
            this.btnOpenPswdGen.Name = "btnOpenPswdGen";
            this.btnOpenPswdGen.Size = new System.Drawing.Size(103, 23);
            this.btnOpenPswdGen.TabIndex = 3;
            this.btnOpenPswdGen.Text = "Open Generator";
            this.btnOpenPswdGen.UseVisualStyleBackColor = true;
            this.btnOpenPswdGen.Click += new System.EventHandler(this.btnOpenPswdGen_Click);
            // 
            // txtBoxPswGenPath
            // 
            this.txtBoxPswGenPath.Location = new System.Drawing.Point(174, 386);
            this.txtBoxPswGenPath.Name = "txtBoxPswGenPath";
            this.txtBoxPswGenPath.Size = new System.Drawing.Size(259, 20);
            this.txtBoxPswGenPath.TabIndex = 4;
            // 
            // txtBoxPythonPath
            // 
            this.txtBoxPythonPath.Location = new System.Drawing.Point(174, 417);
            this.txtBoxPythonPath.Name = "txtBoxPythonPath";
            this.txtBoxPythonPath.Size = new System.Drawing.Size(259, 20);
            this.txtBoxPythonPath.TabIndex = 5;
            // 
            // openPythonGene
            // 
            this.openPythonGene.FileName = "Password Generator";
            this.openPythonGene.Filter = "Password Generator (*.py)|*.py";
            // 
            // errorFile
            // 
            this.errorFile.ContainerControl = this;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(529, 417);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "Save Paths";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // errorSaveFile
            // 
            this.errorSaveFile.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.txtBoxPythonPath);
            this.Controls.Add(this.txtBoxPswGenPath);
            this.Controls.Add(this.btnOpenPswdGen);
            this.Controls.Add(this.btnPythonInterpreter);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.btnShowPass);
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.errorFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSaveFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.OpenFileDialog openPythonInterpreter;
        private System.Windows.Forms.Button btnPythonInterpreter;
        private System.Windows.Forms.Button btnOpenPswdGen;
        private System.Windows.Forms.TextBox txtBoxPswGenPath;
        private System.Windows.Forms.TextBox txtBoxPythonPath;
        private System.Windows.Forms.OpenFileDialog openPythonGene;
        private System.Windows.Forms.ErrorProvider errorFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.ErrorProvider errorSaveFile;
    }
}

