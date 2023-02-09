namespace ProjetoContaBancaria.Services {
    public interface IServiceValidarInformacao<T> {
        public bool ValidarInformacao(T informacao);
    }
}
