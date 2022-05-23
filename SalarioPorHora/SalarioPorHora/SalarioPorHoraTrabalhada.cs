using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioPorHora
{
    public class SalarioPorHoraTrabalhada
    {
        public static void Iniciar()
        {
            LerDados();
        }

        public static void LerDados()
        {
            double salario;
            int horasTrabalhadasDia;
            double totalSalarioDia;
            double totalSalarioHora;
            int mesTrabalhado = 22;

            Console.WriteLine("Informe seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Informe a suas horas trabalhadas por dia: ");
            horasTrabalhadasDia = Convert.ToInt32(Console.ReadLine());

            totalSalarioDia = salario / mesTrabalhado;

            totalSalarioHora = totalSalarioDia / horasTrabalhadasDia;

            Console.WriteLine($"Você recebe por dia: {totalSalarioDia}");

            Console.WriteLine($"E por hora: {totalSalarioHora}");
        }
    }
}
