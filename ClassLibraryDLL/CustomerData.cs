using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDLL
{
    public class CustomerData
    {
        int customerId { get; set; }
        string customerName { get; set; }
        string city { get; set; }
        long mobileNo { get; set; }
        int age { get; set; }
        int units { get; set; }
        int perUnitCost { get; set; } = 10;
        int totalCost { get; set; }
        string paidOrNot { get; set; }

        List<CustomerData> myList = new List<CustomerData>();
        public void StoreInTable()
        {
            myList.Add(new CustomerData
            {
                customerId = 01,
                customerName = "Yuvraj Singh",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 02,
                customerName = "Vikas",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 03,
                customerName = "Raman",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 04,
                customerName = "Ashu",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 05,
                customerName = "Anubhav",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 06,
                customerName = "Abhinav Singh",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 07,
                customerName = "Raj",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 08,
                customerName = "Rohit Kumar",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 09,
                customerName = "Harsh Parmar",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Paid"
            });
            myList.Add(new CustomerData
            {
                customerId = 10,
                customerName = "Rahul Singh",
                city = "Gurugram",
                mobileNo = 954545861,
                age = 21,
                units = 100,
                totalCost = units * perUnitCost,
                paidOrNot = "Not Paid"
            });
        }
        public void ShowCustomerDetails(int iD)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (iD == myList[i].customerId)
                {
                    Console.WriteLine(myList[i].customerId + " " + myList[i].customerName + " " + myList[i].city + " " + myList[i].mobileNo + " "
                        + myList[i].age);
                    break;
                }
            }
            return;
        }
        public void ShowEBill(int iD)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (iD == myList[i].customerId)
                {
                    Console.WriteLine(myList[i].units + " " + myList[i].totalCost);
                    break;
                }
            }
            return;
        }
        public void ShowEBillReport()
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i].customerId + " " + myList[i].customerName + " " + myList[i].city + " " + myList[i].mobileNo + " "
                        + myList[i].age + myList[i].units + " " + myList[i].totalCost + " " + myList[i].paidOrNot);
            }
            return;
        }
    }

}