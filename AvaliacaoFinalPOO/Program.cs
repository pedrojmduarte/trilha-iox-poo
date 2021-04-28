using System;
using System.Globalization;
using AvaliacaoFinalPOO.Entities;

namespace AvaliacaoFinalPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você é um funcionário terceirizado?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (opcao == 1)
            {
                FuncionarioTerceirizado funcTer1 = new FuncionarioTerceirizado("João Pedro Medeiros", 120, 20.00, "Promon", 10.00);
                FuncionarioTerceirizado funcTer2 = new FuncionarioTerceirizado("Mariana Godoi", 160, 35.00, "Altech", 20.00);
                FuncionarioTerceirizado funcTer3 = new FuncionarioTerceirizado("Paulo Seixas", 160, 40.00, "BBcom", 15.00);
                FuncionarioTerceirizado funcTerNovo = new FuncionarioTerceirizado();

                Console.WriteLine("Já possui cadastro?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcao == 1)
                {
                    Console.WriteLine("Selecionar a opção com o seu nome:");
                    Console.WriteLine("1 - " + funcTer1.Nome);
                    Console.WriteLine("2 - " + funcTer2.Nome);
                    Console.WriteLine("3 - " + funcTer3.Nome);
                    Console.WriteLine("Digitar qualquer número para nomes não encontrados");
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Informações de Salário:");
                            Console.Write("Nome: ");
                            Console.WriteLine(funcTer1.Nome);
                            Console.Write("Empresa: ");
                            Console.WriteLine(funcTer1.EmpresaOrigem);
                            Console.Write("Salario: ");
                            Console.WriteLine(funcTer1.CalculaSalario().ToString("F2", CultureInfo.InvariantCulture));
                            break;
                        case 2:
                            Console.WriteLine("Informações de Salário:");
                            Console.Write("Nome: ");
                            Console.WriteLine(funcTer2.Nome);
                            Console.Write("Empresa: ");
                            Console.WriteLine(funcTer2.EmpresaOrigem);
                            Console.Write("Salario: ");
                            Console.WriteLine(funcTer2.CalculaSalario().ToString("F2", CultureInfo.InvariantCulture));
                            break;
                        case 3:
                            Console.WriteLine("Informações de Salário:");
                            Console.Write("Nome: ");
                            Console.WriteLine(funcTer3.Nome);
                            Console.Write("Empresa: ");
                            Console.WriteLine(funcTer3.EmpresaOrigem);
                            Console.Write("Salario: ");
                            Console.WriteLine(funcTer3.CalculaSalario().ToString("F2", CultureInfo.InvariantCulture));
                            break;
                        default:
                            break;

                    }

                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Novo Cadastro:");
                    Console.Write("Digite o seu nome completo: ");
                    funcTerNovo.Nome = Console.ReadLine();
                    Console.Write("Digite sua empresa de origem: ");
                    funcTerNovo.EmpresaOrigem = Console.ReadLine();
                    Console.Write("Digite a sua carga horária mensal: ");
                    funcTerNovo.CargaHoraria = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor recebido por hora: ");
                    funcTerNovo.ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite a taxa de serviço: ");
                    funcTerNovo.TaxaServico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    Console.WriteLine("Informações de Salário:");
                    Console.Write("Nome: ");
                    Console.WriteLine(funcTerNovo.Nome);
                    Console.Write("Empresa: ");
                    Console.WriteLine(funcTerNovo.EmpresaOrigem);
                    Console.Write("Salario: ");
                    Console.WriteLine(funcTerNovo.CalculaSalario().ToString("F2", CultureInfo.InvariantCulture));

                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }

            }
            else if (opcao == 2)
            {
                Funcionario func1 = new Funcionario("Maria Clara Ferreira", 200, 35.00);
                Funcionario func2 = new Funcionario("Gabriel Sousa Gomes", 160, 23.00);
                Funcionario func3 = new Funcionario("Vitória Pedrosa", 120, 55.00);
                Funcionario funcNovo = new Funcionario();

                Console.WriteLine("Já possui cadastro?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcao == 1)
                {
                    Console.WriteLine("Selecionar a opção com o seu nome:");
                    Console.WriteLine("1 - " + func1.Nome);
                    Console.WriteLine("2 - " + func2.Nome);
                    Console.WriteLine("3 - " + func3.Nome);
                    Console.WriteLine("Digitar qualquer número para nomes não encontrados");
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Informações de Salário:");
                            Console.Write("Nome: ");
                            Console.WriteLine(func1.Nome);
                            Console.Write("Salario: ");
                            Console.WriteLine(func1.CalculaSalario().ToString("F2", CultureInfo.InvariantCulture));
                            break;
                        case 2:
                            Console.WriteLine("Informações de Salário:");
                            Console.Write("Nome: ");
                            Console.WriteLine(func2.Nome);
                            Console.Write("Salario: ");
                            Console.WriteLine(func2.CalculaSalario().ToString("F2", CultureInfo.InvariantCulture));
                            break;
                        case 3:
                            Console.WriteLine("Informações de Salário:");
                            Console.Write("Nome: ");
                            Console.WriteLine(func3.Nome);
                            Console.Write("Salario: ");
                            Console.WriteLine(func3.CalculaSalario().ToString("F2", CultureInfo.InvariantCulture));
                            break;
                        default:
                            break;

                    }

                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Novo Cadastro:");
                    Console.Write("Digite o seu nome completo: ");
                    funcNovo.Nome = Console.ReadLine();
                    Console.Write("Digite a sua carga horária mensal: ");
                    funcNovo.CargaHoraria = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor recebido por hora: ");
                    funcNovo.ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite a taxa de serviço: ");


                    Console.WriteLine("Informações de Salário:");
                    Console.Write("Nome: ");
                    Console.WriteLine(funcNovo.Nome);
                    Console.Write("Salario: ");
                    Console.WriteLine(funcNovo.CalculaSalario().ToString("F2", CultureInfo.InvariantCulture));

                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }

            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }
        }
    }
}
