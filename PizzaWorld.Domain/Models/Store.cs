using System;
using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
    public class Store
    {
        //
        public List<Order> Orders {get;set;}
        void CreateOrder()
        {
            var o = new Order();
        }

        bool DeleteOrder(Order order)
        {
            try
            {
                Orders.Remove(order);
                return true;
            }
            catch 
            {
                return false;        
            }
            finally
            {
                GC.Collect();
                //GarbageCollection, cant be invoked
                // level1 clean quickly
                // level2 when its needes
                // level3 barely
            }   // only wont work on OS Issue and Hardware doesnt 
        }
    }
}