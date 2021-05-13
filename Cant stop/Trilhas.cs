using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cant_stop
{
    public class Trilhas
    {
        public int Tamanho { get; set; }
        public int PontosComAlpinista { get; set; }
        public int PontosSemAlpinista { get; set; }
        public string Id;

        public Trilhas(string id, int tamanho, int pontosSemAlpinista, int pontosComAlpinista)
        {
            this.Id = id;
            this.Tamanho = tamanho;
            this.PontosComAlpinista = pontosComAlpinista;
            this.PontosSemAlpinista = pontosSemAlpinista;

        }




    }
}
