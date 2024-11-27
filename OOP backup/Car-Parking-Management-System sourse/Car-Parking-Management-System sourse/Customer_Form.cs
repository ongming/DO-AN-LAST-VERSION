using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Car_Parking_Management_System_sourse
{
    public partial class Customer_Form : Form
    {
        List<Customer> customers;
        List<ParkingSpace> parkingSpaces;
        string id;
        string name;
        public Customer_Form(string name,string id,List<ParkingSpace> parking,List<Customer> customers)
        {
            this.parkingSpaces = parking;
            this.customers = customers;
            this.id = id;
            this.name = name;
            InitializeComponent();
            lbname.Text = name;
            // Tắt tự động tạo cột
            dataGridviewParkingSpace.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id_carparking"; // Liên kết với thuộc tính Id_carparking
            idColumn.HeaderText = "ID"; // Tiêu đề cột
            dataGridviewParkingSpace.Columns.Add(idColumn);

            // Tạo cột cho Status
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.DataPropertyName = "Status"; // Liên kết với thuộc tính Status
            statusColumn.HeaderText = "Status"; // Tiêu đề cột
            dataGridviewParkingSpace.Columns.Add(statusColumn);

            DataGridViewTextBoxColumn costColumn = new DataGridViewTextBoxColumn();
            costColumn.DataPropertyName = "Cost";
            costColumn.HeaderText = "Cost";
            dataGridviewParkingSpace.Columns.Add(costColumn);

            dataGridviewParkingSpace.RowHeadersVisible = false;
            dataGridviewParkingSpace.DataSource = parking;
        }
        public void writeData()
        {
            ParkingSpace.writeparkingdata(this.parkingSpaces);
            string count;
            using (StreamReader sr=new StreamReader("Customer.txt"))
            {
                count=sr.ReadLine();
            }
            using (StreamWriter swriter = new StreamWriter("Customer.txt"))
            {
                swriter.WriteLine(count);
                swriter.Flush();
            }
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].WriteInfo();
            }

        }
        private void btnSignOut_Click(object sender, EventArgs e)
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
        private void btnSignParking_Click(object sender, EventArgs e)
        {
            for(int i=0;i<parkingSpaces.Count;i++)
            {
                if (txtIDSpace.Text == parkingSpaces[i].Id_carparking && (parkingSpaces[i].Status == "Hired" || parkingSpaces[i].Status == "Wait..."))
                {
                    MessageBox.Show("This Parking Space is selected!", "System");
                    return;
                }
            }
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    for(int j = 0; j < parkingSpaces.Count; j++)
                    {
                        if (txtIDSpace.Text == parkingSpaces[j].Id_carparking)
                        {
                            parkingSpaces[j].changeInfo(txtNameCar.Text,txtNumberPlate.Text,"Wait...","Wait...");
                            customers[i].changeInfo($"Request Parking Space ID:{txtIDSpace.Text}");
                            MessageBox.Show("Please! Wait our Attendant reply your Request\nThanks for using my service", "System");
                            dataGridviewParkingSpace.DataSource = null;
                            dataGridviewParkingSpace.DataSource = parkingSpaces;
                            writeData();
                            return;
                        }
                    }                   
                    MessageBox.Show("ID of Parking Space is not exist!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;     
                }
            }
        }
        private void txtSearchSpace_TextChanged(object sender, EventArgs e)
        {
            dataGridviewParkingSpace.DataSource = this.parkingSpaces.Where(p => p.Id_carparking.Contains(txtSearchSpace.Text)).ToList();
        }

        private void btnShowInfor_Click(object sender, EventArgs e)
        {
            for(int  i=0;i<customers.Count;i++)
            {
                if (customers[i].Id == id)
                {
                    for (int j = 0; j < parkingSpaces.Count; j++)
                    {
                        if (parkingSpaces[j].Ticketseri == customers[i].Ticketseri)
                        {
                            this.Hide();
                            Customer_Infor newInfor = new Customer_Infor(id, customers, parkingSpaces[j].Id_carparking,parkingSpaces);
                            this.Close();
                            newInfor.ShowDialog();

                            return;
                        }
                    }
                    this.Hide();
                    Customer_Infor newInfor1 = new Customer_Infor(id,customers, "no",parkingSpaces);
                    this.Close();
                    newInfor1.ShowDialog();

                    return;
                }         
            }
           
        }

        private void btnReceiveCar_Click(object sender, EventArgs e)
        {
            for(int i=0;i<customers.Count;i++)
            {
                if (customers[i].Ticketseri==txtTicketseriReceiveCar.Text && customers[i].Password==txtPassReceiveCar.Text)
                {
                    customers[i].changeInfo("Request Receive Car");
                    Customer.WriteCustomerList(this.customers);
                    MessageBox.Show("Please! Wait our Attendant reply your Request\nThanks for using my service", "System");
                    return;
                }
            }
            if(txtPassReceiveCar.Text!=null && txtTicketseriReceiveCar.Text != null)
            {
                MessageBox.Show("TicketSeri and Password of you is not Match","System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            Chat_Select newform= new Chat_Select(this.id,customers);
            newform.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            lbname.Text = name;
        }
    }
}
