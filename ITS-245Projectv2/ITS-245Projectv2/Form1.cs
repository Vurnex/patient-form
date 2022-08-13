/* 

	Laquon Hamilton
	ITS-245
	12/14/20
	Final Project

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ITS_245Projectv2
{
    public partial class mainMenuForm : Form
    {
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDatabase2DataSet.PatientTable' table. You can move, or remove it, as needed.
            this.patientTableTableAdapter1.Fill(this.patientDatabase2DataSet.PatientTable);
            // TODO: This line of code loads data into the 'patientDatabaseDataSet.PatientTable' table. You can move, or remove it, as needed.
            this.patientTableTableAdapter.Fill(this.patientDatabaseDataSet.PatientTable);

            dataGridView1.DataSource = GetPatientsList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
                patientIDTextBox.Clear();
                lastNameTextBox.Clear();
                telephoneTextBox.Clear();
        }

        public static string patientSelected;

        private void loadPatientButtonMain_Click(object sender, EventArgs e)
        {
            if (patientIDTextBox.Text == "1")
            {
                patientSelected = "1";//Patient ID of 1
            }
            if (patientIDTextBox.Text == "2")
            {
                patientSelected = "2";//Patient ID of 2
            }
            if (lastNameTextBox.Text == "Vassily")
            {
                patientSelected = "1";//Last name of Vassily
            }
            if (lastNameTextBox.Text == "Geoffroi")
            {
                patientSelected = "2";//Last name of Geoffroi
            }
            if (telephoneTextBox.Text == "735-989-5675")
            {
                patientSelected = "1";//735 number
            }
            if (telephoneTextBox.Text == "998-231-8305")
            {
                patientSelected = "2";//998 number
            }

            patientForm f2 = new patientForm();
            //f2.Enabled = true;
            f2.ShowDialog(); // Shows Patient Form
            this.Close();
        }

        private DataTable dtPatients = new DataTable();

        private DataTable GetPatientsList()
        {
            //DataTable dtPatients = new DataTable();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb";
            string strSQL = "SELECT * FROM PatientTable";
            // Create a connection    
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    connection.Open();
                    // Execute command    
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        dtPatients.Load(reader);
                    }

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                //connection.Close();
            }

            return dtPatients;
        }

        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterByColumn("PatientID", patientIDTextBox);
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterByColumn("PtLastName", lastNameTextBox);
        }

        private void telephoneTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterByColumn("PtHomePhone", telephoneTextBox);
        }

        private void FilterByColumn(string columnName, TextBox txtBox)
        {
            DataView dvPatient = dtPatients.DefaultView;

            dvPatient.RowFilter = columnName + " LIKE '%" + txtBox.Text + "%'";
        }
    }
}
