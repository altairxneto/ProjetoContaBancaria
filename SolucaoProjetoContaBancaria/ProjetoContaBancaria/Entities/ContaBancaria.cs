using ProjetoContaBancaria.Entities.Enums;
using ProjetoContaBancaria.Entities.Excecoes;

namespace ProjetoContaBancaria.Entities {
    public class ContaBancaria {
        public int NumeroConta { get; private set; }
        public double SaldoConta { get; private set; }
        public AgenciaBancaria Agencia { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(int numeroConta, AgenciaBancaria agencia) {
            NumeroConta = int.Parse(GerarNumeroConta());
            Agencia = agencia;
            SaldoConta = 0;
        }

        public string GerarNumeroConta() {
            try {
                string nomeUsuario = Environment.UserName;

                string pathNumerosDeContas = "C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\BancoDeDados\\NumerosDeContas.txt";
                string[] linhasDoArquivo = File.ReadAllLines(pathNumerosDeContas);
                string[] linhasDoArquivoReescrito = new string[linhasDoArquivo.Length];

                int numeroConta = 0;
                StreamWriter sw;

                //Este contador vai servir para me dizer se, alguma conta que já foi de alguém e agora está zerada, vai ser atribuída novamente para outra pessoa
                int contadorAnulador = 0;

                for (int contador = 0; contador < linhasDoArquivo.Length; contador++) {
                    if ((linhasDoArquivo[contador] == "0" && !(contador == linhasDoArquivo.Length - 1)) || (linhasDoArquivo[contador] == "0" && linhasDoArquivo.Length == 1)) {
                        if (contador == 0) {
                            numeroConta++;

                            linhasDoArquivoReescrito[contador] = numeroConta.ToString();
                            
                            contadorAnulador++;
                        }

                        if (contador != 0) {
                            numeroConta = int.Parse(linhasDoArquivo[contador - 1]) + 1;

                            linhasDoArquivoReescrito[contador] = numeroConta.ToString();

                            contadorAnulador++;
                        }

                    }
                    else if (linhasDoArquivo[contador] == "0" && contador == linhasDoArquivo.Length - 1 && contadorAnulador == 0) {
                        numeroConta = int.Parse(linhasDoArquivo[contador - 1]) + 1;

                        linhasDoArquivoReescrito[contador] = numeroConta.ToString();
                    }
                    else {
                        linhasDoArquivoReescrito[contador] = linhasDoArquivo[contador];
                    }
                }

                using (sw = File.CreateText(pathNumerosDeContas)) {
                    foreach (string line in linhasDoArquivoReescrito) {
                        sw.WriteLine(line);
                    }
                    if(contadorAnulador == 0 || (linhasDoArquivo.Length == 1 && contadorAnulador > 0)) {
                        sw.WriteLine("0");
                    }
                }

                return numeroConta.ToString();
            }
            catch(Excecao excecao) {
                Console.WriteLine("Não foi possível gerar o número da conta, houve um erro: " + excecao.Message);

                return null;
            }
            catch(Exception excecao) {
                Console.WriteLine("Não foi possível gerar o número da conta, houve um erro: " + excecao.Message);

                return null;
            }
        }

        public void GerarComprovante(string path) {

        }

        public void Deposito(double valor) {
            SaldoConta += valor;


        }

        public void Saque(double valor) {
            SaldoConta -= valor;
            string pathComprovanteSaque = "C:\\Program Files\\Conta Bancaria Projeto\\ComprovantesBancarios\\ComprovanteSaque";
        }

        public void ExtratoBancario() {
            string pathExtratoBancario = "C:\\Program Files\\Conta Bancaria Projeto\\ComprovantesBancarios\\ExtratosBancarios";

        }
    }
}
