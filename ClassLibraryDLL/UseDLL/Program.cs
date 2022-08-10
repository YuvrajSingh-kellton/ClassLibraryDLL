﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDLL;

// -------------------------------------I have stored information of 10 customers from ID 01 to 10----------------------------------------- //

namespace ClassLibraryDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerData customerDataobj = new CustomerData();
            customerDataobj.StoreInTable();
        TOP:
            Console.WriteLine("1. ShowCustomerDetails");
            Console.WriteLine("2. ShowEBill");
            Console.WriteLine("3. ShowEBillReport For all customers");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Write("Enter Customer Id - ");
                    customerDataobj.ShowCustomerDetails(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Enter Customer Id - ");
                    customerDataobj.ShowEBill(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 3:
                    customerDataobj.ShowEBillReport();
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    goto TOP;
            }
        }
    }
}