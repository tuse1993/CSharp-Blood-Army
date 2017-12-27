using BloodArmy.Core;
using BloodArmy.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodArmy
{   
   
    public partial class Login : Form
    {
        public static Donor donor = new Donor();
        public static string userID;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            labelId.Text = "ID";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserID.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please Enter User ID and Password");
            }
            else {
                string userID=textBoxUserID.Text;
                string pass=textBoxPassword.Text;
                PersonService personService = new PersonService();
                SqlDataAdapter adapt = personService.Login(userID, pass);
                DataSet ds = new DataSet();

                donor = personService.LoggedPerson(userID); 

                adapt.Fill(ds);               
                int count= ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!\nWelcome:  " + donor.FirstName);
                    RequestForBlood requestForBlood = new RequestForBlood();                     
                    this.Hide();
                    requestForBlood.Show();
                   
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                    textBoxUserID.Clear();
                    textBoxPassword.Clear();
                }
            }
        }

        private void buttonRegister(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
