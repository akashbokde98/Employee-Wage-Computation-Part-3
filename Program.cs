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
        int dailyEmpWage;


        public Program(int wage, int fullday, int parttime, int totalworkday, int iniVal)
        {
            wagePerHour = wage;
            fullDayHour = fullday;
            partTimeHour = parttime;
            totalWorkingDay = totalworkday;
            dailyEmpWage = iniVal;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program!");

            Program obj1 = new Program(20, 8, 4, 0, 0);
            int wageForMonth = obj1.AttendanceCheck();
            Console.WriteLine("Wages For a Month is " + wageForMonth);
        }
        public int AttendanceCheck()
        {
            int totalWage = 0;
            int day = 1;
            while (day <= 30 && totalWorkingDay <= 20)
            {
                switch (randomNum.Next(0, 3))
                {
                    case 1:
                        dailyEmpWage = wagePerHour * fullDayHour;
                        //Console.WriteLine("Employee is Present and Wage is " + dailyEmpWage);
                        totalWorkingDay++;
                        break;

                    case 2:
                        dailyEmpWage = wagePerHour * partTimeHour;
                        //Console.WriteLine("Employee is Present Half Day and Wage is " + dailyEmpWage);
                        totalWorkingDay++;
                        break;

                    default:
                        //Console.WriteLine("Employee is Absent and Wage is " + dailyEmpWage);
                        break;
                }
                totalWage += dailyEmpWage;
                day++;
            }
            return totalWage; 
        }
        /*void TotalEmpWage()
        {
            
        }*/
    }
}
