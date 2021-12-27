using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        string pythonInterpreter = "\"";
        string pythonProgram = "\"";

        private void ReadPaths()
        {
            if (File.Exists("Paths.config"))
            {
                using (StreamReader sr = new StreamReader("Paths.config"))
                {
                    pythonProgram = sr.ReadLine();
                    pythonInterpreter = sr.ReadLine();
                    txtBoxPswGenPath.Text = pythonProgram;
                    txtBoxPythonPath.Text = pythonInterpreter;
                }
            }                        
        }
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            try
            {
                errorFile.Clear();
                string password;
                StreamReader sr;
                ReadPaths();
                ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = pythonInterpreter, Arguments = pythonProgram, UseShellExecute = false, RedirectStandardOutput = true, CreateNoWindow = true };

                using (Process process = new Process() { StartInfo = startInfo, })
                {
                    process.Start();

                    sr = process.StandardOutput;
                    password = sr.ReadToEnd();

                    process.WaitForExit();
                }

                newPassword.Text = $"New password is {password}";
            }
            catch (Exception ex)
            {
                string error = null;
                if (txtBoxPswGenPath.Text == string.Empty || txtBoxPythonPath.Text == string.Empty)
                {
                    error = "Paths are empty.";
                    errorFile.SetError(newPassword, error);
                }
                else
                {
                    errorFile.SetError(newPassword, ex.Message);
                }               
            }
            return;
        }

        private void btnOpenPswdGen_Click(object sender, EventArgs e)
        {
            if (openPythonGene.ShowDialog() == DialogResult.OK)
            {
                pythonProgram = $"{pythonProgram}{openPythonGene.FileName}\"";
                txtBoxPswGenPath.Text = pythonProgram;
            }
        }

        private void btnPythonInterpreter_Click(object sender, EventArgs e)
        {
            if (openPythonInterpreter.ShowDialog() == DialogResult.OK)
            {
                pythonInterpreter = $"{pythonInterpreter}{openPythonInterpreter.FileName}\"";
                txtBoxPythonPath.Text = pythonInterpreter;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtBoxPythonPath.Text == String.Empty || txtBoxPswGenPath.Text == String.Empty)
                {
                    errorSaveFile.SetError(btnSaveFile, "Paths are empty.");
                }
                else
                {
                    using (StreamWriter writePaths = new StreamWriter("Paths.config"))
                    {
                        writePaths.WriteLine(txtBoxPswGenPath.Text);
                        writePaths.WriteLine(txtBoxPythonPath.Text);
                    }

                    var p = new PasswordGeneratorDesktop.popup();
                    p.ShowDialog();                                                           
                }
                
            }catch (Exception ex)
            {
                errorSaveFile.SetError(btnSaveFile, ex.Message);
            }
        }
    }
}
