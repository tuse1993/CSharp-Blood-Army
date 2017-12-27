using BloodArmy.Core;
using BloodArmy.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodArmy
{   
    public partial class RequestForBlood : Form
    {
        public static Reciever reciever = new Reciever();

        public static List<Donor> donorList = new List<Donor>();
       
        public void RequestPerson(){
            reciever.PhoneNumber = textBoxContactNumber.Text;
            reciever.Name = textBoxContactName.Text;
            reciever.BloodGroup= comboBoxBloodGroup.Text.ToString();
            reciever.Thana = comboBoxThana.SelectedItem.ToString();
            reciever.Division = comboBoxDivision.SelectedItem.ToString();
            reciever.District = comboBoxDistrict.SelectedItem.ToString();
            PersonService personService = new PersonService();
            donorList = personService.GetByBloodGroup(reciever.BloodGroup, reciever.Thana);  
        }
        public RequestForBlood()
        {
            InitializeComponent();
            label4.Text=Login.donor.FirstName;
            label8.Text= Login.donor.Requests.ToString();
            /*if (label8.Text.Equals("1"))
            {
                comboBoxNoOfRequests.SelectedIndex = 0;
            }
            else {
                comboBoxNoOfRequests.SelectedIndex = -1;
            }*/
        }

        private void RequestForBlood_Load(object sender, EventArgs e)
        {

        }

        private void labelContactName(object sender, EventArgs e)
        {

        }

        private void textBoxContactName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxThana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistrict.SelectedIndex == 0)
            {
                comboBoxThana.Items.Clear();
                comboBoxThana.Items.Add("Ramna");
                comboBoxThana.Items.Add("Hathazari");
                comboBoxThana.SelectedIndex = -1;
            }
            else if (comboBoxDistrict.SelectedIndex == 1)
            {
                comboBoxThana.Items.Clear();
                comboBoxThana.Items.Add("Rauzan");
                comboBoxThana.SelectedIndex = -1;
            }
            
        }

        private void comboBoxDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDivision.SelectedIndex == 0)
            {
                comboBoxDistrict.Items.Clear();
                comboBoxDistrict.Items.Add("Dhaka");
                //comboBoxDistrict.SelectedIndex = -1;

            }
            else if (comboBoxDivision.SelectedIndex == 1)
            {
                comboBoxDistrict.Items.Clear();
                comboBoxDistrict.Items.Add("Chittagong");
                comboBoxDistrict.Items.Add("Rangamati");
                //comboBoxDistrict.SelectedIndex = -1;
            }
            else if (comboBoxDivision.SelectedIndex == 2)
            {
                comboBoxDistrict.Items.Add("Rajshahi");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelBloodGroup_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRequest(object sender, EventArgs e)
        {
            SearchBlood searchBlood = new SearchBlood();
            this.RequestPerson();
            this.Hide();
            searchBlood.Show();

        }
        private void buttonEditProfile(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            this.Hide();
            editProfile.Show();
        }

        
        private void buttonLogOut(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void labelNameOfUser(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNoOfRequests.SelectedItem.Equals("Accept")) {
                PersonService personService = new PersonService();
                reciever=personService.AcceptRequest(Login.donor.UserId);
                MessageBox.Show("Recievers Name: "+reciever.Name +"\nRecievers Number: " +reciever.PhoneNumber+ "\nRecievers Thana: " +reciever.Thana);

            }
            else if(comboBoxNoOfRequests.SelectedItem.Equals("Reject")){
                PersonService personService = new PersonService();
                personService.RejectRequest(Login.donor.UserId);
                MessageBox.Show("Request Rejected");
                Login.donor.Requests = 0;
                personService.Request(Login.donor);
            }
        }

    }
}
