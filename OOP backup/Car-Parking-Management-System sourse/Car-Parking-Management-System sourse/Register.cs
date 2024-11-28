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
    public partial class Register : Form
    {
        List<Customer> customerList;
        public Register(List<Customer> customerList)
        {
            InitializeComponent();
            this.customerList = customerList;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < customerList.Count; i++)
            {
                this.customerList[i].Username = txtUserRegister.Text;
                MessageBox.Show("Username is Exist!", "System");
                return;
            }
            if(txtFirstName.Text==null || txtLastName.Text==null || txtAge.Text==null || txtPhoneNumber.Text==null || txtUserRegister.Text==null || txtPassRegister.Text == null)
            {
                MessageBox.Show("Don't let any information is Empty", "System");
                return;
            }
            int count = 0;
            string temp;
            using (StreamReader idcount = new StreamReader("Customer.txt"))
            {
                temp= idcount.ReadLine();
                if (temp != null)
                {
                    count = Convert.ToInt32(temp);
                }
            }
            count++;
            Customer newCustomer= new Customer($"{count}", txtFirstName.Text, txtLastName.Text, Convert.ToInt32(txtAge.Text), txtPhoneNumber.Text, txtUserRegister.Text, txtPassRegister.Text, "no","no request","no",0);
            newCustomer.WriteInfo(temp);
            string[] lines = File.ReadAllLines("Customer.txt");
            lines[0] = $"{count}";
            File.WriteAllLines("Customer.txt", lines);
            MessageBox.Show("Create successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            this.Close();
        }
    }
}
