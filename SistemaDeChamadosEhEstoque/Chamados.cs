using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeChamadosEhEstoque
{
    public class Chamados
    {
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string equipamento { get; set; }
        public DateTime dataabertura { get; set; }
        public string escolhamenuchamado { get; set; }
        public int ID { get; set; }
        public int remove { get; set; }
        public void MenuChamado()
        {
            Console.WriteLine("Qual coisa quer ver");
            Console.WriteLine("(1) Registro de Chamados (2) Visualizar Chamados (3) Editar Chamados (4) Excluir Chamados (S) Voltar");
            escolhamenuchamado = Console.ReadLine().ToUpper();
            Console.Clear();
        }
        public void RegistroChamado(List<Chamados>ListaChamado)
        {
            Chamados chamados = new Chamados();
            
            Console.Write("Digite o título do chamado: ");

            chamados.titulo = Console.ReadLine();

            Console.Write("Digite a descrição do chamado: ");

            chamados.descricao = Console.ReadLine();

            Console.Write("Digite o equipamentoem questão: ");

            chamados.equipamento = Console.ReadLine();

            Console.Write("Digite a data de abertura do chamado: ");

            chamados.dataabertura = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Registro feito com sucesso");

            Console.ReadLine();

            chamados.ID = ListaChamado.Count;

            ListaChamado.Add(chamados);
        }

        public void VisualizarChamado(List<Chamados>ListaChamado)
        {
            Console.WriteLine("ID   Título   Descrição   Equipamento   Data de Abertura");
            foreach (var item in ListaChamado)
            {
                Console.Write($"{item.ID}  {item.titulo}   {item.descricao}   {item.equipamento}   {item.dataabertura}\n");
            }
            Console.ReadLine();
        }

        public void EditarChamado(List<Chamados>ListaChamado)
        {
            Chamados chamados = new Chamados();

            Console.WriteLine("Qual ID chamado quer editar, o seu tongo: ");

            chamados.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaChamado.FindIndex(item => chamados.remove == item.ID);

            ListaChamado.RemoveAt(index);

            Console.Write("Digite o título do Chamado: ");

            chamados.titulo = Console.ReadLine();

            Console.Write("Digite a descrição do Chamado: ");

            chamados.descricao = Console.ReadLine();

            Console.Write("Digite o Equipamento em questão: ");

            chamados.equipamento = Console.ReadLine();

            Console.Write("Digite a Data de abertura do Chamado: ");

            chamados.dataabertura = Convert.ToDateTime(Console.ReadLine());

            Console.ReadLine();

            chamados.ID++;

            ListaChamado.Add(chamados);

            Console.WriteLine("Edição feita com sucesso");
        }

        public void ExcluirChamado(List<Chamados>ListaChamado)
        {
            Chamados chamados = new Chamados();

            Console.WriteLine("Qual Chamado quer remover, o seu tongo: ");

            chamados.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaChamado.FindIndex(item => chamados.remove == item.ID);

            ListaChamado.RemoveAt(index);

            Console.WriteLine("Exclusão feita com sucesso");
        }
    }
}
