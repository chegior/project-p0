using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;


using PizzaWorld.Domain.Models;


namespace PizzaWorld.Domain.Singlentons
{
    public class ClientSingleton 
    {
        private static ClientSingleton _instance;
        public static ClientSingleton Instance{
            get
            {
                if(_instance == null){
                    _instance = new ClientSingleton();
                }
                return _instance;
            }
        }   
        public List<Store> Stores {get;set;}
        private ClientSingleton()
        {
            Stores = new List<Store>();
        }

        
        public void MakeStore()
        {
            var s = new Store();
            Stores.Add(s);
            Save();
        }

        private void Save()
        {
            string path = @"./pizzaworld.xml";
            var file = new StreamWriter(path);
            // serialization means convert Objects to TextFiles'
            var xml = new XmlSerializer(typeof(List<Store>));

            xml.Serialize(file, Stores);

        }
    }
}