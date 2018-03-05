hotel//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class Hotel:IHotel
    {
      static  List<Item> obj = new List<Item>();
       static List<Order> kobj = new List<Order>();
        Item t = new Item();
        public int add_item(Item t)
        {
            obj.Add(t);
            return t.Item_num;
        }
        public List<Item> view_all()
        {
            return obj;  
        }
        public double update(string iname,double price_perunit)
        {
            foreach(Item k in obj)
            {
                if(k.Item_name.Equals(iname))
                {
                    k.Price_per_unit = price_perunit;
                }
            }
           return price_perunit;
        }
        public int order_book(int itemno)
        {
          
            foreach(Item k in obj)
            {
                if(k.Item_num==itemno)
                {
                    Order d = new Order();
                    d.Amount = k.Price_per_unit;
                    d.Order_date = DateTime.Now;
                    d.Item_id = itemno;
                    kobj.Add(d);
                    return d.Order_id;
                }
            }
            return 0;
        }
        public List<Order> view_order()
        {
            return kobj;
        }
        public bool cancel_order(int oid)
        {
            foreach(Order k in kobj)
            {
                if(k.Order_id==oid)
                {
                    kobj.Remove(k);
                }
               
                
            }
            return true;
        }
    }
}

