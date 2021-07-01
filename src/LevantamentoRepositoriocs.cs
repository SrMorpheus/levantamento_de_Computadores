using System;
using System.Collections.Generic;
using projetosesc.interfaces;
using System.IO;

namespace Levantamento.src
{
    public class LevantamentoRepositorios : IRepositorio<computador>
    {
        private List<computador> ListaComputador = new List <computador>();

        public void atualizar(int id, computador Objeto)
        {
        ListaComputador[id] = Objeto;

         StreamWriter Sw ;
         //caminho de acordo com da sua maquina
            var caminho = "\\Levantamento\\txt\\levantamento(Atualizado).txt";;
            Sw = File.AppendText(caminho);
            string teste = Objeto.ToString();
            Sw.WriteLine(teste);          
            Sw.WriteLine("____________________________________");

            Sw.Close();

        }

        public void exclui(int id)
        {
        ListaComputador[id].Excluir();
             //caminho de acordo com da sua maquina
            StreamWriter Sw ;
            var caminho = "\\Levantamento\\txt\\levantamento(Excluido).txt";
            Sw = File.AppendText(caminho);
         
            Sw.WriteLine(ListaComputador[id].ToString());          
            Sw.WriteLine("____________________________________");

            Sw.Close();


        }

        public void Insere(computador Objeto)
        {
               ListaComputador.Add(Objeto);
            StreamWriter Sw ;
               //caminho de acordo com da sua maquina
            var caminho = "\\Levantamento\\txt\\levantamento(Inserido).txt";
            Sw = File.AppendText(caminho);
            string teste = Objeto.ToString();
            Sw.WriteLine(teste);          
            Sw.WriteLine("____________________________________");

            Sw.Close();

         
        }

        public List<computador> Lista()
        {
            return ListaComputador;
        }

        public int ProximoId()
        {
          return ListaComputador.Count;
        }

        public computador RetornarPorId(int id)
        {
           return ListaComputador[id];
        }
    }
}