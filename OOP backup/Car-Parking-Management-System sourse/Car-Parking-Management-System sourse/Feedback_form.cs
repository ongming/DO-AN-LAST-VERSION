using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Feedback_form : Form
    {
        string name;
        string id;
        public Feedback_form(string name, string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string feedbacktext = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] id: {id} - {name}:" + txtfeedback.Text;
                using (StreamWriter sw = new StreamWriter("Feedback.txt", true))
                {
                    sw.WriteLine(feedbacktext);
                    sw.WriteLine("Rating: 5 Stars");
                }
            }
            if (radioButton2.Checked)
            {
                string feedbacktext = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] id: {id} - {name}:" + txtfeedback.Text;
                using (StreamWriter sw = new StreamWriter("Feedback.txt", true))
                {
                    sw.WriteLine(feedbacktext);
                    sw.WriteLine("Rating: 4 Stars");
                }
            }
            if(radioButton3.Checked)
            {
                string feedbacktext = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] id: {id} - {name}:" + txtfeedback.Text;
                using (StreamWriter sw = new StreamWriter("Feedback.txt", true))
                {
                    sw.WriteLine(feedbacktext);
                    sw.WriteLine("Rating: 3 Stars");
                }
            }
            if (radioButton4.Checked)
            {
                string feedbacktext = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] id: {id} - {name}:" + txtfeedback.Text;
                using (StreamWriter sw = new StreamWriter("Feedback.txt", true))
                {
                    sw.WriteLine(feedbacktext);
                    sw.WriteLine("Rating: 2 Stars");
                }
            }
            if (radioButton5.Checked)
            {
                string feedbacktext = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] id: {id} - {name}:" + txtfeedback.Text;
                using (StreamWriter sw = new StreamWriter("Feedback.txt", true))
                {
                    sw.WriteLine(feedbacktext);
                    sw.WriteLine("Rating: 1 Stars");
                }
            }
            this.Close();
        }
    }
}
