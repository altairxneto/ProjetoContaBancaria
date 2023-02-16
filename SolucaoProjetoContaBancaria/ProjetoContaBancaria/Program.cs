using ProjetoContaBancaria.Entities;
using ProjetoContaBancaria.Entities.Enums;
using ProjetoContaBancaria.Entities.Excecoes;
using ProjetoContaBancaria.Services;

namespace ProjetoContaBancaria {
    class Program {
        static void Main(string[] args) {
            IServiceValidarInformacao validacaoDePastas = new ServiceValidarCriacaoDePastas();
            validacaoDePastas.ValidarInformacao();

            ContaBancaria conta = new ContaBancaria();

            Console.WriteLine(conta.GerarNumeroConta());
        }
    }
}