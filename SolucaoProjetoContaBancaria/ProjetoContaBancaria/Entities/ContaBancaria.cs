using ContaBancaria.Entities.Excecoes;

namespace ContaBancaria.Entities {
    public class ContaBancaria {
        public int NumeroConta { get; private set; }
        public int AgenciaConta { get; private set; }

        public ContaBancaria(int numeroConta, int agenciaConta) {
            NumeroConta = numeroConta;
            AgenciaConta = agenciaConta;
        }

        public void GerarNumeroConta() {
            try {
                string pathNumerosDeContas = "C:\\Users\\Laboratorio 3D\\Desktop\\MeusProjetos\\ProjetoContaBancaria\\SolucaoProjetoContaBancaria\\ProjetoContaBancaria\\BancoDeDados\\NumerosDeContas.txt";
                string[] linhasDoArquivo = File.ReadAllLines(pathNumerosDeContas);
                string[] linhasDoArquivoReescrito = new string[linhasDoArquivo.Length];

                int numeroConta = 0;
                StreamWriter sw;

                for (int contador = 0; contador < linhasDoArquivo.Length; contador++) {
                    if (linhasDoArquivo[contador] == "0") {
                        if (contador == 0) {
                            numeroConta++;

                            linhasDoArquivoReescrito[contador] = numeroConta.ToString();
                        }

                        if (contador != 0) {
                            numeroConta = int.Parse(linhasDoArquivo[contador - 1]) + 1;

                            linhasDoArquivoReescrito[contador] = numeroConta.ToString();
                        }
                    }
                    else {
                        linhasDoArquivoReescrito[contador] = linhasDoArquivo[contador];
                    }
                }

                using (sw = File.CreateText(pathNumerosDeContas)) {
                    foreach (string line in linhasDoArquivoReescrito) {
                        sw.WriteLine(line);
                    }

                    sw.WriteLine("0");
                }
            }
            catch(Excecao excecao) {
                Console.WriteLine("Não foi possível gerar o número da conta, houve um erro: " + excecao);
            }
        }
    }
}
