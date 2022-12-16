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
            Console.WriteLine("4. Despacho ");
            Console.WriteLine("5. Decisão interlocutória");
            Console.WriteLine("6. Embargos no Tribunal Superior do Trabalho (TST)");
            Console.WriteLine("7. Custas processuais para recurso");
            Console.WriteLine("8. Impugnação das Embargos");
            Console.WriteLine("9. Interposição de Embargos à Execução");
            Console.WriteLine("10. Agravo de Instrumento");
            Console.WriteLine("11. Agravo de Instrumento contra despacho que não recebe Recurso Extraordinário");
            Console.WriteLine("12. Agravo de Petição – Interposição");
            Console.WriteLine("13. Agravo contra decisão denegatória dos Embargo");
            Console.WriteLine("14. Agravo contra decisão denegatória do Recurso de Revista");




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
            else if (opcao == 4)
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
            else if (opcao == 5)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
                dataRecurso = dataPublicacao;
                dias = 0;
                while (dias < 10)
                {
                    dataRecurso = dataRecurso.AddDays(1);
                    if (dataRecurso.DayOfWeek != DayOfWeek.Saturday && dataRecurso.DayOfWeek != DayOfWeek.Sunday)
                    {
                        dias++;
                    }
                }

                Console.WriteLine("Prazo fatal para interposição do recurso: " + dataRecurso.ToString("dd/MM/yyyy"));
            }
            else if (opcao == 6)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
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
            else if (opcao == 7)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
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
            else if (opcao == 8)
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
            else if (opcao == 10)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
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
            else if (opcao == 11)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
                dataRecurso = dataPublicacao;
                dias = 0;
                while (dias < 10)
                {
                    dataRecurso = dataRecurso.AddDays(1);
                    if (dataRecurso.DayOfWeek != DayOfWeek.Saturday && dataRecurso.DayOfWeek != DayOfWeek.Sunday)
                    {
                        dias++;
                    }
                }

                Console.WriteLine("Prazo fatal para interposição do recurso: " + dataRecurso.ToString("dd/MM/yyyy"));
            }
            else if (opcao == 12)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
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
            else if (opcao == 13)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
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
            else if (opcao == 14)
            {
                // Calcula a data do recurso adicionando 5 dias úteis à data de publicação
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

        }
    }
}
