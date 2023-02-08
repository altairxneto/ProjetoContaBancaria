using ProjetoContaBancaria.Entities.Enums;

namespace ContaBancaria.Entities
{
    public class Pessoa {
        public string Nome { get; set; }
        public string NomeDoPai { get; set; }
        public string NomeDaMae { get; set; }
        public int Idade { get; private set; }
        public Sexo Sexo { get; set; }
        public DateTime DataDeNascimento { get; private set; }
        public EstadoCivil EstadoCivil { get; private set; }

        public Pessoa(string nome, string nomeDoPai, string nomeDaMae, Sexo sexo, DateTime dataDeNascimento, EstadoCivil estadoCivil) {
            Nome = nome;
            NomeDoPai = nomeDoPai;
            NomeDaMae = nomeDaMae;
            Sexo = sexo;
            DataDeNascimento = dataDeNascimento;
            EstadoCivil = estadoCivil;
            TimeSpan calcularDiasDeVidaDaPessoa = DateTime.Now.Subtract(DataDeNascimento);
            Idade = CalcularIdade(dataDeNascimento);
        }

        public int CalcularIdade(DateTime dataDeNascimento) {
            int idade = DateTime.Now.Year - dataDeNascimento.Year;
            if(DateTime.Now.DayOfYear < dataDeNascimento.DayOfYear) {
                idade -= 1;
            }

            return idade;
        }
    }
}
