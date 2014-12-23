using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM.Class
{
    public class Student
    {
        private String _idStudent;

        public String IdStudent
        {
            get { return _idStudent; }
            set { _idStudent = value; }
        }
        private String _nameStudent;

        public String NameStudent
        {
            get { return _nameStudent; }
            set { _nameStudent = value; }
        }

        private String _sexStudent;
        public String SexStudent
        {
            get { return _sexStudent; }
            set 
            {
                if (value.ToString()=="True")
                {
                    _sexStudent = "Male";
                }
                else
                {
                    _sexStudent = "Female";
                }
            }
        }

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        private String _fatherName;
        public String FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }

        private String _motherName;
        public String MotherName
        {
            get { return _motherName; }
            set { _motherName = value; }
        }

        private String _phoneNumber;
        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private String _address;
        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

















    }
}
