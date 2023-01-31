using System;

namespace EmployeeWage
{
    internal class Program
    {
        Random randomNum = new Random();
        int wagePerHour;
        int fullDayHour;
        int dailyEmpWage;

        public Program(int wage, int fullday, int iniVal)
        {
            wagePerHour = wage;
            fullDayHour = fullday;
            dailyEmpWage = iniVal;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program!");

            Program obj1 = new Program(20, 8, 0);
            obj1.AttendanceCheck();
            Console.WriteLine(obj1.dailyEmpWage);
        }
        public void AttendanceCheck()
        {
            int isPresent = randomNum.Next(0, 2);
            if (isPresent == 1)
            {
                dailyEmpWage = wagePerHour * fullDayHour;
                Console.WriteLine("Employee is Present and Wage is " + dailyEmpWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent and Wage is " + dailyEmpWage);
            }
        }
    }
}
