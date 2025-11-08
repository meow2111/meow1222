using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Masha = new Employee("Маша", "Помощник", 30000, "12.09.2021");
            Manager Andrey = new Manager("Андрей", "Менеджер", 76000, "31.05.2023", 2);
            Developer David = new Developer("Давид", "Программист", 120000, "12.11.2022", "C#");
            Director Anastasia = new Director("Анастасия", "Директор", 90000, "01.04.2020", "Разработка десктопного ПО");
            Anastasia.AcceptBudget();
            Andrey.HoldMeeting();
            David.WriteCode();
            

        }
    }
}
