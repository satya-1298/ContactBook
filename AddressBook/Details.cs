﻿using System;
using System.Collections;
using System.Linq;
using System.Net;
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
                Console.Write("Enter phone number: ");
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
                Console.WriteLine("Edit by using First Name: ");
                String name = Console.ReadLine();
                foreach (var data in list)
                {
                    if (data.firstname == name)
                    {
                       // Console.WriteLine("Enter option to edit:\n1.First Name\n2.Second Name\n3.Address\n4.city\n5.state\n6.phone number\n7.email");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter first name ");
                                data.firstname = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter last name ");
                                data.lastname = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter address");
                                data.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter city");
                                data.city = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter state");
                                data.state = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter phne number");
                                data.phoneNo = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter email");
                                data.eMail = Console.ReadLine();
                                break;
                        }
                        Console.WriteLine(address.firstname + "\n" + address.lastname + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNo + "\n" + address.postcode + "\n" + address.country + "\n" + address.eMail);
                        
                    }

                }

            }
        }
    }
}