using ProjetoContaBancaria.Entities.Enums;
using ProjetoContaBancaria.Entities.Excecoes;
using System.Globalization;

namespace ProjetoContaBancaria.Entities {
    public class ContaBancaria {
        public int NumeroConta { get; private set; }
        public double SaldoConta { get; private set; }
        public AgenciaBancaria Agencia { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(AgenciaBancaria agencia) {
            NumeroConta = int.Parse(GerarNumeroConta());
            Agencia = agencia;
            SaldoConta = 0;
        }

        public string GerarNumeroConta() {
            try {
                string nomeUsuario = Environment.UserName;

                string pathNumerosDeContas = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\BancoDeDados\\NumerosDeContas.txt";
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

        public void GerarComprovante(Pessoa pessoa ,string path, string nomeDoComprovante, double valorDoComprovante) {
            FileStream fs = new FileStream(path, FileMode.CreateNew);
            fs.Close();

            DateTime date = DateTime.Now;

            using(StreamWriter sw = File.AppendText(path)) {
                sw.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                sw.Write("COMPROVANTE DE " + nomeDoComprovante.ToUpper());
                sw.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                sw.Write("Data e hora do comprovante: " + date.ToString("dd/MM/yyyy às HH:mm:ss"));
                sw.Write("Titular da conta: " + pessoa.Nome);
                sw.Write("Agencia: " + Agencia);
                sw.Write("Conta: " + NumeroConta);
                sw.Write("Valor da transação: R$" + valorDoComprovante.ToString("F2", CultureInfo.InvariantCulture));
                sw.WriteLine();
                sw.WriteLine();
            }
        }

        public void Deposito(double valor, Pessoa pessoa) {
            SaldoConta += valor;

            string nomeUsuario = Environment.UserName;
            string pathPastaComprovanteBancarioDeposito = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\ComprovantesBancarios\\ComprovanteDeposito";

            GerarComprovante(pessoa, pathPastaComprovanteBancarioDeposito, "DEPOSITO", valor);

            Console.Write("O comprovante de depósito foi gerado!");
            Console.WriteLine("Para acessar o comprovante, abra o explorador de arquivos do Windows, " +
                "acesse a pasta de Downloads, acesse a pasta do projeto da Conta Bancaria, " +
                "acesse a pasta de Comprovantes Bancarios e depois acesse a pasta de comprovantes de depósito.");
        }

        public void Saque(double valor, Pessoa pessoa) {
            SaldoConta -= valor;

            string nomeUsuario = Environment.UserName;
            string pathPastaComprovanteBancarioSaque = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\ComprovantesBancarios\\ComprovanteSaque";

            GerarComprovante(pessoa, pathPastaComprovanteBancarioSaque, "SAQUE", valor);

            Console.Write("O comprovante de saque foi gerado!");
            Console.WriteLine("Para acessar o comprovante, abra o explorador de arquivos do Windows, " +
                "acesse a pasta de Downloads, acesse a pasta do projeto da Conta Bancaria, " +
                "acesse a pasta de Comprovantes Bancarios e depois acesse a pasta de comprovantes de saque.");
        }

        public void GerarTransacoes(Pessoa pessoa, string nomeDoComprovante, double valorDoComprovante) {
            string nomeUsuario = Environment.UserName;
            string pathArquivoTransacoes = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\BancoDeDados\\Transacoes.txt";

            GerarComprovante(pessoa, pathArquivoTransacoes, nomeDoComprovante, valorDoComprovante);
        }
    }
}
