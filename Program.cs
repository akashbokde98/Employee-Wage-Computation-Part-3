using System;

namespace EmployeeWage
{
    internal class Program
    {
        Random randomNum = new Random();
        int wagePerHour;
        int fullDayHour;
        int partTimeHour;
        int dailyEmpWage;


        public Program(int wage, int fullday, int parttime, int iniVal)
        {
            wagePerHour = wage;
            fullDayHour = fullday;
            partTimeHour = parttime;
            dailyEmpWage = iniVal;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program!");

            Program obj1 = new Program(20, 8, 4, 0);
            obj1.AttendanceCheck();
        }
        public void AttendanceCheck()
        {
            int isPresent = randomNum.Next(0, 3);
            if (isPresent == 1)
            {
                dailyEmpWage = wagePerHour * fullDayHour;
                Console.WriteLine("Employee is Present and Wage is " + dailyEmpWage);
            }
            else if (isPresent == 2)
            {
                dailyEmpWage = wagePerHour * partTimeHour;
                Console.WriteLine("Employee is Present Half Day and Wage is " + dailyEmpWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent and Wage is " + dailyEmpWage);
            }
        }
    }
}
