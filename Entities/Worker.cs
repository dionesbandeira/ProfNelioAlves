using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities.Enums;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ProfNelioAlves.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public Workerlevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
                                                    //Será instacianda para que não seja nula
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {

        }
        public Worker(string name, Workerlevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }



        public void addContract(HourContract Contract) 
        {
            Contracts.Add(Contract);
        }
        public void removeContract(HourContract Contract) 
        {
            Contracts.Remove(Contract);
        }
        public double income(int year, int month) 
        {
            double sum = BaseSalary;

            //Pecorrer -> para cada HourContract na minha lista de contratos eu farei o seguinte SE
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month) 
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
        

    }
}
