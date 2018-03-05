using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class Order
    {
        int order_id;
        int autogen_id = 1000;
       int item_id;
        DateTime order_date;
        double amount;

        public int Order_id
        {
            get
            {
                return order_id;
            }

            set
            {
                order_id = value;
            }
        }

        public int Autogen_id
        {
            get
            {
                return autogen_id;
            }

            set
            {
                autogen_id = value;
            }
        }

        public int Item_id
        {
            get
            {
                return item_id;
            }

            set
            {
                item_id = value;
            }
        }

        public DateTime Order_date
        {
            get
            {
                return order_date;
            }

            set
            {
                order_date = value;
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

        public Order( int item_id)
        {
            this.Order_id = autogen_id++;
            this.Item_id = item_id;
            this.Order_date =DateTime.Now;
        }
        public Order()
        {
            this.Order_id = autogen_id++;
        }
    }
}
