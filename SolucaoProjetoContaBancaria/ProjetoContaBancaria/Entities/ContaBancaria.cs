
namespace ContaBancaria.Entities {
    public class ContaBancaria {
        public int NumeroConta { get; private set; }
        public int AgenciaConta { get; private set; }

        public ContaBancaria(int numeroConta, int agenciaConta) {
            NumeroConta = numeroConta;
            AgenciaConta = agenciaConta;
        }

        public int GerarNumeroConta() {
            string pathContadorNumeroDeContas = "C:\\Users\\Laboratorio 3D\\Desktop\\MeusProjetos\\ProjetoContaBancaria\\SolucaoProjetoContaBancaria\\ProjetoContaBancaria\\BancoDeDados\\ContadorNumeroDeContas.txt";

            string[] linhasDoContador = File.ReadAllLines(pathContadorNumeroDeContas);

            int variavelAuxiliar = 0;

            foreach(string line in linhasDoContador) {
                variavelAuxiliar += int.Parse(line);
            }

            int numero = 1 + variavelAuxiliar;

            using (StreamWriter sr = File.AppendText(pathContadorNumeroDeContas)) {
                sr.WriteLine(1);
            }
            return numero;
        }
    }
}
