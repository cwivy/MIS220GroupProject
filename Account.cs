using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS220GroupProject
{
    class Account
    {
        private int id;
        private int pass;
        private string fName;
        private string lName;
        private string address;
        private string phone;
        private string city;
        private string state;
        private int zip;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
    }
}
