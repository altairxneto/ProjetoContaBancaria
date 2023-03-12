
using ProjetoContaBancaria.Entities.Excecoes;

namespace ProjetoContaBancaria.Services {
    public class ServiceValidarCriacaoDePastas : IServiceValidarInformacao {
        public void ValidarInformacao() {
            //Identificando em qual usuário está logado no computador
            string nomeUsuario = Environment.UserName;

            //Identificando todos os paths de pastas
            string pathPastaContaBancaria = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto";
            string pathPastaBancoDeDados = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\BancoDeDados";
            string pathPastaComprovanteBancarioSaque = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\ComprovantesBancarios\\ComprovanteSaque";
            string pathPastaComprovanteBancarioDeposito = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\ComprovantesBancarios\\ComprovanteDeposito";
            string pathPastaComprovanteBancarioExtrato = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\ComprovantesBancarios\\ExtratosBancarios";

            Console.ForegroundColor = ConsoleColor.White;

            //Verificando se existe e caso não, criando os paths das pastas que serão utilizadas
            try {

                //criando a pasta bancaria
                if (!System.IO.Directory.Exists(pathPastaContaBancaria)) {
                    Directory.CreateDirectory(pathPastaContaBancaria);

                    ConsoleColor cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("A pasta do projeto Conta Bancaria foi criada!");

                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Documentos -> Conta Bancaria Projeto");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.BackgroundColor = cor;

                    Console.ReadLine();
                }

                Console.Clear();

                //criando a pasta de banco de dados
                if (!System.IO.Directory.Exists(pathPastaBancoDeDados)) {
                    Directory.CreateDirectory(pathPastaBancoDeDados);

                    ConsoleColor cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;

                    Console.WriteLine("A pasta Banco de Dados do projeto Conta Bancaria foi criada!");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.BackgroundColor = cor;

                    Console.ReadLine();
                }

                Console.Clear();

                //criando o arquivo de números de contas
                if (!System.IO.File.Exists("C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\BancoDeDados\\NumerosDeContas.txt")) {
                    ConsoleColor cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    string pathArquivoNumerosDeContas = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\BancoDeDados\\NumerosDeContas.txt";
                    FileStream arquivo = new FileStream(pathArquivoNumerosDeContas, FileMode.CreateNew);
                    arquivo.Close();

                    using (StreamWriter sw = File.AppendText(pathArquivoNumerosDeContas)) {
                        sw.Write("0");
                    }

                    Console.WriteLine("O banco de dados foi criado.");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.BackgroundColor = cor;

                    Console.ReadLine();
                }

                //criando o arquivo de transações
                if (!System.IO.File.Exists("C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\BancoDeDados\\Transacoes.txt")) {
                    ConsoleColor cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    string pathArquivoTransacoes = "C:\\Users\\" + nomeUsuario + "\\Downloads\\ContaBancariaProjeto\\BancoDeDados\\Transacoes.txt";
                    FileStream arquivo = new FileStream(pathArquivoTransacoes, FileMode.CreateNew);
                    arquivo.Close();

                    Console.WriteLine("O arquivo de transações da conta foi criado.");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.BackgroundColor = cor;

                    Console.ReadLine();
                }

                Console.Clear();
                //informando que a pasta de comprovante de saque foi criada

                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioSaque)) {
                    ConsoleColor cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Directory.CreateDirectory(pathPastaComprovanteBancarioSaque);

                    Console.WriteLine("A pasta de comprovantes bancários de Saques foi criada!");

                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Documentos -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ComprovanteSaque");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.BackgroundColor = cor;

                    Console.ReadLine();
                }

                Console.Clear();

                //informando que a pasta de comprovante de depósito foi criada
                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioDeposito)) {
                    ConsoleColor cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Directory.CreateDirectory(pathPastaComprovanteBancarioDeposito);

                    Console.WriteLine("A pasta de comprovantes bancários de Deposito foi criada!");

                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Documentos -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ComprovanteDeposito");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.BackgroundColor = cor;

                    Console.ReadLine();
                }

                Console.Clear();

                //informando que a pasta de extrato bancario foi criada
                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioExtrato)) {
                    ConsoleColor cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Directory.CreateDirectory(pathPastaComprovanteBancarioExtrato);

                    Console.WriteLine("A pasta de comprovantes bancários de Extrato foi criada!");

                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Documentos -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ExtratosBancarios");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.BackgroundColor = cor;

                    Console.ReadLine();
                }
            }
            catch (Excecao excecao) {
                ConsoleColor cor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Ocorreu um erro: " + excecao.Message);

                Console.BackgroundColor = cor;
            }
            catch (Exception excecao) {
                ConsoleColor cor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Ocorreu um erro: " + excecao.Message);

                Console.BackgroundColor = cor;
            }
        }
    }
}
