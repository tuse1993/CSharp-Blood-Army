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
    public partial class SearchBlood : Form
    {
        public SearchBlood()
        {
            InitializeComponent();

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SearchBlood_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "User ID";
            dataGridView1.Columns[1].Name = "First Name";
            dataGridView1.Columns[2].Name = "Thana";

            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            colBtn.UseColumnTextForButtonValue = true;
            colBtn.HeaderText = "Request";
            colBtn.Text = "Request";
            colBtn.Name = "Request";
            dataGridView1.Columns.Add(colBtn);
            for (int i = 0; i < RequestForBlood.donorList.Count(); i++)
            {
                dataGridView1.Rows.Add(RequestForBlood.donorList[i].UserId, RequestForBlood.donorList[i].FirstName, RequestForBlood.donorList[i].Thana);
            }
 
        }

        private void buttonBack(object sender, EventArgs e)
        {
            RequestForBlood requestForBlood = new RequestForBlood();
            this.Hide();
            requestForBlood.Show();
        }


        private void buttonLogout(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) {
                Donor donor = new Donor();
                
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string a = selectedRow.Cells["User ID"].Value.ToString();
 
                donor.UserId = a;
                donor.Requests = 1;
                PersonService personService = new PersonService();
                if (personService.Request(donor) == 1){
                    MessageBox.Show("Requested For Blood");
                }

                personService.AddReciever(RequestForBlood.reciever,donor.UserId);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e){ 
         }

      }
}

