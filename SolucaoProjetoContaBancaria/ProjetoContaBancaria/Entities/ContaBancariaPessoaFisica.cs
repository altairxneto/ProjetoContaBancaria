
using ProjetoContaBancaria.Entities.Enums;

namespace ProjetoContaBancaria.Entities {
    internal class ContaBancariaPessoaFisica:ContaBancaria {
        public TipoDeConta TipoDeConta { get; private set; }
    }
}
