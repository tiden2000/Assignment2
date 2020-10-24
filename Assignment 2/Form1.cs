using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Create an onject type array
        /// </summary>
        public Patient[] patients = new Patient[10];

        /// <summary>
        /// Loop through the "patientList" array index and check if the string in PaitentID property is empty or not
        /// </summary>
        /// <returns> Integer number representing the location of the next empty object </returns>
        public int ReturnNextObject()
        {
            int result = 0;
            for(int i = 0; i <= 9; i = i + 1)
            {
                if(string.IsNullOrWhiteSpace(patients[i].PatientID) == true)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Find out what sex the user choose
        /// </summary>
        /// <returns> String type variable with the same name as the sex chosen or "None" if not chosen </returns>
        public string SelectedSex()
        {
            string str = "";
            if (radioMale.Checked == true)
            {
                str = "Male";
            }
            else if (radioFemale.Checked == true)
            {
                str = "Female";
            }
            else
            {
                str = "None";
            }
            return str;
        }

        /// <summary>
        /// Transfer string type data from textboxes to the Patient.cs class fields
        /// <exameple> GiveData(2) will give data to the thrid object in the array </exameple>
        /// </summary>
        /// <param name="objectIndex"></param>
        public void GiveData(int objectIndex)
        {
            patients[objectIndex].FullName = textFullName.Text;
            patients[objectIndex].Address = textAddress.Text;
            patients[objectIndex].PhoneNumber = textPhoneNumber.Text;
            patients[objectIndex].DateOfBirth = textBirth.Text;
            patients[objectIndex].PatientID = textPatientID.Text;
            patients[objectIndex].Sex = SelectedSex(); 
        }

        /// <summary>
        /// Transfer data from the textboxes to the next empty object in the array
        /// </summary>
        /// <param name="n"></param>
        public void GiveDataToNextObject(int n)  // parameter is the next empty object index in the array
        {
            for(int i = 0; i <= 9; i = i + 1)
            {
                if(i == n)
                {
                    GiveData(i);
                    break;
                }
            }
        }

        /// <summary>
        /// Print to labels on the form design with data from the object at "n" index in array
        /// </summary>
        /// <param name="n"></param>
        public void PrintToLabel(int n)
        {
            labelShowName.Text = patients[n].FullName;
            labelShowAddress.Text = patients[n].Address;
            labelShowPhone.Text = patients[n].PhoneNumber;
            labelShowBirth.Text = patients[n].DateOfBirth;
            labelShowID.Text = patients[n].PatientID;
            labelShowSex.Text = patients[n].Sex;
        }

        /// <summary>
        /// Clear all personal information group text boxes
        /// </summary>
        public void EmptyTextBox()
        {
            textFullName.Clear();
            textAddress.Clear();
            textPhoneNumber.Clear();
            textBirth.Clear();
            textPatientID.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }

        /// <summary>
        /// Check if atleast one textbox is empty
        /// </summary>
        /// <returns> "True" if empty </returns>
        public bool IsEmpty()
        {
            bool empty;
            if
                (
                string.IsNullOrWhiteSpace(textFullName.Text) == true ||
                string.IsNullOrWhiteSpace(textAddress.Text) == true ||
                string.IsNullOrWhiteSpace(textPhoneNumber.Text) == true ||
                string.IsNullOrWhiteSpace(textBirth.Text) == true ||
                string.IsNullOrWhiteSpace(textPatientID.Text) == true ||
                string.Equals(SelectedSex(), "None") == true
                )
            {
                empty = true;
            }
            else { empty = false; }
            return empty;
        }

        /// <summary>
        /// Check if there are duplicates between objects data of Name and PatientID
        /// </summary>
        /// <returns> "True" if duplicate </returns>
        public bool IsDuplicate()
        {
            bool isDuplicate = false;
            for(int i = 0; i <= 9; i = i + 1)
            {
                if(string.Equals(patients[i].PatientID, textPatientID.Text) == true
                    || string.Equals(patients[i].FullName, textFullName.Text) == true)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i <= 9; i = i + 1)  // Create all new objects for the array
            {
                patients[i] = new Patient();
            }
            //   Data for patient Mark
            patients[0].FullName = "Mark";
            patients[0].Address = "149 North Avenue";
            patients[0].PhoneNumber = "992015124";
            patients[0].DateOfBirth = "2/6/2000";
            patients[0].PatientID = "0001";
            patients[0].Sex = "Male";
            listPatients.Items.Add(patients[0].FullName);
            //   Data for patient Lisa
            patients[1].FullName = "Lisa";
            patients[1].Address = "288 Broad Street";
            patients[1].PhoneNumber = "204983014";
            patients[1].DateOfBirth = "9/5/2000";
            patients[1].PatientID = "0002";
            patients[1].Sex = "Female";
            listPatients.Items.Add(patients[1].FullName);
        }

        //=======================Event handlers for form==========================

        /// <summary>
        /// Triggers when the "Add" button is clicked with mouse
        /// Add the string type data of the text from textboxes in the personal information groupbox to next empty "patient" object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            if (IsEmpty() == true)
            {
                MessageBox.Show("Please fill in all the blank");
            }
            else if(IsDuplicate() == true)
            {
                MessageBox.Show("There must not be duplicates of Full Name or Patient Record ID");
            }
            else
            {
                GiveDataToNextObject(ReturnNextObject());
                listPatients.Items.Add(textFullName.Text);
                EmptyTextBox();
            }
        }

        /// <summary>
        /// Triggers when an item in the listbox is selected
        /// Show the data of the object that has same index with the selected index in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listPatients_MouseClick(object sender, MouseEventArgs e)
        {
            if (listPatients.SelectedItem != null)
            {
                PrintToLabel(listPatients.Items.IndexOf(listPatients.SelectedItem));
            }
        }

        /// <summary>
        /// Triggers when the "Edit" button is clicked with mouse
        /// Display to the textboxes all the data of the selected patient in listbox for editing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listPatients.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient to edit");
            }
            else
            {
                textFullName.Text = patients[listPatients.SelectedIndex].FullName;
                textAddress.Text = patients[listPatients.SelectedIndex].Address;
                textPhoneNumber.Text = patients[listPatients.SelectedIndex].PhoneNumber;
                textBirth.Text = patients[listPatients.SelectedIndex].DateOfBirth;
                textPatientID.Text = patients[listPatients.SelectedIndex].PatientID;
                if (string.Equals(SelectedSex(), "Male") == true)
                {
                    radioMale.Checked = true;
                }
                else { radioFemale.Checked = true; }
            }
        }

        /// <summary>
        /// Triggers when the "Update" button is clicked with mouse
        /// Transfer edited data from the textboxes to the selected patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            patients[listPatients.SelectedIndex].FullName = textFullName.Text;
            patients[listPatients.SelectedIndex].Address = textAddress.Text;
            patients[listPatients.SelectedIndex].PhoneNumber = textPhoneNumber.Text;
            patients[listPatients.SelectedIndex].DateOfBirth = textBirth.Text;
            patients[listPatients.SelectedIndex].PatientID = textPatientID.Text;
            patients[listPatients.SelectedIndex].Sex = SelectedSex();
            PrintToLabel(listPatients.SelectedIndex);
        }

        /// <summary>
        /// Triggers when the "Search" button is clicked with mouse
        /// Loop through the patientList array to find the relevant patientID input by user in the search textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textSearch.Text;
            bool isFound = false;
            for(int i = 0; i <= 9; i = i + 1)
            {
                if (string.Equals(patients[i].PatientID, str) == true)
                {
                    listPatients.SelectedIndex = i;
                    PrintToLabel(i);
                    isFound = true;
                    break;
                }
            }
            if(isFound == false)
            {
                MessageBox.Show("Patient not found");
            }
        }

        /// <summary>
        /// Triggers when the "next" button is clicked with mouse
        /// Select and display the next patient from the selected one on the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (listPatients.SelectedIndex < listPatients.Items.Count - 1)
            {
                listPatients.SelectedIndex = listPatients.SelectedIndex + 1;
                PrintToLabel(listPatients.SelectedIndex);
            }
        }

        /// <summary>
        /// Triggers when the "back" button is click with mouse
        /// Select and display the previous patient from the selected one on the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(listPatients.SelectedIndex >= 1)
            {
                listPatients.SelectedIndex = listPatients.SelectedIndex - 1;
                PrintToLabel(listPatients.SelectedIndex);
            }
        }

        /// <summary>
        /// Triggers when the "First" button is clicked with mouse
        /// Select and display the first patient on the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            listPatients.SelectedIndex = 0;
            PrintToLabel(listPatients.SelectedIndex);
        }

        /// <summary>
        /// Triggers when the "Last" button is clicked with mouse
        /// Select and display the last patient on the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLast_Click(object sender, EventArgs e)
        {
            listPatients.SelectedIndex = listPatients.Items.Count - 1;
            PrintToLabel(listPatients.SelectedIndex);
        }
    }
}
