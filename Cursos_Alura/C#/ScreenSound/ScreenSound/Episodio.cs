using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpisodioNamespace
{
    public class Episodio
    {
        public string Titulo { get; set; }
        public double Duracao { get; set; }
        public int Ordem { get; set; }
        public List<string> Convidados{ get; set; }
        public string Resumo => 
            $"{Ordem}. Ep. Nº{Ordem}. Titulo: {Titulo}.\nDuração: {(Duracao/60).ToString("F2").Replace(",",":")}.\n" +
            $"Convidados: {string.Join(", ", Convidados)}";

        public Episodio(string titulo, double duracao, int ordem)
        {
            Titulo = titulo;
            Duracao = duracao;
            Ordem = ordem;
            Convidados = [];
        }

        public void AdicionarConvidados(string convidado)
        {
            Convidados.Add(convidado);
        }
    }
}
