using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// Main class
    /// Store all data of the patient
    /// </summary>
    public class Patient
    {
        private string fullName;
        private string address;
        private string phoneNumber;
        private string dateOfBirth;
        private string patientID;
        private string sex;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public string PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public Patient() { }
    }
}
