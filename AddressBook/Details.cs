using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace AddressBook
{
    public class AddressProgram
    {
        
        public void details()
        {

            List<Address> list = new List<Address>();

            {
                Address address = new Address();
                Console.Write("Enter firstName: ");
                address.firstname = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                address.lastname = Console.ReadLine();
                Console.Write("Enter Address: ");
                address.address = Console.ReadLine();
                Console.Write("Enter city: ");
                address.city = Console.ReadLine();
                Console.Write("Enter state: ");
                address.state = Console.ReadLine();
                Console.Write("Enter phone umber: ");
                address.phoneNo = Console.ReadLine();
                Console.Write("Enter postcode: ");
                address.postcode = Console.ReadLine();
                list.Add(address);
                Console.Write("Enter Country: ");
                address.country = Console.ReadLine();
                list.Add(address);
                Console.Write("Enter email: ");
                address.eMail = Console.ReadLine();
                list.Add(address);
                Console.WriteLine(address.firstname + "\n" + address.lastname + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNo + "\n" + address.postcode + "\n" + address.country + "\n" + address.eMail);
            }
        }

    }
            //void displayContact()
            //{
            //    foreach (var address in list)
            //    {
            //        Console.WriteLine(address.firstname + "\n" + address.lastname + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNo + "\n" + address.postcode + "\n" + address.country + "\n" + address.eMail);
            //    }
            //}





   


    

}   

