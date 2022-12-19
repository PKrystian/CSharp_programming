using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Menu<T>
    {
        public string _typeofmeal, _fullname;
        public float _price { set; get ;}
        T[] arrayT = null;
        int i = 6;
        public Menu(string typeofmeal = "", string fullname = "", float price = 0, int _size)
        {
            _typeofmeal = typeofmeal;
            _fullname = fullname;
            _price = price;
            arrayT = new T[_size];
        }
        public bool isEmpty()
        {
            if (i == 0)
            {
                return true;
            }
            return false;
        }
        public virtual string GetFullName()
        {
            return _typeofmeal + " " + _fullname + " \t " + _price;
        }
        public virtual string Print()
        {
            return " " + "  " + GetFullName();
        }
        public void Sort()
        {
            Array.Sort(array, 0, i);
        }
    }
    class Main_Meal : Menu
    {
        public Main_Meal(string typeofmeal, string fullname, float price)
        {
            _typeofmeal = typeofmeal;
            _fullname = fullname;
            _price = price;
        }
        public override string Print()
        {
            return "Main Meal \n" + "  " + GetFullName();
        }
    }
    class Extras : Menu
    {
        public Extras(string typeofmeal, string fullname, float price)
        {
            _typeofmeal = typeofmeal;
            _fullname = fullname;
            _price = price;
        }
        public override string Print()
        {
            return "Extra \n" + "  " + GetFullName();
        }
    }
    class Drinks : Menu
    {
        public Drinks(string typeofmeal, string fullname, float price)
        {
            _typeofmeal = typeofmeal;
            _fullname = fullname;
            _price = price;
        }
        public override string Print()
        {
            return "Drink \n" + " " + GetFullName();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu[] array = 
            {
                new Main_Meal("Sandwich","meat",20),
                new Extras("Fries","with ketchup",5),
                new Drinks("Cola","cold",14),
                new Main_Meal("SBurger","vege",23),
                new Extras("Chips","with nothing",7),
                new Drinks("Tea","hot",11)
            };
            Console.WriteLine("Type of meal \t" + " " + "Name \t" + " " + "Price");
            foreach (Menu menus in array)
            {
                Console.WriteLine(menus.Print());
            }
            // array.Sort();
            // foreach (Menu menus in array)
            // {
            //     Console.WriteLine(menus.Print());
            // }
        }
    }
}
