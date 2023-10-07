namespace Hotel.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public Pessoa(string Nome, string Sobrenome)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
        }

        public Pessoa() { }
    }
}
