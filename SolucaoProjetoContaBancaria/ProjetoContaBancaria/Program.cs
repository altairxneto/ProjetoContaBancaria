using ProjetoContaBancaria.Entities;
using ProjetoContaBancaria.Entities.Enums;

namespace ProjetoContaBancaria {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta = new ContaBancaria();
            conta.GerarNumeroConta();
        }
    }
}