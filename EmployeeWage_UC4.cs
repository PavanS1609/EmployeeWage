using System;

// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

class EmployeeWage_UC4
{
    static void Main(String[] args)
    {
        const int emp1_present = 1;
        const int emp1_parttime = 2;
        int emp1wage_perhour = 20;
        int emp1_hours = 0;
        Random r = new Random();
        int emp1_availability = r.Next(0, 3);
        switch (emp1_availability)
        {
            case emp1_present:
                emp1_hours = 6;
                break;

            case emp1_parttime:
                emp1_hours = 3;
                break;
            default:
                emp1_hours = 0;
                break;
        }
        int emp1_dailywages = emp1_hours * emp1wage_perhour;
        Console.WriteLine("Dailywage for the employee :" + emp1_dailywages);

    }
}
