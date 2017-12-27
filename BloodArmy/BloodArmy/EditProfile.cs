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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
            textBoxFirstName.Text = Login.donor.FirstName;
            textBoxLastName.Text = Login.donor.LastName;
            textBoxMobile.Text = Login.donor.PhoneNumber;
            textBoxStreetAddress.Text = Login.donor.StreetAddress;
            textBoxPassword.Text = Login.donor.Password;
            textBoxEmail.Text = Login.donor.Email;

        }

        private void EditPerson(Donor donor){

            PersonService personService = new PersonService();

            if (personService.Edit(donor) == 1){
                MessageBox.Show("Edited Successfully!");
            }
        }
          #region TextBoxCheck

          private void TextboxCheck(){

           
            Donor donor = new Donor();

            string tempTB = textBoxFirstName.Text;
            
            if (tempTB == (" ") || tempTB == ("")){
                MessageBox.Show("First Name Field Is Empty");              
                this.Show();
               
            }
            else {
                donor.FirstName = textBoxFirstName.Text;
            }
            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("Last Name Field Is Empty");
            }
            else{
                donor.LastName = textBoxLastName.Text;
            }

            tempTB = textBoxEmail.Text;
            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("Email Field Is Empty");

            }
            else{
                donor.Email = textBoxEmail.Text;
            }
            tempTB = textBoxMobile.Text;
            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("Phone Number Field Is Empty");
            }
            else{
                donor.PhoneNumber = textBoxMobile.Text;
            }

            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("Gender Field Is Empty");

            }
            else{
                donor.Gender = comboBoxGender.SelectedItem.ToString();
            }
            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("Divison Field Is Empty");

            }
            else{
                donor.Division = comboBoxDivision.SelectedItem.ToString();

            }
            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("District Field Is Empty");

            }
            else{
                donor.District = comboBoxDistrict.SelectedItem.ToString();

            }
            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("Thana Field Is Empty");

            }
            else{
                donor.Thana = comboBoxThana.SelectedItem.ToString();
            }
            tempTB = textBoxStreetAddress.Text;

            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("Street Address Field Is Empty");
            }
            else{
                donor.StreetAddress = textBoxStreetAddress.Text;
            }
            
            if (tempTB == (" ") || tempTB == ("")){
                MessageBox.Show("Did Not Choose any Date ");
            }
            else{
                donor.BirthDate = dateTimePicker1.Value.Date;
            }
            if (tempTB == (" ") || tempTB == ("")){
               MessageBox.Show("Blood Group Field Is Empty");
            }
            else{
                donor.BloodGroup = comboBoxBloodGroup.SelectedItem.ToString();
            }
            string tempPass = "";
            if (tempTB == (" ") || tempTB == ("")){
                MessageBox.Show("Password Field Is Empty");
            }
            else{
                tempPass = textBoxPassword.Text;
            }
            string tempConPass = "";

            if (tempTB == (" ") || tempTB == ("")){
                MessageBox.Show("Confirm Password Field Is Empty");
            }
            else{
                tempConPass = textBoxConfirmPassword.Text;
            }
           
            if (tempPass.Equals(tempConPass)){
                donor.Password = textBoxPassword.Text;
            }
            else{
                MessageBox.Show("Password Doesn't Match");
                textBoxPassword.Clear();
                textBoxConfirmPassword.Clear();
            }
            int n;
            bool isNumeric = int.TryParse(textBoxMobile.Text, out n);
            if(isNumeric==true){
                donor.PhoneNumber = textBoxMobile.Text;
            }
            else{
                MessageBox.Show("Please Enter A Valid Mobile Number");
            }
                donor.UserId = Login.donor.UserId;
                this.EditPerson(donor);               
                this.Show();  
        }
       
            #endregion
          
          #region Event Handlers
          private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
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
                comboBoxDistrict.SelectedIndex = -1;

            }
            else if (comboBoxDivision.SelectedIndex == 1)
            {
                comboBoxDistrict.Items.Clear();
                comboBoxDistrict.Items.Add("Chittagong");
                comboBoxDistrict.Items.Add("Rangamati");
                comboBoxDistrict.SelectedIndex = -1;
            }
            else if (comboBoxDivision.SelectedIndex == 2)
            {
                comboBoxDistrict.Items.Add("Rajshahi");
            }

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHMT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStreetAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBDE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
          #endregion

        private void buttonEdit(object sender, EventArgs e)
        {
            this.TextboxCheck();
            RequestForBlood requestForBlood = new RequestForBlood();
            this.Hide();
            requestForBlood.Show();
        }

        private void buttonBack(object sender, EventArgs e)
        {
            RequestForBlood requestForBlood = new RequestForBlood();
            this.Hide();
            requestForBlood.Show();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
