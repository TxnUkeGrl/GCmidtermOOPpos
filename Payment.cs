using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class Payment : ItemProperties
    {
        public double Cash { get; set; }
        public double Change { get; set; }
        public int CheckNumber { get; set; }
        public int CCNumber { get; set; }
        public DateTime Expiration { get; set; }
        public int CCcvv { get; set; }

        public Payment() { }

        //public Payment()
        //{
        //    Grandtotal = grandtotal;
        //    Cash = cash;
        //    Change = change;

        //}

        public Payment(double subtotal, double grandtotal, double cash, double change, int checkNumber, int ccNumber, DateTime expiration, int CVV)
        {
            Subtotal = subtotal;
            Grandtotal = grandtotal;
            Cash = cash;
            Change = change;
            CheckNumber = checkNumber;
            CCNumber = ccNumber;
            Expiration = expiration;
            CCcvv = CVV;
        }

        public void GetPaymentType() //string, int - what to search by?
        {
            Console.WriteLine("Cash, Check, or Credit Card?");
            if (Console.ReadLine().ToUpper() == "CASH") // case? also use int menu selection
            {
                Console.WriteLine("How much cash do you have?");
                Cash = double.Parse(Console.ReadLine());
                Change = Cash - Grandtotal;
                //return Change;
            }
            else if (Console.ReadLine().ToUpper() == "CHECK")
            {
                Console.WriteLine("check #?");
                CheckNumber = int.Parse(Console.ReadLine());
            }
            else if (Console.ReadLine().ToUpper() == "CREDIT CARD")
            {
                Console.WriteLine("CC#?");
                CCNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("expiration?");
                Expiration = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("CVV?");
                CCcvv = int.Parse(Console.ReadLine());
            }
        }

        public double GetCashChange()
        {
            Change = Cash - Grandtotal;
            return Change;
        }
    }
}
