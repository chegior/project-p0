using System;
using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
    public class Store
    {
        //
        public List<Order> Orders {get;set;}
        public void CreateOrder()
        {
           Orders.Add(new Order());
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
            finally  // only wont work on OS Issue and Hardware doesnt 
            {
                GC.Collect();
                
                //GarbageCollection, cant be invoked
                // level1 clean quickly
                // level2 when its needes
                // level3 barely
            }   
            
            
           
        }
    }
}