using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Modelo
{
    public enum Direcao
    {
        Cima,
        Baixo,
        Esquerda,
        Direita
    };
    public class Configuracoes
    {
        public static int Largura { get; set; }
        public static int Altura { get; set; }
        public static int Velocidade { get; set; }
        public static int Pontos { get; set; }
        public static int PontosPorComida { get; set; }
        public static bool FimDeJogo { get; set; }
        public static Direcao direcao { get; set; }

        public Configuracoes()
        {
            Largura = 16;
            Altura = 16;
            Velocidade = 101;
            Pontos = 0;
            PontosPorComida = 10;
            FimDeJogo = false;
            direcao = Direcao.Baixo;
        }
    }
}
