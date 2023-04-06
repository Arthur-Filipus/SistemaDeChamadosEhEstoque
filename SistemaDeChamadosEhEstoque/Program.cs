using System.Collections;

namespace SistemaDeChamadosEhEstoque
{
    public class Program
    {
        static void Main(string[] args)
        {
            string escolha = "";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                        Bem vindo ao sistema da Academia zika\n");
            Console.ForegroundColor = ConsoleColor.White;

            Equipamentos equipamento = new Equipamentos();

            var listaequipamentos = new List<Equipamentos>();

            var listachamados = new List<Chamados>();

            for (int i = 0; i < 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                       Digite o serviço que desseja utilizar:");
                Console.WriteLine("(1) Controle de Equipamentos (2) Controle de Chamados (S) Sair do programa");
                Console.ForegroundColor = ConsoleColor.White;

                escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    for (int j = 0; j < 2; j++)
                    {
                        equipamento.MenuEquipamento();

                        if (equipamento.escolhamenuequipamento == "1")
                        {
                            equipamento.RegistroEquipamento(listaequipamentos);
                            j--;
                        }
                        else if (equipamento.escolhamenuequipamento == "2")
                        {
                            equipamento.VisualizarEquipamento(listaequipamentos);
                            j--;
                        }
                        else if (equipamento.escolhamenuequipamento == "3")
                        {
                            equipamento.EditarEquipamento(listaequipamentos);
                            j--;
                        }
                        else if (equipamento.escolhamenuequipamento == "4")
                        {
                            equipamento.ExcluirEquipamento(listaequipamentos);
                            j--;
                        }
                        else if (equipamento.escolhamenuequipamento == "S")
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Opção inválida, tente novamente.");
                            Console.ForegroundColor = ConsoleColor.White;
                            j--;
                        }
                        Console.WriteLine();
                    }
                    i--;
                }
                else if (escolha == "2")
                {
                    for (int j = 0; j < 2; j++)
                    {

                        var chamado = new Chamados();

                        chamado.MenuChamado();

                        if (chamado.escolhamenuchamado == "1")
                        {
                            chamado.RegistroChamado(listachamados);
                            j--;
                        }
                        else if (chamado.escolhamenuchamado == "2")
                        {
                            chamado.VisualizarChamado(listachamados);
                            j--;
                        }
                        else if (chamado.escolhamenuchamado == "3")
                        {
                            chamado.EditarChamado(listachamados);
                            j--;
                        }
                        else if (chamado.escolhamenuchamado == "4")
                        {
                            chamado.ExcluirChamado(listachamados);
                            j--;
                        }
                        else if (chamado.escolhamenuchamado == "S")
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Opção inválida, tente novamente.");
                            Console.ForegroundColor = ConsoleColor.White;
                            j--;
                        }
                        Console.WriteLine();
                    }
                    i--;
                }
                else if (escolha == "S")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Obrigado por utilizar nosso programa FODA");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Console.ForegroundColor = ConsoleColor.White;
                    i--;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}