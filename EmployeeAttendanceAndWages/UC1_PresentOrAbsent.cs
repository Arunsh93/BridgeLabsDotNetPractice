using System;

namespace EmployeeAttendanceAndWages
{
    class UC1_PresentOrAbsent
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            
            int is_Full_Time = 1;
            Random random = new Random();
            int result = random.Next(0, 2);

            if (result == is_Full_Time)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
