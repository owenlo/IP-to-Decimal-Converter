using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace IpConverter
{
    public partial class Form1 : Form
    {

        double ip_decimal;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                double w = Convert.ToDouble(w_txtBox.Text);
                double x = Convert.ToDouble(x_txtBox.Text);
                double y = Convert.ToDouble(y_txtBox.Text);
                double z = Convert.ToDouble(z_txtBox.Text);
                ip_decimal = ((16777216 * w) + (65536 * x) + (256 * y) + z);
            }
            catch (Exception)
            { 
                MessageBox.Show("Something went wrong..."); 
            }

            txtBox_Decimal.Text = ip_decimal.ToString();            
            test_Btn.Enabled = true;
        }

        private void test_Btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://"+ip_decimal);
            
        }

        private static string GetDefaultBrowserPath()
        {
            string key = @"htmlfile\shell\open\command";
            RegistryKey registryKey =
            Registry.ClassesRoot.OpenSubKey(key, false);            
            return ((string)registryKey.GetValue(null, null)).Split('"')[1];
        }

        
    }
}
