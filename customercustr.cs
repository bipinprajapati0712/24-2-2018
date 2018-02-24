using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer
{
    public class cust
    {
        string name;
        string gender;
        DateTime birth;
        long contact;
        string city;
        int cid;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public DateTime Birth
        {
            get
            {
                return birth;
            }

            set
            {
                birth = value;
            }
        }

        public long Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public int Cid
        {
            get
            {
                return cid;
            }

            set
            {
                cid = value;
            }
        }

        public cust(string name, string gender, DateTime birth, long contact, string city, int cid)
        {
            this.Name = name;
            this.Gender = gender;
            this.Birth = birth;
            this.Contact = contact;
            this.City = city;
            this.Cid = cid;
        }
        public cust()
        {

        }

    }
}
