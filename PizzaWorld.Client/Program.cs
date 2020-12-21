using System;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singlentons;

namespace PizzaWorld.Client
{
    class Program
    {
        private readonly static ClientSingleton _client = ClientSingleton.Instance;

        static void Main(string[] args)
        {
           UserView();
        }

        static void PrintAllStores()
        {
           foreach(var store in _client.Stores) 
           {
               System.Console.WriteLine(store);
           }
        }

        static void UserView()
        {
            var user = new User();

            PrintAllStores(); 
            user.SelectedStore = _client.SelectStore();
            user.SelectedStore.CreateOrder();
            user.Orders = user.SelectedStore.Orders;
            user.Orders.Add(user.SelectedStore.Orders.Last());


            user.Orders.Last().MakeMeatPizza();
            user.Orders.Last().MakeMeatPizza();

            System.Console.WriteLine(user);

        }
    }
}
