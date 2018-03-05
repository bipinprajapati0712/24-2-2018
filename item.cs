using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class Item
    {
        int item_num;
        int a = 1;
        string item_name;
        string category;
        double price_per_unit;

        public int Item_num
        {
            get
            {
                return item_num;
            }

            set
            {
                item_num = value;
            }
        }

        public string Item_name
        {
            get
            {
                return item_name;
            }

            set
            {
                item_name = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public double Price_per_unit
        {
            get
            {
                return price_per_unit;
            }

            set
            {
                price_per_unit = value;
            }
        }

        public Item( string item_name, string category, double price_per_unit)
        {
            this.Item_num = a++;
            this.Item_name = item_name;
            this.Category = category;
            this.Price_per_unit = price_per_unit;
        }
        public Item()
        {
          
        }
    }
}
