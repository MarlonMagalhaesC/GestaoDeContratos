using POONelio.Entities;
using POONelio.Entities.Enum;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bem vindo ao Gerenciador de Contratos Trabalhistas! \nDigite o nome do departamento do trabalhador: ");
            string dept = Console.ReadLine();

            Console.Write("Entre com os Dados do trabalhador: \n1)Digite o nome: ");
            string name = Console.ReadLine();

            Console.Write("Levels: \n1) Junior\n2) Mid_Level\n3) Senior \nDigite o nome do level do respectivo trabalhador: "); 
            string aux = Console.ReadLine();

            WorkerLevel level =  Enum.Parse<WorkerLevel>(aux.ToUpper()); 

            Console.Write("Digite seu salário base (Use vírgula para decimais): R$ ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department departament = new Department(dept);

            Worker worker = new Worker(departament, name, level, baseSalary);

            Console.WriteLine(worker);

            Console.Write("Quantos contratos para este trabalhador? ");
            int contratos = int.Parse(Console.ReadLine());

            for (int i = 1; i<= contratos; i++)
            {
                Console.WriteLine($"Dados do {i}° contrato: "); 

                Console.Write("Digite a data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite o valor por hora: R$ ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Digite o total de horas: ");
                int hours = int.Parse(Console.ReadLine()); 

                HourContract contract = new HourContract(data, valuePerHour, hours);

                worker.AddContract(contract);

            }

            Console.Write("Digite o mês e o ano para calcular a renda total (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

     

            Console.WriteLine($"Nome: {worker.name},\nDepartamento: {worker.departament.name},\nRenda total para {year}/{month}: R$ {worker.Income(year,month)} ");


        }
    }
}