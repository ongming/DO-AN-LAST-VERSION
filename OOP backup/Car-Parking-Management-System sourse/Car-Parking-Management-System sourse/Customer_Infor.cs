using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Customer_Infor : Form
    {
        public bool flag = false;
        public string name;
        string id;
        string IDParkingspace;
        List<Customer> newCustomer;
        List<ParkingSpace> newparkingspace;
        public Customer_Infor(string id, List<Customer> newCustomer,string IDParkingspace,List<ParkingSpace> parkingSpaces)
        {
            InitializeComponent();
            this.id = id;
            this.newCustomer = newCustomer;
            this.IDParkingspace = IDParkingspace;
            this.newparkingspace = parkingSpaces;
            for (int i = 0; i < newCustomer.Count; i++)
            {
                if (newCustomer[i].Id == id)
                {
                    txtfirstname.Text = newCustomer[i].Firstname;
                    txtlastname.Text = newCustomer[i].Lastname;
                    txtAge.Text = newCustomer[i].Age.ToString();
                    txtPhonenumber.Text = newCustomer[i].Phonenumber;
                    txtidCustomer.Text = newCustomer[i].Id;
                    txtTicketSeri.Text = newCustomer[i].Ticketseri;
                    txtIDParkingSpace.Text = IDParkingspace;
                    txtWallet.Text = $"{newCustomer[i].Wallet}$";
                    txtUsername.Text = newCustomer[i].Username;
                    txtPassword.Text = newCustomer[i].Password;
                }
            }
            
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Hide();
                Login form = new Login();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                for (int i = 0;i < newCustomer.Count;i++)
                {
                    if (newCustomer[i].Id == id)
                    {
                        this.Hide();
                        Customer_Form newform = new Customer_Form(newCustomer[i].Fullname,newCustomer[i].Id, newparkingspace,newCustomer);
                        newform.ShowDialog();
                        this.Close();
                    }
                }
                
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < newCustomer.Count; i++)
            {
                if (newCustomer[i].Id == id)
                {
                    newCustomer[i].changeInfo(txtfirstname.Text, txtlastname.Text, Convert.ToInt32(txtAge.Text), txtPhonenumber.Text, txtUsername.Text, txtPassword.Text);
                }
            }
            Customer.WriteCustomerList(newCustomer);
            flag = true;
        }
    }
}
