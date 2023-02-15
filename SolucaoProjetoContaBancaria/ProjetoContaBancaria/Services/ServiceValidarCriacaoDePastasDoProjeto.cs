
using ProjetoContaBancaria.Entities.Excecoes;

namespace ProjetoContaBancaria.Services {
    public class ServiceValidarCriacaoDePastasDoProjeto:IServiceValidarInformacao {
        public void ValidarInformacao() {
            //Identificando todos os paths de pastas
            string pathPastaContaBancaria = "C:\\Program Files\\Conta Bancaria Projeto";
            string pathPastaBancoDeDados = "C:\\Program Files\\Conta Bancaria Projeto\\BancoDeDados";
            string pathPastaComprovanteBancarioSaque = "C:\\Program Files\\Conta Bancaria Projeto\\ComprovantesBancarios\\ComprovanteSaque";
            string pathPastaComprovanteBancarioDeposito = "C:\\Program Files\\Conta Bancaria Projeto\\ComprovantesBancarios\\ComprovanteDeposito";
            string pathPastaComprovanteBancarioExtrato = "C:\\Program Files\\Conta Bancaria Projeto\\ComprovantesBancarios\\ExtratosBancarios";

            //Verificando se existe e caso não, criando os paths das pastas que serão utilizadas
            try {
                if (!System.IO.Directory.Exists(pathPastaContaBancaria)) {
                    Directory.CreateDirectory("C:\\Program Files\\Conta Bancaria Projeto");

                    Console.WriteLine("A pasta do projeto Conta Bancaria foi criada!");
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Disco Local C -> Arquivos de Programas -> Conta Bancaria Projeto");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                Console.Clear();

                if (!System.IO.Directory.Exists(pathPastaBancoDeDados)) {
                    Directory.CreateDirectory("C:\\Program Files\\Conta Bancaria Projeto\\BancoDeDados");

                    File.Create("C:\\Program Files\\Conta Bancaria Projeto\\BancoDeDados\\NumerosDeContas.txt");
                    using (StreamWriter sw = File.AppendText("C:\\Program Files\\Conta Bancaria Projeto\\BancoDeDados\\NumerosDeContas.txt")) {
                        Console.Write("0");
                    }

                    Console.WriteLine("A pasta Banco de Dados do projeto Conta Bancaria foi criada!");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                Console.Clear();

                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioSaque)) {
                    Directory.CreateDirectory("C:\\Program Files\\Conta Bancaria Projeto\\ComprovantesBancarios\\ComprovanteSaque");

                    Console.WriteLine("A pasta de comprovantes bancários de Saques foi criada!");
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Disco Local C -> Arquivos de Programas -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ComprovanteSaque");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                Console.Clear();

                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioDeposito)) {
                    Directory.CreateDirectory("C:\\Program Files\\Conta Bancaria Projeto\\ComprovantesBancarios\\ComprovanteDeposito");

                    Console.WriteLine("A pasta de comprovantes bancários de Deposito foi criada!");
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Disco Local C -> Arquivos de Programas -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ComprovanteDeposito");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                Console.Clear();

                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioExtrato)) {
                    Directory.CreateDirectory("C:\\Program Files\\Conta Bancaria Projeto\\ComprovantesBancarios\\ExtratosBancarios");

                    Console.WriteLine("A pasta de comprovantes bancários de Extrato foi criada!");
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Disco Local C -> Arquivos de Programas -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ExtratosBancarios");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }
            }
            catch (Excecao excecao) {
                Console.WriteLine("Ocorreu um erro: " + excecao.Message);
            }
            catch (Exception excecao) {
                Console.WriteLine("Ocorreu um erro: " + excecao.Message);
            }
        }
    }
}
