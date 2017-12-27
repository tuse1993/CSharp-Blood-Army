using BloodArmy.Entity;
using BloodArmy.Core;
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
    public delegate void RefreshDelegate();
    public partial class Registration : Form
    {
        #region TextBoxCheck
        private void TextboxCheck() {
            Donor donor = new Donor();
            string tempTB = textBoxFirstName.Text;   
        
            if (tempTB == (" ") || tempTB == (""))
            {
                MessageBox.Show("First Name Field Is Empty");
                this.Show();

            }
            else {
                donor.FirstName = textBoxFirstName.Text;
            }
            
            if (tempTB == (" ") || tempTB == (""))            {
                MessageBox.Show("Last NameField Is Empty");
            }
            else            {
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
                MessageBox.Show("User ID Field Is Empty");
            }
            else{
                donor.UserId = textBoxUserId.Text;
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
            if (comboBoxCAF.SelectedIndex == 1){
                donor.Available = 0;
            }
            else{
                donor.Available = 1;
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
                this.AddPerson(donor);
                this.Hide();
                this.Show();  
        }
       
         #endregion

        private void AddPerson(Donor donor)
        {
             
            PersonService personService = new PersonService();

            if (personService.Add(donor) == 1)
            {
                MessageBox.Show("Registration Done Successfully!");
            }
        }
        public Registration()
        {
            InitializeComponent();
 
        }

            #region Event Handlers
        private void labelFirstName(object sender, EventArgs e)
        {

        }

        private void labelLastName(object sender, EventArgs e)
        {

        }

        private void labelGender(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void labelMobile(object sender, EventArgs e)
        {

        }

        private void labelDivision(object sender, EventArgs e)
        {

        }

        private void labelDistrict(object sender, EventArgs e)
        {

        }

        private void labelThana(object sender, EventArgs e)
        {

        }

        private void labelStreetAddress(object sender, EventArgs e)
        {

        }

        private void labelBloodGroup(object sender, EventArgs e)
        {

        }

        private void labelExperience(object sender, EventArgs e)
        {

        }

        private void labelHMT(object sender, EventArgs e)
        {

        }

        private void labelPassword(object sender, EventArgs e)
        {

        }

        private void labelConfirmPassword(object sender, EventArgs e)
        {

        }

        private void labeEmail(object sender, EventArgs e)
        {

        }

        private void labelBirthDate(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
       {

        }

        private void comboBoxBDE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDivision.SelectedIndex == 0) {
                comboBoxDistrict.Items.Clear();
                comboBoxDistrict.Items.Add("Dhaka");
                comboBoxDistrict.SelectedIndex = -1;
               
            }
            else if(comboBoxDivision.SelectedIndex == 1) {
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

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistrict.SelectedIndex == 0) {
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

        private void comboBoxThana_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxStreetAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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

        private void comboBoxBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelUserID(object sender, EventArgs e)
        {

        }


        private void textBoxUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCurrentlyAvailableForDonation(object sender, EventArgs e)
        {

        }

        private void comboBoxCAFD(object sender, EventArgs e)
        {

        }

        private void comboBox1_selected(object sender, EventArgs e)
        {

        }

       
        #endregion

        private void buttonRegister(object sender, EventArgs e)
        {
            
            if(string.IsNullOrWhiteSpace(textBoxFirstName.Text) && string.IsNullOrWhiteSpace(textBoxLastName.Text) && string.IsNullOrEmpty(comboBoxGender.Text) && string.IsNullOrEmpty(comboBoxDivision.Text) && string.IsNullOrEmpty(comboBoxDistrict.Text) && string.IsNullOrEmpty(comboBoxThana.Text)
               && string.IsNullOrWhiteSpace(textBoxStreetAddress.Text) && string.IsNullOrEmpty(comboBoxBloodGroup.Text) && string.IsNullOrEmpty(comboBoxCAF.Text) && string.IsNullOrWhiteSpace(textBoxPassword.Text) && string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text) && string.IsNullOrWhiteSpace(textBoxEmail.Text)
               && string.IsNullOrWhiteSpace(textBoxUserId.Text))
            {
                MessageBox.Show("All Fields Are Empty");              
                this.Show();
            }
            else{
                this.TextboxCheck();
                
            }           
        }        
    }
}
