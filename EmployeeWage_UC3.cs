using System;


class EmployeeWage_UC3
{
    static void Main(String[] args)
    {
        int emp1_present = 1;
        int emp1_parttime = 2;
        int emp1wage_perhour = 20;
        Random r = new Random();
        int emp1_availability = r.Next(0, 3);
        if (emp1_availability == emp1_present)
        {
            int emp_hours = 6;
            int emp1wage_perday = emp1wage_perhour * emp_hours;
            Console.WriteLine("Employee is presnt");
            Console.WriteLine("Employee daily wage is :" + emp1wage_perday);
        }
        else if (emp1_availability == emp1_parttime)
        {
            int emp_hours = 3;
            int emp1wage_perday = emp1wage_perhour * emp_hours;
            Console.WriteLine("Employee is present part time");
            Console.WriteLine("Employee daily wage is :" + emp1wage_perday);


        }
        else
        {
            int emp_hours = 0;
            int emp1wage_perday = emp1wage_perhour * emp_hours;
            Console.WriteLine("Employee is absent ");
            Console.WriteLine("Employee dailywage is :" + emp1wage_perday);

        }
    }
}

