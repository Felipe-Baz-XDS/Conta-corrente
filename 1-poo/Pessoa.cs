namespace _1_poo
{
    public class Pessoa
    {
        public Pessoa(string name, string cpf, string profissao){
            this.Name = name;
            this.Cpf = cpf;
            this.Profissao = profissao;
        }

        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
    }
}