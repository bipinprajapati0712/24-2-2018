using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Class1
    {
        int customerid;
        float amount;
        DateTime date;
        string atype;
        string status;

        public int Customerid
        {
            get
            {
                return customerid;
            }

            set
            {
                customerid = value;
            }
        }

        public float Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Atype
        {
            get
            {
                return atype;
            }

            set
            {
                atype = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public Class1(int customerid, float amount, DateTime date, string atype, string status)
        {
            this.Customerid = customerid;
            this.Amount = amount;
            this.Date = date;
            this.Atype = atype;
            this.Status = status;
        }
        public Class1()
        {

        }

    }

}
