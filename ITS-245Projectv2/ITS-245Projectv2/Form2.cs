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
    public partial class patientForm : Form
    {
        public patientForm()
        {
            InitializeComponent();
        }

        private void returnToMainButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void patientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDatabase2DataSet.PatientTable' table. You can move, or remove it, as needed.
            this.patientTableTableAdapter.Fill(this.patientDatabase2DataSet.PatientTable);

            if (mainMenuForm.patientSelected == "1")
            {
                displayPatient1Demographics();
                displayAllergyHistory1();
                displayFamilyHistory1();
                displayGeneralMedicalHistory1();
                displayImmunizationHistory1();
            }
            if (mainMenuForm.patientSelected == "2")
            {
                displayPatient2Demographics();
                displayAllergyHistory2();
                displayFamilyHistory2();
                displayGeneralMedicalHistory2();
                displayImmunizationHistory2();
            }

        }
        
        //For clearing the textboxs
        private void clearAllTextBoxes()
        {
            //Clear Demographics
            patientIDLoaderTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipCodeTextBox.Clear();
            countryTextBox.Clear();
            citizenshipTextBox.Clear();
            phoneNumTextBox.Clear();
            emergencyNumTextBox.Clear();
            emailTextBox.Clear();
            ssnTextBox.Clear();
            doBTextBox.Clear();
            genderTextBox.Clear();
            ethnicityTextBox.Clear();
            religionTextBox.Clear();
            maritalStatusTextBox.Clear();
            dateAdmittedTextBox.Clear();
            nextofKinTextBox.Clear();
            kinRelationTextbox.Clear();
            demoCommentsTextBox.Clear();

            //Clear Allergy
            allergenTextBox.Clear();
            allergyStartTextBox.Clear();
            allergyEndTextBox.Clear();
            allergyDescriptionTextBox.Clear();
            allergyCommentsTextBox.Clear();

            //Clear Family
            familyNameTextBox.Clear();
            familyRelationTextBox.Clear();
            majorDisorderTextBox.Clear();
            specificTypeTextBox.Clear();
            familyHistoryCommentsTextBox.Clear();

            //Clear General
            genMaritalStatusTextBox.Clear();
            educationTextBox.Clear();
            growthAndDevTextBox.Clear();
            pregnanciesTextBox.Clear();
            behavioralTextBox.Clear();
            tobaccoUsageTextBox.Clear();
            AlcoholUsageTextBox.Clear();
            drugUsageTextBox.Clear();
            dietaryTextBox.Clear();
            traveledTextBox.Clear();
            bloodTypeTextBox.Clear();
            rhTextBox.Clear();
            hxTextBox.Clear();
            lmpDateTextBox.Clear();
            currentlyPregnantTextBox.Clear();
            numChildrenTextBox.Clear();
            numPregnanciesTextBox.Clear();
            deliveryHospitalTextBox.Clear();
            genMedHistCommentsTextBox.Clear();

            //Clear Immunizations
            vaccineTextBox.Clear();
            immunizationDateTextBox.Clear();
            expDateTextBox.Clear();
            immunizationDeliveryTextBox.Clear();
            hcpIDTextBox.Clear();
            immunizationsCommentsTextBox.Clear();
        }

        //For enabling text boxes for modifications
        private void enableTextBoxes()
        {
            //Enable Demographics
            patientIDLoaderTextBox.ReadOnly = false;
            addressTextBox.ReadOnly = false;
            cityTextBox.ReadOnly = false;
            stateTextBox.ReadOnly = false;
            zipCodeTextBox.ReadOnly = false;
            countryTextBox.ReadOnly = false;
            citizenshipTextBox.ReadOnly = false;
            phoneNumTextBox.ReadOnly = false;
            emergencyNumTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            ssnTextBox.ReadOnly = false;
            doBTextBox.ReadOnly = false;
            genderTextBox.ReadOnly = false;
            ethnicityTextBox.ReadOnly = false;
            religionTextBox.ReadOnly = false;
            maritalStatusTextBox.ReadOnly = false;
            dateAdmittedTextBox.ReadOnly = false;
            nextofKinTextBox.ReadOnly = false;
            kinRelationTextbox.ReadOnly = false;
            demoCommentsTextBox.ReadOnly = false;

            //Enable Allergy
            allergenTextBox.ReadOnly = false;
            allergyStartTextBox.ReadOnly = false;
            allergyEndTextBox.ReadOnly = false;
            allergyDescriptionTextBox.ReadOnly = false;
            allergyCommentsTextBox.ReadOnly = false;

            //Enable Family
            familyNameTextBox.ReadOnly = false;
            familyRelationTextBox.ReadOnly = false;
            majorDisorderTextBox.ReadOnly = false;
            specificTypeTextBox.ReadOnly = false;
            familyHistoryCommentsTextBox.ReadOnly = false;

            //Enable General
            genMaritalStatusTextBox.ReadOnly = false;
            educationTextBox.ReadOnly = false;
            growthAndDevTextBox.ReadOnly = false;
            pregnanciesTextBox.ReadOnly = false;
            behavioralTextBox.ReadOnly = false;
            tobaccoUsageTextBox.ReadOnly = false;
            AlcoholUsageTextBox.ReadOnly = false;
            drugUsageTextBox.ReadOnly = false;
            dietaryTextBox.ReadOnly = false;
            traveledTextBox.ReadOnly = false;
            bloodTypeTextBox.ReadOnly = false;
            rhTextBox.ReadOnly = false;
            hxTextBox.ReadOnly = false;
            lmpDateTextBox.ReadOnly = false;
            currentlyPregnantTextBox.ReadOnly = false;
            numChildrenTextBox.ReadOnly = false;
            numPregnanciesTextBox.ReadOnly = false;
            deliveryHospitalTextBox.ReadOnly = false;
            genMedHistCommentsTextBox.ReadOnly = false;

            //Enable Immunizations
            vaccineTextBox.ReadOnly = false;
            immunizationDateTextBox.ReadOnly = false;
            expDateTextBox.ReadOnly = false;
            immunizationDeliveryTextBox.ReadOnly = false;
            hcpIDTextBox.ReadOnly = false;
            immunizationsCommentsTextBox.ReadOnly = false;
        }

        //For disabling the textboxes again
        private void disableTextBoxes()
        {
            //Disable Demographics
            patientIDLoaderTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            cityTextBox.ReadOnly = true;
            stateTextBox.ReadOnly = true;
            zipCodeTextBox.ReadOnly = true;
            countryTextBox.ReadOnly = true;
            citizenshipTextBox.ReadOnly = true;
            phoneNumTextBox.ReadOnly = true;
            emergencyNumTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            ssnTextBox.ReadOnly = true;
            doBTextBox.ReadOnly = true;
            genderTextBox.ReadOnly = true;
            ethnicityTextBox.ReadOnly = true;
            religionTextBox.ReadOnly = true;
            maritalStatusTextBox.ReadOnly = true;
            dateAdmittedTextBox.ReadOnly = true;
            nextofKinTextBox.ReadOnly = true;
            kinRelationTextbox.ReadOnly = true;
            demoCommentsTextBox.ReadOnly = true;

            //Disable Allergy
            allergenTextBox.ReadOnly = true;
            allergyStartTextBox.ReadOnly = true;
            allergyEndTextBox.ReadOnly = true;
            allergyDescriptionTextBox.ReadOnly = true;
            allergyCommentsTextBox.ReadOnly = true;

            //Disable Family
            familyNameTextBox.ReadOnly = true;
            familyRelationTextBox.ReadOnly = true;
            majorDisorderTextBox.ReadOnly = true;
            specificTypeTextBox.ReadOnly = true;
            familyHistoryCommentsTextBox.ReadOnly = true;

            //Disable General
            genMaritalStatusTextBox.ReadOnly = true;
            educationTextBox.ReadOnly = true;
            growthAndDevTextBox.ReadOnly = true;
            pregnanciesTextBox.ReadOnly = true;
            behavioralTextBox.ReadOnly = true;
            tobaccoUsageTextBox.ReadOnly = true;
            AlcoholUsageTextBox.ReadOnly = true;
            drugUsageTextBox.ReadOnly = true;
            dietaryTextBox.ReadOnly = true;
            traveledTextBox.ReadOnly = true;
            bloodTypeTextBox.ReadOnly = true;
            rhTextBox.ReadOnly = true;
            hxTextBox.ReadOnly = true;
            lmpDateTextBox.ReadOnly = true;
            currentlyPregnantTextBox.ReadOnly = true;
            numChildrenTextBox.ReadOnly = true;
            numPregnanciesTextBox.ReadOnly = true;
            deliveryHospitalTextBox.ReadOnly = true;
            genMedHistCommentsTextBox.ReadOnly = true;

            //Disable Immunizations
            vaccineTextBox.ReadOnly = true;
            immunizationDateTextBox.ReadOnly = true;
            expDateTextBox.ReadOnly = true;
            immunizationDeliveryTextBox.ReadOnly = true;
            hcpIDTextBox.ReadOnly = true;
            immunizationsCommentsTextBox.ReadOnly = true;
        }

        private void loadAnotherPatientButton_Click(object sender, EventArgs e)
        {
            if (patientIDLoaderTextBox.Text == "1")
            {
                mainMenuForm.patientSelected = "1";
                clearAllTextBoxes();
                patientForm_Load(sender, e);
            }
            else if (patientIDLoaderTextBox.Text == "2")
            {
                mainMenuForm.patientSelected = "2";
                clearAllTextBoxes();
                patientForm_Load(sender, e);
            }
            
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Lavender;

            //Enable/Disable buttons
            saveRecordButton.Enabled = true;
            modifyRecordButton.Enabled = false;
            undoChangesButton.Enabled = false;
            deleteRecordButton.Enabled = false;

            //Clear displayed textbox data
            clearAllTextBoxes();

            //Enable textboxes for adding data
            enableTextBoxes();

            //Add fields for adding patient name and age
            newPatientAgeLabel.Visible = true;
            newPatientAgeTextBox.Visible = true;
            newPatientNameLabel.Visible = true;
            newPatientNameTextBox.Visible = true;

            //Change main labels
            selectedPatientNameLabel.Text = "Add Record";
            selectedPatientAgeLabel.Text = ".";

        }

        private void saveRecordButton_Click(object sender, EventArgs e)
        {

            saveRecordButton.Enabled = false;
            modifyRecordButton.Enabled = true;
            deleteRecordButton.Enabled = true;

            addNewRecord();
            newPatientNameLabel.Visible = false;
            newPatientNameTextBox.Visible = false;
            newPatientAgeLabel.Visible = false;
            newPatientAgeTextBox.Visible = false;
            patientForm_Load(sender, e);

            this.BackColor = Color.LightSteelBlue;
        }

        private void modifyRecordButton_Click(object sender, EventArgs e)
        {
            saveChangesButton.Enabled = true;
            addRecordButton.Enabled = false;
            saveRecordButton.Enabled = false;
            modifyRecordButton.Enabled = false;
            deleteRecordButton.Enabled = false;
        }
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            undoChangesButton.Enabled = true;
            saveChangesButton.Enabled = false;
            addRecordButton.Enabled = true;
            modifyRecordButton.Enabled = true;
            deleteRecordButton.Enabled = true;
        }

        private void undoChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                //string strSQL = "INSERT INTO PatientTable(PtPreviousLastName) VALUES ('Test2') WHERE PatientID = '1'";

                OleDbCommand cmd = connection.CreateCommand();

                string sql;

                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql = "DELETE FROM PatientTable WHERE PtPreviousLastName = 'testrec'";

                //cmd.Parameters.Add(new OleDbParameter("@PtPreviousLastName", OleDbType.VarChar)).Value = testTextBox.Text;

                //open connection
                connection.Open();

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Record Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        //Display Patients Demographics
        private void displayPatient1Demographics()
        {
            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM PatientTable WHERE PatientID = '1'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        selectedPatientNameLabel.Text = reader["PtFirstName"].ToString() + " " + reader["PtLastName"].ToString();
                        selectedPatientAgeLabel.Text = reader["Age"].ToString();
                        patientIDLoaderTextBox.Text = reader["PatientID"].ToString();
                        addressTextBox.Text = reader["HomeAddress1"].ToString();
                        cityTextBox.Text = reader["HomeCity"].ToString();
                        stateTextBox.Text = reader["HomeState/Province/Region"].ToString();
                        zipCodeTextBox.Text = reader["HomeZip"].ToString();
                        countryTextBox.Text = reader["Country"].ToString();
                        citizenshipTextBox.Text = reader["Citizenship"].ToString();
                        phoneNumTextBox.Text = reader["PtHomePhone"].ToString();
                        emergencyNumTextBox.Text = reader["EmergencyPhoneNumber"].ToString();
                        emailTextBox.Text = reader["EmailAddress"].ToString();
                        ssnTextBox.Text = reader["PtSSN"].ToString();
                        doBTextBox.Text = reader["DateOfBirth"].ToString();
                        genderTextBox.Text = reader["Gender"].ToString();
                        ethnicityTextBox.Text = reader["EthnicAssociation"].ToString();
                        religionTextBox.Text = reader["Religion"].ToString();
                        maritalStatusTextBox.Text = reader["MaritalStatus"].ToString();
                        dateAdmittedTextBox.Text = reader["DateEntered"].ToString();
                        nextofKinTextBox.Text = reader["NextOfKin"].ToString();
                        kinRelationTextbox.Text = reader["NextOfKinRelationshipToPatient"].ToString();

                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void displayPatient2Demographics()
        {
            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM PatientTable WHERE PatientID = '2'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        selectedPatientNameLabel.Text = reader["PtFirstName"].ToString() + " " + reader["PtLastName"].ToString();
                        selectedPatientAgeLabel.Text = reader["Age"].ToString();
                        patientIDLoaderTextBox.Text = reader["PatientID"].ToString();
                        addressTextBox.Text = reader["HomeAddress1"].ToString();
                        cityTextBox.Text = reader["HomeCity"].ToString();
                        stateTextBox.Text = reader["HomeState/Province/Region"].ToString();
                        zipCodeTextBox.Text = reader["HomeZip"].ToString();
                        countryTextBox.Text = reader["Country"].ToString();
                        citizenshipTextBox.Text = reader["Citizenship"].ToString();
                        phoneNumTextBox.Text = reader["PtHomePhone"].ToString();
                        emergencyNumTextBox.Text = reader["EmergencyPhoneNumber"].ToString();
                        emailTextBox.Text = reader["EmailAddress"].ToString();
                        ssnTextBox.Text = reader["PtSSN"].ToString();
                        doBTextBox.Text = reader["DateOfBirth"].ToString();
                        genderTextBox.Text = reader["Gender"].ToString();
                        ethnicityTextBox.Text = reader["EthnicAssociation"].ToString();
                        religionTextBox.Text = reader["Religion"].ToString();
                        maritalStatusTextBox.Text = reader["MaritalStatus"].ToString();
                        dateAdmittedTextBox.Text = reader["DateEntered"].ToString();
                        nextofKinTextBox.Text = reader["NextOfKin"].ToString();
                        kinRelationTextbox.Text = reader["NextOfKinRelationshipToPatient"].ToString();

                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }


        //Display Patients Allergy History
        private void displayAllergyHistory1()
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM AllergyHistoryTable WHERE PatientID = '1'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allergenTextBox.Text = reader["Allergen"].ToString();
                        allergyStartTextBox.Text = reader["AllergyStartDate"].ToString();
                        allergyEndTextBox.Text = reader["AllergyEndDate"].ToString();
                        allergyDescriptionTextBox.Text = reader["AllergyDescription"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void displayAllergyHistory2()
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM AllergyHistoryTable WHERE PatientID = '2'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allergenTextBox.Text = reader["Allergen"].ToString();
                        allergyStartTextBox.Text = reader["AllergyStartDate"].ToString();
                        allergyEndTextBox.Text = reader["AllergyEndDate"].ToString();
                        allergyDescriptionTextBox.Text = reader["AllergyDescription"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        //Display Patients Family History
        private void displayFamilyHistory1()
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM FamilyHistoryTable WHERE PatientID = '1'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        familyNameTextBox.Text = reader["FamilyName"].ToString();
                        familyRelationTextBox.Text = reader["FamilyRelation"].ToString();
                        majorDisorderTextBox.Text = reader["MajorDisorder"].ToString();
                        specificTypeTextBox.Text = reader["SpecificTypeDisorder"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void displayFamilyHistory2()
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM FamilyHistoryTable WHERE PatientID = '2'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        familyNameTextBox.Text = reader["FamilyName"].ToString();
                        familyRelationTextBox.Text = reader["FamilyRelation"].ToString();
                        majorDisorderTextBox.Text = reader["MajorDisorder"].ToString();
                        specificTypeTextBox.Text = reader["SpecificTypeDisorder"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        //Display Patients General Medical History

        private void displayGeneralMedicalHistory1()
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM GeneralMedicalHistoryTable WHERE PatientID = '1'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        genMaritalStatusTextBox.Text = reader["MaritalStatus"].ToString();
                        educationTextBox.Text = reader["Education"].ToString();
                        growthAndDevTextBox.Text = reader["GrowthAndDevelopment"].ToString();
                        pregnanciesTextBox.Text = reader["Pregnancies"].ToString();
                        behavioralTextBox.Text = reader["BehavioralHistory"].ToString();
                        tobaccoUsageTextBox.Text = reader["Tobacco"].ToString();
                        AlcoholUsageTextBox.Text = reader["Alcohol"].ToString();
                        drugUsageTextBox.Text = reader["Drug"].ToString();
                        dietaryTextBox.Text = reader["Dietary"].ToString();
                        traveledTextBox.Text = reader["Travel"].ToString();
                        bloodTypeTextBox.Text = reader["BloodType"].ToString();
                        rhTextBox.Text = reader["Rh"].ToString();
                        hxTextBox.Text = reader["HxObtainedBy"].ToString();
                        lmpDateTextBox.Text = reader["LMPDate"].ToString();
                        currentlyPregnantTextBox.Text = reader["Pregnant"].ToString();
                        numChildrenTextBox.Text = reader["NumberOfChildren"].ToString();
                        numPregnanciesTextBox.Text = reader["NumberOfPregnancies"].ToString();
                        deliveryHospitalTextBox.Text = reader["HospitalOfDelivery"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void displayGeneralMedicalHistory2()
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM GeneralMedicalHistoryTable WHERE PatientID = '2'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        genMaritalStatusTextBox.Text = reader["MaritalStatus"].ToString();
                        educationTextBox.Text = reader["Education"].ToString();
                        growthAndDevTextBox.Text = reader["GrowthAndDevelopment"].ToString();
                        pregnanciesTextBox.Text = reader["Pregnancies"].ToString();
                        behavioralTextBox.Text = reader["BehavioralHistory"].ToString();
                        tobaccoUsageTextBox.Text = reader["Tobacco"].ToString();
                        AlcoholUsageTextBox.Text = reader["Alcohol"].ToString();
                        drugUsageTextBox.Text = reader["Drug"].ToString();
                        dietaryTextBox.Text = reader["Dietary"].ToString();
                        traveledTextBox.Text = reader["Travel"].ToString();
                        bloodTypeTextBox.Text = reader["BloodType"].ToString();
                        rhTextBox.Text = reader["Rh"].ToString();
                        hxTextBox.Text = reader["HxObtainedBy"].ToString();
                        lmpDateTextBox.Text = reader["LMPDate"].ToString();
                        currentlyPregnantTextBox.Text = reader["Pregnant"].ToString();
                        numChildrenTextBox.Text = reader["NumberOfChildren"].ToString();
                        numPregnanciesTextBox.Text = reader["NumberOfPregnancies"].ToString();
                        deliveryHospitalTextBox.Text = reader["HospitalOfDelivery"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        //Display Patients Immunizations History

        private void displayImmunizationHistory1()
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM ImmunizationsHistoryTable WHERE PatientID = '1'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vaccineTextBox.Text = reader["Vaccine"].ToString();
                        immunizationDateTextBox.Text = reader["ImmunizationDate"].ToString();
                        expDateTextBox.Text = reader["ExpirationDate"].ToString();
                        immunizationDeliveryTextBox.Text = reader["Delivery"].ToString();
                        hcpIDTextBox.Text = reader["HCPid"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void displayImmunizationHistory2()
        {

            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                //Query for the database
                string strSQL = "SELECT * FROM ImmunizationsHistoryTable WHERE PatientID = '2'";

                //open connection
                connection.Open();

                //Create command
                OleDbCommand command = new OleDbCommand(strSQL, connection);

                //Execute command
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vaccineTextBox.Text = reader["Vaccine"].ToString();
                        immunizationDateTextBox.Text = reader["ImmunizationDate"].ToString();
                        expDateTextBox.Text = reader["ExpirationDate"].ToString();
                        immunizationDeliveryTextBox.Text = reader["Delivery"].ToString();
                        hcpIDTextBox.Text = reader["HCPid"].ToString();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        //Add new record
        public static string updatedName;
        private void addNewRecord()
        {
            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                OleDbCommand cmd = connection.CreateCommand();

                string sql;

                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql = "INSERT INTO PatientTable (PatientID, PtLastName) VALUES (3, ?)";

                cmd.Parameters.Add(new OleDbParameter("@PtLastName", OleDbType.VarChar)).Value = newPatientNameTextBox.Text;
                cmd.Parameters.Add(new OleDbParameter("@Age", OleDbType.VarChar)).Value = newPatientAgeTextBox.Text;

                //cmd.CommandText = @"INSERT INTO PatientTable([PtPreviousLastName]) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "')";

                //open connection
                connection.Open();

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Record Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            updatedName = newPatientNameTextBox.Text;
        }

        private void deleteNewRecord()
        {
            try
            {
                //Establish new connection
                OleDbConnection connection = new OleDbConnection();

                //Set path for database
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\hamil133\\Documents\\PatientDatabase2.accdb; Persist Security Info = False;";

                OleDbCommand cmd = connection.CreateCommand();

                string sql;

                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql = "DELETE FROM PatientTable WHERE [PatientID] = '3'";

                //open connection
                connection.Open();

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Record Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
