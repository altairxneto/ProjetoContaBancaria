
using ProjetoContaBancaria.Entities.Excecoes;

namespace ProjetoContaBancaria.Services {
    public class ServiceValidarCriacaoDePastasDoProjeto : IServiceValidarInformacao {
        public void ValidarInformacao() {
            //Identificando em qual usuário está logado no computador
            string nomeUsuario = Environment.UserName;

            //Identificando todos os paths de pastas
            string pathPastaContaBancaria = "C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto";
            string pathPastaBancoDeDados = "C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\BancoDeDados";
            string pathPastaComprovanteBancarioSaque = "C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\ComprovantesBancarios\\ComprovanteSaque";
            string pathPastaComprovanteBancarioDeposito = "C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\ComprovantesBancarios\\ComprovanteDeposito";
            string pathPastaComprovanteBancarioExtrato = "C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\ComprovantesBancarios\\ExtratosBancarios";

            //Verificando se existe e caso não, criando os paths das pastas que serão utilizadas
            try {
                if (!System.IO.Directory.Exists(pathPastaContaBancaria)) {
                    Directory.CreateDirectory(pathPastaContaBancaria);

                    Console.WriteLine("A pasta do projeto Conta Bancaria foi criada!");
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Documentos -> Conta Bancaria Projeto");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                Console.Clear();

                if (!System.IO.Directory.Exists(pathPastaBancoDeDados)) {
                    Directory.CreateDirectory(pathPastaBancoDeDados);

                    Console.WriteLine("A pasta Banco de Dados do projeto Conta Bancaria foi criada!");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                if (!System.IO.File.Exists("C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\BancoDeDados\\NumerosDeContas.txt")) {
                    string pathArquivoNumerosDeContas = "C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\BancoDeDados\\NumerosDeContas.txt";
                    FileStream arquivo = new FileStream(pathArquivoNumerosDeContas, FileMode.CreateNew);
                    arquivo.Close();

                    using (StreamWriter sw = File.AppendText(pathArquivoNumerosDeContas)) {
                        sw.Write("0");
                    }

                    Console.WriteLine("O banco de dados foi criado.");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                Console.Clear();

                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioSaque)) {
                    Directory.CreateDirectory(pathPastaComprovanteBancarioSaque);

                    Console.WriteLine("A pasta de comprovantes bancários de Saques foi criada!");
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Documentos -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ComprovanteSaque");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                Console.Clear();

                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioDeposito)) {
                    Directory.CreateDirectory(pathPastaComprovanteBancarioDeposito);

                    Console.WriteLine("A pasta de comprovantes bancários de Deposito foi criada!");
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Documentos -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ComprovanteDeposito");

                    Console.WriteLine("Aperter ENTER para continuar!");

                    Console.ReadLine();
                }

                Console.Clear();

                if (!System.IO.Directory.Exists(pathPastaComprovanteBancarioExtrato)) {
                    Directory.CreateDirectory(pathPastaComprovanteBancarioExtrato);

                    Console.WriteLine("A pasta de comprovantes bancários de Extrato foi criada!");
                    Console.WriteLine("Para acessar a pasta, entre no Explorador de Arquivos -> Documentos -> Conta Bancaria Projeto -> Comprovantes Bancarios -> ExtratosBancarios");

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
