using System.Collections;
using System.Windows.Forms;

namespace FinalProject.Modelo
{
    class Entrada
    {
        //Carrega os botões disponíveis do teclado.
        private static Hashtable teclado = new Hashtable();

        //Ler se o botão em particular é pressionado.
        public static bool TeclaPressionada(Keys key)
        {
            if (teclado[key] == null)
            {
                return false;
            }

            return (bool) teclado[key];
        }

        //Detecta se o botão do teclado é pressionado.
        public static void MudarCondicao(Keys key, bool condicao)
        {
            teclado[key] = condicao;
        }
    }
}
