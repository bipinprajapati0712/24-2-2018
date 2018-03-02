using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABBOOKING
{
    class Program
    {
        static void Main(string[] args)
        {
            int book_ref_num;
            string pass_name = "";
            string from_loc = "";
            DateTime dep_time = DateTime.Now;
            string to_loc = "";
            double loc_dist = 0;
            double amount = 0;
            double amt_perkm = 45;
            string cab_type = "";
            long contact_num = 0;
            int choice = 0;
            int flag = 0;
            List<ICabDetails> p = new List<ICabDetails>();
            IcabOperation nu = new CabOperation();

            do
            {
                Console.WriteLine("1. Book a Cab");
                Console.WriteLine("2. View Booking Details for the specific Booking Reference Number ");
                Console.WriteLine("3. Update From Location, To Location, Departure Time");
                Console.WriteLine("4. Cancel the Booking by the  Booking Reference Number ");
                Console.WriteLine("enter your choice");
                do
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        flag = 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("invalid choice:" + e.Message);
                        flag = 0;
                    }
                } while (flag == 0);
                switch (choice)
                {
                    case 1:
                        // Passenger Name, From Location, Departure Time, To Location, Distance in Km, Rental Amount Per Km,
                        //Cab Type ,Cab Contact Number
                        Console.WriteLine("enter passenger name");
                        pass_name = Console.ReadLine();
                        Console.WriteLine("enter the pickup location");
                        from_loc = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("enter the departure time");
                            flag = 0;
                            try
                            {
                                dep_time = Convert.ToDateTime(Console.ReadLine());
                                flag = 1;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("invalid time:" + e.Message);
                                flag = 0;
                            }
                        } while (flag == 0);
                        Console.WriteLine("enter drop location");
                        to_loc = Console.ReadLine();
                        do
                        {
                            flag = 0;
                            Console.WriteLine("enter distance from pickup location and drop location");
                            try
                            {
                                loc_dist = Convert.ToDouble(Console.ReadLine());
                                flag = 1;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("invalid distance" + e.Message);
                                flag = 0;
                            }
                        } while (flag == 0);


                        amount = amt_perkm * loc_dist;
                        Console.WriteLine("estimate amount=" + amount);
                        do
                        {
                            Console.WriteLine("enter type of cab");
                            cab_type = Console.ReadLine();
                            if (cab_type.Equals("mini") || (cab_type.Equals("large")))
                            {
                                flag = 1;
                            }
                            else
                            {
                                Console.WriteLine("enter proper choice of cab");
                                flag = 0;
                            }
                        } while (flag == 0);
                        ICabDetails pu = new CabDetails(pass_name, from_loc, dep_time, to_loc, loc_dist, amount, cab_type, contact_num);
                        book_ref_num = nu.book_cab(pu);
                        Console.WriteLine("booking id=" + book_ref_num);
                        break;

                    case 2:

                        do
                        {

                            Console.WriteLine("enter booking reference number");
                            List<ICabDetails> cola = new List<ICabDetails>();


                           book_ref_num = Convert.ToInt32(Console.ReadLine());

                            cola = nu.view_by_refnum(book_ref_num);
                            Console.WriteLine("id is" + book_ref_num);
                            foreach (ICabDetails k in cola)
                            {
                                Console.WriteLine("type of cab:" + k.Cab_type);
                                Console.WriteLine("contact no:" + k.Contact_num);
                                Console.WriteLine("passenger name:" + k.Pass_name);
                                Console.WriteLine("pickup location:" + k.From_loc);
                                Console.WriteLine("drop location:" + k.To_loc);
                                Console.WriteLine("location distance:" + k.Loc_dist);
                                Console.WriteLine("estimated cost:" + k.Amount);
                                Console.WriteLine("departure time:" + k.Dep_time);

                            }
                        } while (flag == 0);

                        break;
                        case 3:
                        List<ICabDetails> obj = new List<ICabDetails>();
                        List<ICabDetails> obj=
                        break;
                }
            } while (choice < 5);
        }
    }
}
