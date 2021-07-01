using System;
using projetosesc.interfaces;
using  Levantamento.src;

   using System.IO;

namespace Levantamento.src
{
    class Program
    {
        static LevantamentoRepositorios repositorio = new LevantamentoRepositorios();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarComputador();
						break;
					case "2":
						InserirComputador();
						break;
					case "3":
						AtualizarComputador();
						break;
					case "4":
						ExcluirComputador();
						break;
					case "5":
						VisualizarComputador();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirComputador()
		{
			Console.Write("Digite o id do computador: ");
			int indiceComputador = int.Parse(Console.ReadLine());

			repositorio.exclui(indiceComputador);
		}

        private static void VisualizarComputador()
		{
			Console.Write("Digite o id do computador: ");
			int indiceComputador = int.Parse(Console.ReadLine());

			var computador = repositorio.RetornarPorId(indiceComputador);

			Console.WriteLine(computador);
		}

        private static void AtualizarComputador()
		{
			Console.Write("Digite o id do computador: ");
			int indiceComputador = int.Parse(Console.ReadLine());

		
			foreach (int i in Enum.GetValues(typeof(tipocomput)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(tipocomput), i));
			}
			Console.Write("Digite o tipo de sua maquina: ");
			int entradaTipo = int.Parse(Console.ReadLine());

            

            Console.Write("Digite o Modelo de sua maquina: ");
			string entradaModelo = Console.ReadLine();

                
            Console.Write("Digite o Usuario: ");
			string entradaUsuario = Console.ReadLine();

            Console.Write("Digite o nome do computador: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o IP do computador: ");
			string entradaIP = Console.ReadLine();

            Console.Write("Digite o patrimonio do computador: ");
			int entradaPatrimonio = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de aquisição: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o setor da maquina: ");
			string entradaSetor = Console.ReadLine();

			computador atualizarComputador = new computador(indiceComputador, entradaNome, entradaUsuario, (tipocomput)entradaTipo,entradaModelo, entradaIP, entradaPatrimonio, entradaAno, entradaSetor );
          

			repositorio.atualizar(indiceComputador, atualizarComputador);
		}
        private static void ListarComputador()
		{
			Console.WriteLine("Listar Computador");

			var lista = repositorio.Lista();
          
			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma computador cadastrado.");
				return;
			}

			foreach (var computador in lista)
			{
                var excluido = computador.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", computador.retornaId(), computador.retornaComputador(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirComputador()
		{
	foreach (int i in Enum.GetValues(typeof(tipocomput)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(tipocomput), i));
			}
			Console.Write("Digite o tipo de sua maquina: ");
			int entradaTipo = int.Parse(Console.ReadLine());

            Console.Write("Digite o Modelo de sua maquina: ");
			string entradaModelo = Console.ReadLine();

             Console.Write("Digite o Usuario: ");
			string entradaUsuario = Console.ReadLine();

            Console.Write("Digite o nome do computador: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o IP do computador: ");
			string entradaIP = Console.ReadLine();

            Console.Write("Digite o patrimonio do computador: ");
			int entradaPatrimonio = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de aquisição: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o setor da maquina: ");
			string entradaSetor = Console.ReadLine();
            	computador NovoComputador = new computador(repositorio.ProximoId(), entradaNome,entradaUsuario, (tipocomput)entradaTipo,entradaModelo, entradaIP, entradaPatrimonio, entradaAno, entradaSetor );

			repositorio.Insere(NovoComputador);

		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Levantamento de Computadores!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar Computadores");
			Console.WriteLine("2- Inserir novo Computadore");
			Console.WriteLine("3- Atualizar computador");
			Console.WriteLine("4- Excluir Computador");
			Console.WriteLine("5- Visualizar Computador");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}

