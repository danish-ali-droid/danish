using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfaqProject
{
    public partial class departmentcobobox : Form
    {
        public static String name, fname, phone, cnic, department, dob;

  

        DataTable dtadmission = new DataTable();
        public departmentcobobox()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Want to Exit", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();

        }


        private void filladmissontable()
        {
            name = nametxtbox.Text;
            fname = fathernametxtbox.Text;
            phone = phonenotxtbox.Text;
            cnic = cnictxtbox.Text;
            dob = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            department = comboBox1.Text;
            if (dtadmission.Columns.Count == 0)
            {


                //  dtadmission.Columns.Add("AID", typeof(int));
                dtadmission.Columns.Add("Name");
                dtadmission.Columns.Add("Fname");
                dtadmission.Columns.Add("Cnic");
                dtadmission.Columns.Add("Phone");
                 dtadmission.Columns.Add("Department");

                dtadmission.Columns.Add("DOB");


                dtadmission.Rows.Add(name, fname, cnic, phone,department,dob);

            }
            else
            {
                dtadmission.Rows.Add(name, fname, cnic, phone,department,dob);
                int newAID = dtadmission.Columns.Count + 1;
            }

        }
        private void submitbtn_Click(object sender, EventArgs e)
        {


                DialogResult result = MessageBox.Show("Are you sure data is Correct", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                    filladmissontable();

                if (!string.IsNullOrEmpty(department) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(cnic) && !string.IsNullOrEmpty(dob))
                {

                    dataGridView1.DataSource = dtadmission;
                dataGridView1.Enabled = false;
                dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns[0].Width = 125;
                    dataGridView1.Columns[1].Width = 125;
                    dataGridView1.Columns[2].Width = 125;
                    dataGridView1.Columns[3].Width = 125;
                    dataGridView1.Columns[4].Width = 125;
                    dataGridView1.Columns[5].Width = 125;

                    nametxtbox.Text = " ";
                fathernametxtbox.Text = " ";
                phonenotxtbox.Text = " ";
                cnictxtbox.Text = " ";
             
                    }
                    else
                    {
                        MessageBox.Show("Please Input All Values","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }


                }
        }
    }
}
