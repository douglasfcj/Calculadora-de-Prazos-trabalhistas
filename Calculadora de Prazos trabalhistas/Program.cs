using System;

namespace Recursos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse código foi produzido por Douglas Fernandes");
            Console.WriteLine("Contate-me em: www.curriculododouglas.com.br");
            Console.WriteLine("Selecione o tipo de recurso:");
            Console.WriteLine("1. Recurso Ordinário");
            Console.WriteLine("2. Recurso de Revista");
            Console.WriteLine("3. Embargos de Declaração");


            int opcao = Convert.ToInt32(Console.ReadLine());
            DateTime dataPublicacao;

            Console.WriteLine("Insira a data de publicação (dd/mm/yyyy):");
            dataPublicacao = Convert.ToDateTime(Console.ReadLine());

            DateTime dataRecurso;
            int dias;

            if (opcao == 1)
            {
                // Calcula a data do recurso adicionando 8 dias úteis à data de publicação
                dataRecurso = dataPublicacao;
                dias = 0;
                while (dias < 8)
                {
                    dataRecurso = dataRecurso.AddDays(1);
                    if (dataRecurso.DayOfWeek != DayOfWeek.Saturday && dataRecurso.DayOfWeek != DayOfWeek.Sunday)
                    {
                        dias++;
                    }
                }

                Console.WriteLine("Prazo fatal para interposição do recurso: " + dataRecurso.ToString("dd/MM/yyyy"));
            }
            else if (opcao == 2)
            {
                // Calcula a data do recurso adicionando 8 dias úteis à data de publicação
                dataRecurso = dataPublicacao;
                dias = 0;
                while (dias < 8)
                {
                    dataRecurso = dataRecurso.AddDays(1);
                    if (dataRecurso.DayOfWeek != DayOfWeek.Saturday && dataRecurso.DayOfWeek != DayOfWeek.Sunday)
                    {
                        dias++;
                    }
                }

                Console.WriteLine("Prazo fatal para interposição do recurso: " + dataRecurso.ToString("dd/MM/yyyy"));
            }
            else if (opcao == 3)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
                dataRecurso = dataPublicacao;
                dias = 0;
                while (dias < 5)
                {
                    dataRecurso = dataRecurso.AddDays(1);
                    if (dataRecurso.DayOfWeek != DayOfWeek.Saturday && dataRecurso.DayOfWeek != DayOfWeek.Sunday)
                    {
                        dias++;
                    }
                }

                Console.WriteLine("Prazo fatal para interposição do recurso: " + dataRecurso.ToString("dd/MM/yyyy"));
            }
        }
    }
}