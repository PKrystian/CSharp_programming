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
namespace Example6GenericTypes
{
    public class Reservation
    {
        public int Index { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Room { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<Reservation> clients = new Queue<Reservation>();
            clients.Enqueue(new Reservation() { Index = 1, Firstname = "Jakub", Lastname = "Nowak", Room = 300});
            clients.Enqueue(new Reservation() { Index = 2, Firstname = "Filip", Lastname = "Kowal", Room = 201});
            clients.Enqueue(new Reservation() { Index = 3, Firstname = "Jan", Lastname = "Polur", Room = 32});
            clients.Enqueue(new Reservation() { Index = 4, Firstname = "Malgorzata", Lastname = "Monaj", Room = 122});

            Console.WriteLine("Total clients in system: {0}", clients.Count);
            Console.WriteLine("Actual list of hotel clients in queue: ");
            foreach (Reservation client in clients)
            {
                Console.WriteLine("{0} | {1} {2} | Room: {3}", client.Index, client.Firstname, client.Lastname, client.Room);
            }
            Console.WriteLine("First client to leave is: {0} {1}", (clients.Peek()).Firstname, (clients.Peek()).Lastname);
            Reservation client_to_leave = clients.Dequeue();
            Console.WriteLine("Client {0} {1} left the hotel", client_to_leave.Firstname, client_to_leave.Lastname);
            foreach (Reservation client in clients)
            {
                Console.WriteLine("{0} | {1} {2} | Room: {3}", client.Index, client.Firstname, client.Lastname, client.Room);
            }
            string client_to_find = "Jan";
            //Console.WriteLine("Is client: {0}, still in system: {1}", client_to_find, (clients.Contains(client_to_leave)));
            Console.WriteLine("List of clients after sorting");
            Queue<Reservation> sortedclients = new Queue<Reservation>(clients.OrderBy(z => z));
            Console.WriteLine("List of clients after sorting");
            foreach (Reservation client in sortedclients)
            {
                Console.WriteLine("{0} | {1} {2} | Room: {3}", client.Index, client.Firstname, client.Lastname, client.Room);
            }
        }
    }
}