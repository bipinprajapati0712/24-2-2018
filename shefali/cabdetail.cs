using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABBOOKING
{
    public class CabDetails:ICabDetails
    {
        // Booking Reference Number Passenger Name From Location Departure Time To Location Distance in Km Estimated Amount Cab Type Cab Contact Number
        static int autogen = 5000;
        int book_ref_num;
        string pass_name;
        string from_loc;
        DateTime dep_time;
        string to_loc;
        double loc_dist;
        double amount;
        string cab_type;
        long contact_num;
        public CabDetails()
        {

        }

        public int Book_ref_num
        {
            get
            {
                return book_ref_num;
            }

            set
            {
                book_ref_num = value;
            }
        }

        public string Pass_name
        {
            get
            {
                return pass_name;
            }

            set
            {
                pass_name = value;
            }
        }

        public DateTime Dep_time
        {
            get
            {
                return dep_time;
            }

            set
            {
                dep_time = value;
            }
        }

        public double Loc_dist
        {
            get
            {
                return loc_dist;
            }

            set
            {
                loc_dist = value;
            }
        }

        public double Amount
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

        public string Cab_type
        {
            get
            {
                return cab_type;
            }

            set
            {
                cab_type = value;
            }
        }

        public long Contact_num
        {
            get
            {
                return contact_num;
            }

            set
            {
                contact_num = value;
            }
        }

        public string From_loc
        {
            get
            {
                return from_loc;
            }

            set
            {
                from_loc = value;
            }
        }

        public string To_loc
        {
            get
            {
                return to_loc;
            }

            set
            {
                to_loc = value;
            }
        }

        public CabDetails( string pass_name,string from_loc, DateTime dep_time,string to_loc, double loc_dist, double amount, string cab_type, long contact_num)
        {
            this.book_ref_num =autogen++;
            this.Pass_name = pass_name;
            this.from_loc=from_loc;
            this.Dep_time = dep_time;
            this.to_loc=to_loc;
            this.Loc_dist = loc_dist;
            this.Amount = amount;
            this.Cab_type = cab_type;
            this.Contact_num = contact_num;

        }

       public CabDetails(string from_loc,double loc_dist, DateTime dep_time, string to_loc)
        {
            this.from_loc = from_loc;
            this.loc_dist = loc_dist;
            this.dep_time = dep_time;
            this.to_loc = to_loc;

        }
    }
}
