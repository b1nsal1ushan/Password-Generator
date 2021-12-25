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

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            var pythonInterpreter = ""; //include path
            var pythonPasswordGenerator = "PasswordGenerator.py"; 
            string password;
            StreamReader sr;

            ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = pythonInterpreter, Arguments = pythonPasswordGenerator, UseShellExecute = false, RedirectStandardOutput = true, CreateNoWindow = true};

            using (Process process = new Process() { StartInfo = startInfo,})
            {
                process.Start();

                sr = process.StandardOutput;
                password = sr.ReadToEnd();

                process.WaitForExit();
            }
            
            newPassword.Text = $"New password is {password}";            
            newPassword.Visible = true;
        }
    }
}
