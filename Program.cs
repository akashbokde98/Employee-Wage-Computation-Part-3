using System;

namespace EmployeeWage
{
    internal class Program
    {
        Random randomNum = new Random();
        int wagePerHour;
        int fullDayHour;
        int partTimeHour;
        int totalWorkingDay;
        int totalWorkingHour;
        int dailyEmpWage;


        public Program(int wage, int fullday, int parttime, int totalworkday, int totalhour, int iniVal)
        {
            wagePerHour = wage;
            fullDayHour = fullday;
            partTimeHour = parttime;
            totalWorkingDay = totalworkday;
            totalWorkingHour = totalhour;
            dailyEmpWage = iniVal;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program!");

            Program obj1 = new Program(20, 8, 4, 0, 0, 0);
            int wageForMonth = obj1.EmployeeWage();
            Console.WriteLine("Total Working Hour is " + obj1.totalWorkingHour);
            Console.WriteLine("Total Working Days is " + obj1.totalWorkingDay);
            Console.WriteLine("Wages For a Month is " + wageForMonth);
        }
        public int EmployeeWage()
        {
            int totalWage = 0;
            int day = 1;
            while (day <= 30 && totalWorkingDay <= 20 && totalWorkingHour < 100)
            {
                switch (randomNum.Next(0, 3))
                {
                    case 1:
                        dailyEmpWage = wagePerHour * fullDayHour;
                        totalWorkingDay++;
                        totalWorkingHour += fullDayHour;
                        break;

                    case 2:
                        dailyEmpWage = wagePerHour * partTimeHour;
                        totalWorkingDay++;
                        totalWorkingHour += partTimeHour;
                        break;

                    default:
                        break;
                }
                totalWage += dailyEmpWage;
                day++;
            }
            return totalWage; 
        }
    }
}
