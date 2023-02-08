
using ContaBancaria.Entities.Enums;

namespace ContaBancaria.Entities {
    internal class ContaBancariaPessoaFisica:ContaBancaria {
        public TipoDeConta TipoDeConta { get; private set; }
    }
}
