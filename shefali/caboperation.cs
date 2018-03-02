using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABBOOKING
{
    class CabOperation : IcabOperation
    {
        ICabDetails d = new CabDetails();
        static List<ICabDetails> lst = new List<ICabDetails>();
        public int book_cab(ICabDetails obj)
        {
            lst.Add(obj);
            return obj.Book_ref_num;
        }
        public List<ICabDetails> view_by_refnum(int ref_num)
        {
            List<ICabDetails> r = new List<ICabDetails>();
            foreach (ICabDetails k in lst)
            {
                if (ref_num==k.Book_ref_num)
                {
                    r.Add(k);
                }

            }
            return r;
        }

         public List<ICabDetails>update(int ref_num,string to_loc,string from_loc,double dist)
        {
            foreach(ICabDetails k in lst)
            {
                if(k.Book_ref_num==ref_num)
                {
                    k.To_loc = to_loc;
                    k.From_loc = from_loc;
                    k.Loc_dist = dist;
                    k.Amount = dist * 45;
                }
            }
            return lst;
        }
        //Passenger Name,From Location, Departure Time, To Location, Distance in Km, Rental Amount Per Km, Cab Type ,Cab Contact Number. 
    }
}
