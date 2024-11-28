using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Manager_Form : Form
    {
        List<dynamic> combineDataChat;
        private List<ParkingSpace> parking;
        private List<Customer> customers;
        public Manager_Form(List<ParkingSpace> parking, List<Customer> customers)
        {
            InitializeComponent();
            this.parking = parking;
            dataGridViewShowParkingSpace.DataSource = null;
            dataGridViewShowParkingSpace.DataSource = parking;
            this.customers = customers;
            combineDataChat = customers.Where(customer => customer.RequestMessorChangPass == "Request Message Manager").Select(customer => new
            {
                customer.Id,
                customer.Fullname,
                customer.Ticketseri,
                customer.Age,
                customer.Phonenumber,
                customer.Wallet
            }
            ).Cast<dynamic>().ToList();
            dataGridViewChatfromManager.DataSource = combineDataChat;
        }
        public void writeData()
        {
            using (StreamWriter sw = new StreamWriter  ("ParkingSpace.txt"))
            {
                for (int i = 0; i < parking.Count; i++)
                {
                    sw.WriteLine(parking[i].Id_carparking);
                    sw.WriteLine(parking[i].Numberplate);
                    sw.WriteLine(parking[i].Name_car);
                    sw.WriteLine(parking[i].Status);
                    sw.WriteLine(parking[i].Cost);
                    sw.WriteLine(parking[i].Ticketseri);
                }
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == -1)
            {
                MessageBox.Show("Please! Choose Type");
                return;
            }
            if (comboBoxType.SelectedIndex == 0)
            {
                for (int i = 0; i < this.parking.Count; i++)
                {
                    if (this.parking[i].Id_carparking == $"COM{txtIDParkingSpaceManager.Text}")
                    {
                        MessageBox.Show($"COM{txtIDParkingSpaceManager.Text} is exist!", "System");
                        return;
                    }
                }
                this.parking.Add(new ParkingSpace($"COM{txtIDParkingSpaceManager.Text}", "", "", "Empty", $"{txtCost.Text}$/time",""));
            }
            else
            {
                for (int i = 0; i < this.parking.Count; i++)
                {
                    if (this.parking[i].Id_carparking == $"VIP{txtIDParkingSpaceManager.Text}")
                    {
                        MessageBox.Show($"VIP{txtIDParkingSpaceManager.Text} is exist!", "System");
                        return;
                    }
                }
                this.parking.Add(new ParkingSpace($"VIP{txtIDParkingSpaceManager.Text}", "", "", "Empty", $"{txtCost.Text}$/time",""));
            }
            writeData();
            dataGridViewShowParkingSpace.DataSource = null;
            dataGridViewShowParkingSpace.DataSource = this.parking;
            MessageBox.Show("Create parking space success!","System");
        }
        
        private void btnLogoutManager_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out???", "System", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login form = new Login();
                form.ShowDialog();
                this.Close();
            }
        }
        private void txtSearchManager_TextChanged(object sender, EventArgs e)
        {
            
            //Câu lệnh này dùng linq để lọc danh sách theo thứ mình nhập vào where là câu lệnh lọc danh sách có ĐK trong nó p là tham chiếu tới đối tượng trong list nếu đối tượng nào có txtSearcManafer thì sẽ dược xuất thành Lít và xuất ra datagridview
            dataGridViewShowParkingSpace.DataSource = this.parking.Where(p => p.Id_carparking.Contains(txtSearchManager.Text)).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int count=this.parking.Count;
            this.parking.RemoveAll(p => p.Id_carparking.Contains(txtSearchManager.Text));
            writeData();
            if (count != this.parking.Count)
            {
                dataGridViewShowParkingSpace.DataSource = this.parking;
                MessageBox.Show("Delete complete!", "System");
            }
            else
            {
                MessageBox.Show($"{txtSearchManager.Text} is not exist!","System");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(comboBoxEmptyorHired.SelectedIndex == -1)
            {
                MessageBox.Show("Please! Choose Status", "System");
            }
            else if (txtIDInforParkingManager.Text == null)
            {
                MessageBox.Show("Please! Enter ID", "System");
            }
            else if (txtCostInforManager == null)
            {
                MessageBox.Show("Please! Enter Cost", "System");
            }
            else
            {
                for (int i = 0; i < this.parking.Count; i++)
                {
                    if (this.parking[i].Id_carparking == txtIDInforParkingManager.Text && comboBoxEmptyorHired.SelectedIndex == 0)
                    {
                        this.parking[i].changeInfo(txtIDInforParkingManager.Text, txtNumberplateInforManager.Text, txtNameInforParkingManager.Text, "Empty", $"{txtCostInforManager.Text}$/month");
                        break;
                    }
                    if (this.parking[i].Id_carparking == txtIDInforParkingManager.Text && comboBoxEmptyorHired.SelectedIndex == 1)
                    {
                        this.parking[i].changeInfo(txtIDInforParkingManager.Text, txtNumberplateInforManager.Text, txtNameInforParkingManager.Text, "Hired", $"{txtCostInforManager.Text}$/month");
                        break;
                    }
                }
                writeData();
                dataGridViewShowParkingSpace.DataSource = null;
                dataGridViewShowParkingSpace.DataSource = this.parking;
                MessageBox.Show("Edit complete!", "System");
            }           
        }

        private void start_chat_Click(object sender, EventArgs e)
        {
            
            if (search_id_customer_for_chat.Text == null)
            {
                MessageBox.Show("Plesae enter customer id!", "Message Box Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < dataGridViewChatfromManager.Rows.Count; i++)
                {
                    if (dataGridViewChatfromManager.Rows[i].Cells["Id"].Value.ToString() == search_id_customer_for_chat.Text)
                    {
                        var newdata = combineDataChat.Where(c => c.Id != search_id_customer_for_chat.Text).ToList();
                        for (int j = 0; j < customers.Count; j++)
                        {
                            if (customers[j].Id == search_id_customer_for_chat.Text)
                            {
                                customers[j].RequestMessorChangPass = "no";
                                combineDataChat = newdata;
                                dataGridViewChatfromManager.DataSource = null;
                                dataGridViewChatfromManager.DataSource = combineDataChat;
                                Messenger Form = new Messenger(customers[j].Id, "MA001", customers[j].Fullname,customers);
                                Form.ShowDialog();
                                return;
                            }
                        }
                    }
                }
                MessageBox.Show("Incorrect information", "Message Box Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else
            //{
            //    for (int i = 0; i < customers.Count; i++)
            //    {
            //        if (customers[i].Id == search_id_customer_for_chat.Text)
            //        {
            //            Messenger Form = new Messenger(customers[i].Id, "MA001", customers[i].Fullname);
            //            Form.ShowDialog();
            //            return;
            //        }
            //    }
            //    MessageBox.Show("Incorrect information", "Message Box Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

    }
}
