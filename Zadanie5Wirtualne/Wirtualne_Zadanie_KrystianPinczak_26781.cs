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

namespace KlasyWirtualne
{
    class Employer
    {
        public string _name, _surname;
        public float _salary { set; get ;}
        public Employer(string name = "", string surname = "", float salary = 0)
        {
            _name = name;
            _surname = surname;
            _salary = salary;
        }
        public virtual string FullName()
        {
            return _name + " " + _surname + " \t|\t " + _salary;
        }
        public virtual string Position()
        {
            return " |\t " + " " + " \t|\t " + FullName();
        }
    }
    class President : Employer
    {
        public President(string name, string surname, float salary)
        {
            _name = name;
            _surname = surname;
            _salary = salary;
        }
        public override string Position()
        {
            return " |\t " + "President" + " \t|\t " + FullName();
        }
    }
    class Accountant : Employer
    {
        public Accountant(string name, string surname, float salary)
        {
            _name = name;
            _surname = surname;
            _salary = salary;
        }
        public override string Position()
        {
            return " |\t " + "Accountant" + " \t|\t " + FullName();
        }
    }
    class Engineer : Employer
    {
        public Engineer(string name, string surname, float salary)
        {
            _name = name;
            _surname = surname;
            _salary = salary;
        }
        public override string Position()
        {
            return " |\t " + "Engineer" + " \t|\t " + FullName();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employer[] array = 
            {
                new President("Jan","Kowalski",2000),
                new Accountant("Kuba","Nowak",5000),
                new Engineer("Marek","Urban",14300),
                new President("Mucha","Epok",20400),
                new Accountant("Hubert","Wers",3000),
                new Engineer("Nilo","Jehgli",1300)
            };
            Console.WriteLine(" |\t " +  "Position" + "\t| \t" + "Full Name" + "\t| \t" + "Salary");
            Console.WriteLine(" |\t " +  "\t" + "\t| \t" + "\t" + "\t| \t" + "\t");
            foreach (Employer employer in array)
            {
                Console.WriteLine(employer.Position());
            }
        }
    }
}
