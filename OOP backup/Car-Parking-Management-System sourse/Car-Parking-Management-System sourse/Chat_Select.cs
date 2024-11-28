using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Chat_Select : Form
    {
        List<Customer> customers;

        string id;
        string name;
        public Chat_Select(string id, List<Customer> customers)
        {
            InitializeComponent();
            this.id = id;
            this.customers = customers;
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    this.name = customers[i].Fullname;
                    break;
                }
            }
        }

        private void btnSelectTanLe_Click(object sender, EventArgs e)
        {
            Messenger form = new Messenger(id, "AT002", name, "Tan Le",customers);
            this.Close();
            form.ShowDialog();
        }

        private void btnSelectQuangMinh_Click(object sender, EventArgs e)
        {
            Messenger form = new Messenger(id, "MA001", name, "Quang Minh",customers);
            this.Close();
            form.ShowDialog();
        }

        private void btnSelectLamNguyen_Click(object sender, EventArgs e)
        {
            Messenger form = new Messenger(id, "AT001", name, "Lam Nguyen",customers);
            this.Close();
            form.ShowDialog();
        }
    }
}
