using System;

// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
class EmployeeWage_UC8

{

    const int emp1_present = 1;
    const int emp1_parttime = 2;
    const int emp1wage_perhour = 20;
    //const int emp1_hours = 0;
    // const int emp1_workingdays = 20;
    public static int EmpWage(String Company, int emp1wage_perhour, int emp1_workingdays)
    {
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
        int emp1_dailywages = emp1_hours * emp1wage_perhour * emp1_workingdays;
        Console.WriteLine("Dailywage for the employee :" + Company + " " + emp1_dailywages);
        return emp1_dailywages;
    }
    static void Main(String[] args)
    {
        EmpWage("PRFoods", 20, 20);
        EmpWage("PRFinance", 30, 20);
    }
}


