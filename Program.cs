using System.Linq.Expressions;
using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpCheck empcheck = new EmpCheck();
            EmpCheck.Attendance();

            DailyWage empcheckk = new DailyWage();
            DailyWage.EmpWage();

            PartTime empcheckkk = new PartTime();
            PartTime.EmpWagePart();
            Console.ReadLine();

            Switchcase emppcheck = new Switchcase();
            Switchcase.SwitchCase();
        }
    }
}