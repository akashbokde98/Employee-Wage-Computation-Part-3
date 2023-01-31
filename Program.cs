using System;

namespace EmployeeWage
{
    internal class Program
    {
        Random randomNum = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program!");

            Program obj1 = new Program();
            obj1.AttendanceCheck();
        }
        public void AttendanceCheck()
        {
            int isPresent = randomNum.Next(0, 2);
            if (isPresent == 1)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }
        }
    }
}
