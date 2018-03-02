using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABBOOKING
{
    interface IcabOperation
    {
        //Booking Reference Number Passenger Name From Location Departure Time To Location Distance in Km Estimated Amount Cab Type Cab Contact Number
        int book_cab(ICabDetails obj);
        List<ICabDetails> view_by_refnum(int ref_num);
        List<ICabDetails> update(int ref_num, string to_loc, string from_loc, double dist);

    }
}
