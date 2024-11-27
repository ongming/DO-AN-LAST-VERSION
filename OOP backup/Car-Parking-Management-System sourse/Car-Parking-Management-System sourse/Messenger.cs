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
        string name_customer;
        string name_attendant;
        bool flag;
        public Messenger(string id_customer, string id_attendant, string name_customer)
        {
            InitializeComponent();
            filePath = $"{id_customer}_{id_attendant}.txt";
            this.id_attendant = id_attendant;
            this.id_customer = id_customer;
            this.name_customer = name_customer;
            name_user.Text = name_customer;
            flag = true;
            LoadMessages();
        }
        public Messenger(string id_customer, string id_attendant, string name_customer,string name_attendant)
        {
            InitializeComponent();
            filePath = $"{id_customer}_{id_attendant}.txt";
            this.id_attendant = id_attendant;
            this.id_customer = id_customer;
            this.name_customer = name_customer;
            this.name_attendant = name_attendant;
            name_user.Text = name_attendant;
            flag = false;
            LoadMessages();
        }

        private void LoadMessages()
        {

            flowLayoutPanelMessages.Controls.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                int linesToProcess = 4;
                int startIndex = Math.Max(0, lines.Length - linesToProcess);

                for (int i = startIndex; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        line = lines[i + 1];
                        i = i + 1;
                    }
                    bool is_attendant = line.Contains(id_attendant);
                    AddMessageToPanel(EditMessage(line), is_attendant);
                }

            }
        }

        private void AddMessageToPanel(string message, bool is_attendant)
        {

            Panel messagePanel = new Panel
            {
                AutoSize = true,
                Padding = new Padding(10),
                Margin = new Padding(5),
            };

            // Tạo Label hiển thị tin nhắn
            Label messageLabel = new Label
            {
                Text = message,
                AutoSize = true,
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
            };

            messagePanel.Controls.Add(messageLabel);


            if (flag)
            {
                messagePanel.BackColor = is_attendant ? Color.LightBlue : Color.LightGreen;
                messagePanel.Margin = is_attendant ? new Padding(150, 5, 5, 5) : new Padding(5, 5, 150, 5);
            }
            else
            {
                messagePanel.BackColor = is_attendant ? Color.LightGreen : Color.LightBlue;
                messagePanel.Margin = is_attendant ? new Padding(5, 5, 150, 5) : new Padding(150, 5, 5, 5);
            }

            flowLayoutPanelMessages.Controls.Add(messagePanel);
        }
        private string EditMessage(string input)
        {
            string firstPart = input.Substring(0, Math.Min(21, input.Length)).Trim();

            string secondPart = input.Length > 21 ? input.Substring(21).Trim() : string.Empty;
            int count = 0;
            for (int i = 0; i < secondPart.Length; i++)
            {
                count += 1;
                if (count >= 28)
                {
                    if (secondPart[i].ToString() == " " || count == 33)
                    {
                        secondPart = secondPart.Substring(0, i) + '\n' + secondPart.Substring(i + 1);
                        count = 0;
                    }
                }
            }
            return $"{firstPart}\n{secondPart}";
        }



        private void send_message_Click(object sender, EventArgs e)
        {
            string message = text_input.Text.Replace("\r", "").Replace("\n", "");

            if (!string.IsNullOrEmpty(message))
            {
                string senderId = flag ? id_attendant : name_customer;
                string formattedMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {senderId}: {message}";

                File.AppendAllText(filePath, formattedMessage + Environment.NewLine);

                AddMessageToPanel(EditMessage(formattedMessage), flag);

                text_input.Clear();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            LoadMessages();
        }


    }
}
