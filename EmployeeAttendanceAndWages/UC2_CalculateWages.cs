using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceAndWages
{
    class UC2_CalculateWages
    {
        public static void DailyWages()
        {
            //Variables
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 8;
            int empWages = 0;

            //Computation
            empWages = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wages : " + empWages);

        }
    }
}
