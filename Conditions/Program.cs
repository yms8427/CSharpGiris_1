using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Project();
            p1.name = "Hayat Eve Sığar";
            p1.startDate = new DateTime(2020, 3, 10);
            p1.plannedWorkDay = 120;

            var p2 = new Project();
            p2.name = "Evde Kal";
            p2.startDate = new DateTime(2020, 4, 3);
            p2.plannedWorkDay = 180;

            var p3 = new Project();
            p3.name = "Evde Kalma";
            p3.startDate = new DateTime(2020, 4, 3);
            p3.plannedWorkDay = 0;

            CheckProject(p1);
            CheckProject(p2);
            CheckProject(p3);

            Console.ReadLine();
        }

        static void CheckProject(Project project)
        {
            if(!PreCheckProject(project))
            {
                return;
            }

            //(bugün-tarih)
            var diff = DateTime.Now - project.startDate;
            if (diff.Days >= project.plannedWorkDay)
            {
                LogApproved(project.name);
            }
            else
            {
                LogRejected(project.name);
            }
        }

        static bool PreCheckProject(Project project)
        {
            if (project.plannedWorkDay <= 0)
            {
                LogWarning(project.name);
                return false;
            }
            
            return true;
        }

        static void LogWarning(string projectName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{projectName} has some problems");
        }

        static void LogApproved(string projectName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{projectName} is approved");
        }

        static void LogRejected(string projectName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{projectName} is rejected");
        }
    }

    class Project
    {
        public string name;
        public DateTime startDate;
        public int plannedWorkDay;
    }
}
