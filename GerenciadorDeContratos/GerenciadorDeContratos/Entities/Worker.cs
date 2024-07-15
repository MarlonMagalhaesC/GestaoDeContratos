using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POONelio.Entities.Enum;

namespace POONelio.Entities
{
    public class Worker
    {
        public string name { get; set; }
        public WorkerLevel level { get; private set; }
        public double baseSalary { get; private set; }

        public Department departament;

        public List<HourContract> listContracts { get; set; } =  new List<HourContract>();


        public Worker() { }

        public Worker(Department departament, string name, WorkerLevel level, double baseSalary)
        {
            this.departament = departament;
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
        }
        public override string ToString() { return $"Dados do trabalhador:\nNome: {name}\nLevel: {level}\nSalário Base: R$ {baseSalary}"; }


        public void AddContract(HourContract contract)
        {
            listContracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            listContracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double res = 0;


            foreach (HourContract contract in listContracts)
            {

                if (contract.data.Year == year && contract.data.Month == month)
                {
                    res += contract.totalValue();
                }

            }
            if (res == 0)
                Console.WriteLine("Não existe contrato nesta data: ");

            return res + baseSalary;

        }

      
    }
}
