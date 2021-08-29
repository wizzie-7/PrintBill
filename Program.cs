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
using BillCal;

namespace PrintBill
{
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
                cal.AcceptData();
                cal.CalBill();
                cal.printBill();
                i++;
            }             
        }
    }
}
