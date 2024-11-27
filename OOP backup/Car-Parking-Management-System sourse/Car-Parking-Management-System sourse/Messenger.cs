using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Car_Parking_Management_System_sourse
{
    public partial class Messenger : Form
    {
        private string filePath;
        private string id_customer;
        private string id_attendant;
        bool flag;
        List<Customer> customerList;
        public Messenger(string id_customer, string id_attendant, bool flag, List<Customer> customerList,string name)
        {
            InitializeComponent();
            filePath = $"{id_customer}_{id_attendant}.txt";
            this.flag = flag;
            this.id_attendant = id_attendant;
            this.id_customer = id_customer;
            name_user.Text = name;
            LoadMessages();
            this.customerList = customerList;

        }

        private void LoadMessages()
        {
            flowLayoutPanelMessages.Controls.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    //bool is_attendant = line.Contains("id:" + id_attendant);
                    AddMessageToPanel(line, flag);
                }
            }
        }

        private void AddMessageToPanel(string message, bool flag)
        {

            Panel messagePanel = new Panel
            {
                AutoSize = true,
                Padding = new Padding(10),
                Margin = new Padding(5),
                BackColor = flag ? Color.LightGreen : Color.LightBlue,
            };

            Label messageLabel = new Label
            {
                Text = message,
                AutoSize = true,
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
            };

            messagePanel.Controls.Add(messageLabel);

            flowLayoutPanelMessages.Controls.Add(messagePanel);
        }



        private void send_message_Click(object sender, EventArgs e)
        {
            string message = text_input.Text.Trim();

            for (int i = 0;i<customerList.Count;i++)
            {
                if (customerList[i].Id == id_customer)
                {
                    if (!string.IsNullOrEmpty(message))
                    {
                        string senderId = flag ? id_attendant : id_customer;
                        string formattedMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {customerList[i].Fullname}: {message}";
                        File.AppendAllText(filePath, formattedMessage + Environment.NewLine);

                        AddMessageToPanel(formattedMessage, flag);

                        text_input.Clear();
                    }
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Messenger form = new Messenger(id_customer,id_attendant,flag);
            //form.ShowDialog();
            //this.Close();
            flowLayoutPanelMessages.Controls.Clear();
        }


    }
}
