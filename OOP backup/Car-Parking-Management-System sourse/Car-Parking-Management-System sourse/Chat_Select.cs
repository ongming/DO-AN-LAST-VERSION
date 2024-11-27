using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking_Management_System_sourse
{
    public partial class Chat_Select : Form
    {
        List<Customer> customers;

        string id;
        public Chat_Select(string id, List<Customer> customers)
        {
            InitializeComponent();
            this.id = id;
            this.customers = customers;
        }

        private void btnSelectTanLe_Click(object sender, EventArgs e)
        {
            Messenger form = new Messenger(id, "Tan Le", false,customers, "Tan Le");
            this.Close();
            form.ShowDialog();
        }

        private void btnSelectQuangMinh_Click(object sender, EventArgs e)
        {
            Messenger form = new Messenger(id, "Quang Minh", false,customers, "Quang Minh");
            this.Close();
            form.ShowDialog();
        }

        private void btnSelectLamNguyen_Click(object sender, EventArgs e)
        {
            Messenger form = new Messenger(id, "Lam Nguyen", false,customers, "Lam Nguyen");
            this.Close();
            form.ShowDialog();
        }
    }
}
