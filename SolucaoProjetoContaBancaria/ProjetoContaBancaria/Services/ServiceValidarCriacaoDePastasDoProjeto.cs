﻿
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

            Console.ForegroundColor = ConsoleColor.White;

            //Verificando se existe e caso não, criando os paths das pastas que serão utilizadas
            try {
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

                if (!System.IO.File.Exists("C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\BancoDeDados\\NumerosDeContas.txt")) {
                    ConsoleColor cor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    string pathArquivoNumerosDeContas = "C:\\Users\\" + nomeUsuario + "\\Documents\\ContaBancariaProjeto\\BancoDeDados\\NumerosDeContas.txt";
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

                Console.Clear();

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
