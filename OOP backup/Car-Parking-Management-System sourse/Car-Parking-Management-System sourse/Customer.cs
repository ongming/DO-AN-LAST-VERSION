using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Car_Parking_Management_System_sourse
{
    public class Customer : Person, CarParkingSpaceSystem
    {
        private string ticketseri;
        private string request;
        private int wallet;
        private string requestMessorChangPass;
        public Customer(string id, string firstname, string lastname, int age, string phonenumber, string username, string password, string ticketseri, string requestMessage, string requestMessorChangPass, int wallet) : base(id, firstname, lastname, age, phonenumber, username, password)
        {
            this.ticketseri = ticketseri;
            this.request = requestMessage;
            this.requestMessorChangPass = requestMessorChangPass;
            this.wallet = wallet;
        }
        public string Ticketseri { get { return ticketseri; } set { ticketseri = value; } }
        public string Fullname { get { return $"{Lastname} {Firstname} "; } }
        public string Request { get { return request; } set { request = value; } }
        public string RequestMessorChangPass { get { return requestMessorChangPass; } set { requestMessorChangPass = value; } }
        public int Wallet { get { return wallet; } set { wallet = value; } }
        public override void addID(string id)
        {
            this.Id = id;
        }
        public void changeInfo(string request)
        {
            this.request = request;
        }
        public void WriteInfo(string temp)
        {
            using (StreamWriter swriter = new StreamWriter("Customer.txt", true))
            {
                if (temp == null)
                {
                    swriter.WriteLine("");
                }
                swriter.WriteLine(this.Id);
                swriter.WriteLine(this.Firstname);
                swriter.WriteLine(this.Lastname);
                swriter.WriteLine(this.Age);
                swriter.WriteLine(this.Phonenumber);
                swriter.WriteLine(this.Username);
                swriter.WriteLine(this.Password);
                swriter.WriteLine(this.Ticketseri);
                swriter.WriteLine(this.Request);
                swriter.WriteLine(this.RequestMessorChangPass);
                swriter.WriteLine(this.Wallet);
                swriter.Flush();
            }
        }
        public void WriteInfo()
        {
            using (StreamWriter swriter = new StreamWriter("Customer.txt",true))
            {
                swriter.WriteLine(Id);
                swriter.WriteLine(Firstname);
                swriter.WriteLine(Lastname);
                swriter.WriteLine(Age);
                swriter.WriteLine(Phonenumber);
                swriter.WriteLine(Username);
                swriter.WriteLine(Password);
                swriter.WriteLine(Ticketseri);
                swriter.WriteLine(Request);
                swriter.WriteLine(RequestMessorChangPass);
                swriter.WriteLine(Wallet);
                swriter.Flush();
            }
        }
        public static void WriteCustomerList(List<Customer> customers)
        {
            string count;
            using (StreamReader sr = new StreamReader("Customer.txt"))
            {
                count = sr.ReadLine();
            }
            using (StreamWriter swriter = new StreamWriter("Customer.txt"))
            {
                swriter.WriteLine(count);
                swriter.Flush();
            }
            for (int m = 0; m < customers.Count; m++)
            {
                customers[m].WriteInfo();
            }
        }
        public void changeInfo(string firstname,string lastname,int age,string phonenumber,string username,string password)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Phonenumber = phonenumber;
            this.Username = username;
            this.Password = password;
        }
        public void changeInfo()
        {
            throw new NotImplementedException();
        }
    }
}