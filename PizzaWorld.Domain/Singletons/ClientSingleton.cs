using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.IO;
using System;

using PizzaWorld.Domain.Models;


namespace PizzaWorld.Domain.Singlentons
{
    public class ClientSingleton 
    {
        private const  string _path = @"./pizzaworld.xml"; //@ symbol, this is literal operator, ignore an take it as face value
        //Static only one instance but that value can change
        //Const the value can never change

        private static ClientSingleton _instance;
        public static ClientSingleton Instance{
            get
            {
                if(_instance == null)
                {
                    _instance = new ClientSingleton();
                }
                return _instance;
            }

            
        }   
        public List<Store> Stores {get;set;}
        private ClientSingleton()
        {
            Read();

        }

        
        public void MakeStore()
        {
            Stores.Add(new Store());
            Save();
        }

        public Store SelectStore()
        {

            int.TryParse(Console.ReadLine(), out int input); 
            return Stores.ElementAtOrDefault(input); //Unique property, the user makes the right info
        }

        private void Save()
        {
      
            var file = new StreamWriter(_path);
            // serialization means convert Objects to TextFiles'
            var xml = new XmlSerializer(typeof(List<Store>));//be able to code and encode
        
            xml.Serialize(file, Stores);

        }

        private void Read()
        {
            if(!File.Exists(_path))
            {
                Stores = new List<Store>();
            }
            var file = new StreamReader(_path);
            var xml = new XmlSerializer(typeof(List<Store>));
            //EXPLICIT CONVERSION      
            Stores = xml.Deserialize(file) as List<Store>;//Null if cant Conver
            //Stores = (List<Store)xml.Deserialize(file);//Exception Cast Exception8

                
            
        }
    }
}