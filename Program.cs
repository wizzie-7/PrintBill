/*Take the units(programology) consumed
Accordingly calculate amt
for 1st 100 units @ 1Rs.(any currency)/unit
for next 100 units @ 2 Rs./unit
for next 100 units @ 3 Rs./unit
for next 200 units @ 4 Rs./unit
for next units @ 5 Rs./unit
tax to be added in final amount @ 10%.
Meter charge 50 Rs. extra.
Print the bill….

 Take input from user how many bils you have to print
 */




using System;


namespace PrintBill
{
    public class calculation
    {
        int unit = 0;
        int ammount = 0;
        double tax = 0;
        double finalAmount = 0;
        string cname;
        int cnum;
        public void AcceptData()
        {
            Console.WriteLine("Welcome to Electricity board");
            Console.WriteLine("Entere your name :");
            cname = Console.ReadLine();
            Console.WriteLine("Enter your consumer number");
            cnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your units");
            unit = Convert.ToInt32(Console.ReadLine());
        }
        public void CalBill()
        {                                                         //use of nested if
            if (unit <= 100)
            {
                ammount = unit * 1;
            }
            else if (unit > 100 && unit <= 200)
            {
                ammount = ((unit - 100) * 2) + 100;
            }
            else if (unit > 200 && unit <= 300)
            {
                ammount = ((unit - 200) * 3) + 300;
            }
            else if (unit > 300 && unit <= 500)
            {
                ammount = ((unit - 300) * 4) + 600;
            }
            else
            {
                ammount = ((unit - 500) * 5) + 1400;
            }

            tax = ammount * 0.1;
            finalAmount = ammount + tax + 50;
        }
        public void printBill()
        {
            Console.WriteLine("Consumer number : " + cnum);
            Console.WriteLine("Consumer number : " + cname);
            Console.WriteLine("Your Units : " + unit);
            Console.WriteLine("Your electricity bill is :" + finalAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculation cal = new calculation();
            int times;
            int i = 0;
            Console.WriteLine("Enter the Numbers of bill you have to generate :");
            times = Convert.ToInt32(Console.ReadLine());
            while(i <= times)                                  //use of while loop
            {
                //cal.AcceptData();
                cal.CalBill();
                cal.printBill();
                i++;
            }             
        }
    }
}
