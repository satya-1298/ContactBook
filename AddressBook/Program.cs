﻿using System;
using System.Collections;
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressProgram contact = new AddressProgram();
            contact.details();
            contact.deleteContact();
        }
    }
}