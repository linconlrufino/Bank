namespace Banco
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        public Cliente(string name)
        {
            this.Nome = name;
        }
    }
}