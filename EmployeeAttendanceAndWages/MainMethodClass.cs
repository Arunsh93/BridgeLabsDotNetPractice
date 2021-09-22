using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceAndWages
{
    class MainMethodClass
    {
        static void Main(string[] args)
        {
            UC1_PresentOrAbsent.CheckEmp();
            UC2_CalculateWages.DailyWages();
            UC3_AddPartTimeEmp.AddPartTimeEmp();
            UC4_EmpWageUsingSwitchCase.EmpWageUsingSwitchCase();
            UC5_EmpWagesWorkingInMonth.EmpWagesWorkingInMonth();
        }
    }
}
