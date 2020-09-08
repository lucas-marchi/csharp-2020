namespace exc01.Models
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }

        public Endereco(string rua, string numero)
        {
            Rua = rua;
            Numero = numero;
        }
    }
}
