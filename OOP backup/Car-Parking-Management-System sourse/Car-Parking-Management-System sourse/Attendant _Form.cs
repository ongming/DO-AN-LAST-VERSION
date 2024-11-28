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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Car_Parking_Management_System_sourse
{
    public partial class Attendant__Form : Form
    {
        List<Customer> customers;
        List<ParkingSpace> parkingSpaces;
        List<dynamic> combineDataParking;
        List<dynamic> combineDataReceive;
        List<dynamic> combineDataChat;
        string filepath;
        string id;

        public Attendant__Form(string name,string id, List<Customer> customers, List<ParkingSpace> parkingSpaces)
        {
            this.id = id;
            this.filepath = "daily_report.txt";
            InitializeComponent();
            lbname.Text = name;
            this.customers = customers;
            this.parkingSpaces = parkingSpaces;
            combineDataParking = customers.Where(customer => customer.Request.Contains("Request Parking")).Join(parkingSpaces,
                                                                                customer => customer.Request.Substring(25),
                                                                                parkingspace => parkingspace.Id_carparking,
                                                                                (customer, parkingspace) =>
                                                                                new {
                                                                                    customer.Id,
                                                                                    customer.Fullname,
                                                                                    parkingspace.Name_car,
                                                                                    parkingspace.Numberplate,
                                                                                    customer.Request
                                                                                }
                                                                                ).Cast<dynamic>().ToList();
            //lệnh này giúp cho các cột tự động đièu chỉnh độ rộng sao cho hiển thị toàn bộ nội dung của từng cột
            dataGridViewParkingCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            combineDataReceive = customers.Where(customer => customer.Request == "Request Receive Car").Join(parkingSpaces,
                                                                                customer => customer.Ticketseri,
                                                                                parkingspace => parkingspace.Ticketseri,
                                                                                (customer, parkingspace) =>
                                                                                new {
                                                                                    customer.Id,
                                                                                    customer.Ticketseri,
                                                                                    parkingspace.Id_carparking,
                                                                                    customer.Fullname,
                                                                                    parkingspace.Name_car,
                                                                                    parkingspace.Numberplate,
                                                                                    customer.Request
                                                                                }
                                                                                ).Cast<dynamic>().ToList();
            combineDataChat = customers.Where(customer => customer.RequestMessorChangPass=="Request Message").Select(customer => new
            {
                customer.Id,
                customer.Fullname,
                customer.Ticketseri,
                customer.Age,
                customer.Phonenumber,
                customer.Wallet
            }
            ).Cast<dynamic>().ToList();

            dataGidviewChat.DataSource = combineDataChat;
            for (int i = 0; i < dataGidviewChat.Columns.Count; i++)
            {
                dataGidviewChat.Columns[i].DisplayIndex = dataGidviewChat.Columns.Count - 1 - i;
            }
            //dataGidviewChat.Columns[8].Visible = false;
            dataGridViewReceiveCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewParkingCar.DataSource = combineDataParking;
            dataGridViewReceiveCar.DataSource = combineDataReceive;
        }
        public void showData(List<Customer> customers,List<ParkingSpace> parkingspaces)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewParkingCar.Rows.Count; i++)
            {
                // câu đièu kiện bên dưới để kiểm tra coi ID nhập vào có trong gridview ko
                if (dataGridViewParkingCar.Rows[i].Cells["Id"].Value.ToString() == txtIDCustomer.Text)
                {
                    var newdata=combineDataParking.Where(c=>c.Id!=txtIDCustomer.Text).ToList();
                    for (int j = 0; j < customers.Count; j++)
                    {
                        //vòng for dùng để lọc xem thử coi mã ID có trùng không
                        for(int k = 0; k < customers.Count; k++)
                        {
                            if (customers[k].Ticketseri == $"QMTL{txtTicketseri.Text}")
                            {
                                MessageBox.Show("Ticket Seri is exist Please choose other", "System");
                                return;
                            }
                        }
                        //vòng for dùng để tìm đúng ID người dung để có thể thay đổi thông tin ticketseri và request
                        if (customers[j].Id == txtIDCustomer.Text)
                        {
                            //vòng for dùng để tìm ID có cần gắn với mỗi Customer để gán ticketseri
                            for (int n = 0; n < parkingSpaces.Count; n++)
                            {
                                if (parkingSpaces[n].Id_carparking == customers[j].Request.Substring(25))
                                {
                                    string formattedMessage = $"in:[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]+{parkingSpaces[n].ToString()} from{id} ";
                                    File.AppendAllText(filepath, formattedMessage + Environment.NewLine);
                                    parkingSpaces[n].Status = "Hired";
                                    parkingSpaces[n].Ticketseri = $"QMTL{txtTicketseri.Text}";
                                    ParkingSpace.writeparkingdata(parkingSpaces);
                                    break;
                                }
                            }
                            customers[j].Ticketseri = $"QMTL{txtTicketseri.Text}";
                            customers[j].changeInfo("no request");
                            break;
                        }
                    }
                    combineDataParking = newdata;
                    dataGridViewParkingCar.DataSource = null;
                    dataGridViewParkingCar.DataSource = combineDataParking;
                    Customer.WriteCustomerList(customers);
                    MessageBox.Show("Accept Complete GOOD JOB!", "System");
                    return;
                }
            }
            MessageBox.Show("Id of Customer is not exist!", "System");
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numberseri=random.Next(1000, 9999);
            txtTicketseri.Text = numberseri.ToString();
        }

        private void btnAcceptReceive_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridViewReceiveCar.Rows.Count; i++)
            {
                if (dataGridViewReceiveCar.Rows[i].Cells["Id"].Value.ToString() == txtIDofCustomerReceive.Text)
                {
                    var newdata = combineDataReceive.Where(c => c.Id != txtIDofCustomerReceive.Text).ToList();
                    for (int j = 0; j < customers.Count; j++)
                    {
                        if (customers[j].Id == txtIDofCustomerReceive.Text)
                        {
                            for (int k = 0; k < parkingSpaces.Count; k++)
                            {
                                if (parkingSpaces[k].Ticketseri == customers[j].Ticketseri)
                                {
                                    string formattedMessage = $"out:[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]+{parkingSpaces[k].ToString()} from{id}";
                                    File.AppendAllText(filepath, formattedMessage + Environment.NewLine);
                                    parkingSpaces[k].changeInfo("", "", "Empty", "");
                                    ParkingSpace.writeparkingdata(parkingSpaces);
                                    break;
                                }
                            }
                            customers[j].Ticketseri = "no";
                            customers[j].changeInfo("no request");
                            break;
                        }
                    }
                    combineDataReceive = newdata;
                    dataGridViewReceiveCar.DataSource = null;
                    dataGridViewReceiveCar.DataSource = combineDataReceive;
                    Customer.WriteCustomerList(customers);
                    MessageBox.Show("Accept Complete GOOD JOB!", "System");
                    return;
                }
            }
            MessageBox.Show("Id of Customer is not exist!", "System");
        }

        private void btnDenyReceive_Click(object sender, EventArgs e)
        {

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            string filepath = $"{txtIDDenyParking.Text}_deny.txt";
            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                sw.WriteLine(txtReasonDenyParking.Text);
                
            }
            for (int i = 0; i < customers.Count; i++)
            {
                if (txtIDDenyParking.Text == customers[i].Id)
                {
                    var newdata = combineDataParking.Where(c => c.Id != txtIDDenyParking.Text).ToList();
                    for (int n = 0; n < parkingSpaces.Count; n++)
                    {
                        if (parkingSpaces[n].Id_carparking == customers[i].Request.Substring(25))
                        {
                            parkingSpaces[n].Status = "Empty";
                            parkingSpaces[n].Ticketseri = "";
                            parkingSpaces[n].Numberplate = "";
                            parkingSpaces[n].Name_car = "";
                            ParkingSpace.writeparkingdata(parkingSpaces);
                            break;
                        }
                    }
                    customers[i].changeInfo("no request");
                    combineDataParking = newdata;
                    break;
                }
            }        
            dataGridViewParkingCar.DataSource = null;
            dataGridViewParkingCar.DataSource = combineDataParking;
            Customer.WriteCustomerList(this.customers);
            MessageBox.Show("Deny Complete GOOD JOB!", "System");
            return;
        }
    }
}
