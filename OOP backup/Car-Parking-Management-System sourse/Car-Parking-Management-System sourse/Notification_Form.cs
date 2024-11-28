using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Notification_Form : Form
    {
        public Notification_Form(string id)
        {
            InitializeComponent();
            string filepath = $"{id}_deny.txt";
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    richTextBoxNotification.Text = sr.ReadToEnd();
                }
            }
            catch
            {
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
