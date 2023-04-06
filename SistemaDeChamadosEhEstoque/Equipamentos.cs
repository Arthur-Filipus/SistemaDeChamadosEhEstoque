using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaDeChamadosEhEstoque
{
    public class Equipamentos
    {
        public string nome { get; set; }
        private decimal preco { get; set; }
        private string numerodeserie { get; set; }
        private DateTime datafabricacao { get; set; }
        private string fabricante { get; set; }
        public string escolhamenuequipamento { get; set; }
        public int ID { get; set; }
        public int remove { get; set; }
        public void MenuEquipamento()
        {
            Console.WriteLine("Qual coisa quer ver");
            Console.WriteLine("(1) Registro de Equipamento (2) Visualizar Equipamentos (3) Editar Equipamentos (4) Excluir Equipamentos (S) Voltar");
            escolhamenuequipamento = Console.ReadLine().ToUpper();
            Console.Clear();
        }

        public void RegistroEquipamento(List<Equipamentos>ListaEquipamento)
        {
            Equipamentos equipamentos = new Equipamentos();
            
            Console.Write("Digite o nome do Equipamento: ");

            equipamentos.nome = Console.ReadLine();

            Console.Write("Digite o preço do Equipamento: ");

            equipamentos.preco = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o numero de serie do Equipamento: ");

            equipamentos.numerodeserie = Console.ReadLine();

            Console.Write("Digite a Data de fabricação do Equipamento: ");

            equipamentos.datafabricacao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a fabricante do Equipamento: ");

            equipamentos.fabricante = Console.ReadLine();

            Console.WriteLine("Registro feito com sucesso");

            Console.ReadLine();

            equipamentos.ID = ListaEquipamento.Count;

            ListaEquipamento.Add(equipamentos);
        }
        public void VisualizarEquipamento(List<Equipamentos> ListaEquipamento)
        {
            Console.WriteLine("ID   Nome   Preço   Numero de Série   Data de Fabricação   Fabricante");
            foreach (var item in ListaEquipamento)
            {
                Console.Write($"{item.ID}  {item.nome}   {item.preco}   {item.numerodeserie}   {item.datafabricacao}   {item.fabricante}\n");
            }
            Console.ReadLine();
        }

        public void EditarEquipamento(List<Equipamentos> ListaEquipamento)
        {
            Equipamentos equipamentos = new Equipamentos();

            Console.WriteLine("Qual ID equipamento quer editar, o seu tongo: ");

            equipamentos.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaEquipamento.FindIndex(item => equipamentos.remove == item.ID);

            ListaEquipamento.RemoveAt(index);

            Console.Write("Digite o nome do Equipamento: ");

            equipamentos.nome = Console.ReadLine();

            Console.Write("Digite o preço do Equipamento: ");

            equipamentos.preco = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o numero de serie do Equipamento: ");

            equipamentos.numerodeserie = Console.ReadLine();

            Console.Write("Digite a Data de fabricação do Equipamento: ");

            equipamentos.datafabricacao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a fabricante do Equipamento: ");

            equipamentos.fabricante = Console.ReadLine();

            Console.ReadLine();

            equipamentos.ID++;

            ListaEquipamento.Add(equipamentos);

            Console.WriteLine("Edição feita com sucesso");
        }

        public void ExcluirEquipamento(List<Equipamentos> ListaEquipamento)
        {
            Equipamentos equipamento = new Equipamentos();
            
            Console.WriteLine("Qual equipamento quer remover, o seu tongo: ");

            equipamento.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaEquipamento.FindIndex(item => equipamento.remove == item.ID);

            ListaEquipamento.RemoveAt(index);

            Console.WriteLine("Exclusão feita com sucesso");
        }
    }
}