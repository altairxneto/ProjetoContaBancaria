﻿using ProjetoContaBancaria.Entities.Enums;

namespace ProjetoContaBancaria.Entities
{
    public class Pessoa {
        public string Nome { get; private set; }
        public int Cpf { get; private set; }
        public string NomeDoPai { get; private set; }
        public string NomeDaMae { get; private set; }
        public int Idade { get; private set; }
        public Sexo Sexo { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public EstadoCivil EstadoCivil { get; private set; }
        public ContaBancaria Conta { get; private set; }

        public Pessoa() { }

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
