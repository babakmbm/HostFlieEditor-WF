using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostFlieEditor_WF
{
    public partial class Form1 : Form
    {
        public string path = @"C:\Windows\System32\drivers\etc\hosts";
        public string[] lines;
        bool Exist = true;
        public Form1()
        {
            InitializeComponent();
            
            if (!File.Exists(path))
            {
                OutputBox.Text = "File Missing! \n";
                OutputBox.ForeColor = System.Drawing.Color.Red;
                Exist = false;
            }
            else
            {
                OutputBox.ForeColor = System.Drawing.Color.Black;
                lines = File.ReadAllLines(path);
                using (StreamReader sr = new StreamReader(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        OutputBox.AppendText("\n" + s + "\n");
                    }
                    sr.Close();
                }

            }
        }


        private void ShowTextButton_Click(object sender, EventArgs e)
        {
            if (Exist)
            {
                
            }
            else
            {
                OutputBox.Text = "File does not exist!!!";
            }
        }

        private void UrlBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddUrlButton_Click(object sender, EventArgs e)
        {
            if (UrlBox.Text != "")
            {
                System.Net.IPAddress[] addresses = System.Net.Dns.GetHostAddresses(UrlBox.Text);
                string url = "\n" + addresses[1] + " " + UrlBox.Text + "\n";
                OutputBox.AppendText(url);
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(url);
                    sr.Close();
                }
            }
            else
            {
                OutputBox.AppendText("\n" + "Please enter a url to block" + "\n");
            }
            
        }
    }
}
