using ProjetoContaBancaria.Entities;
using ProjetoContaBancaria.Entities.Enums;
using System.Globalization;

namespace ProjetoContaBancaria.Services
{
    public class ServiceGerarComprovante
    {
        public void GerarComprovante(int numeroConta, Pessoa pessoa, string path, TipoAgenciaBancaria agencia, string nomeDoComprovante, double valorDoComprovante) {
            FileStream fs = new FileStream(path, FileMode.CreateNew);
            fs.Close();

            DateTime date = DateTime.Now;

            using (StreamWriter sw = File.AppendText(path)) {
                sw.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                sw.Write("COMPROVANTE DE " + nomeDoComprovante.ToUpper());
                sw.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                sw.Write("Data e hora do comprovante: " + date.ToString("dd/MM/yyyy às HH:mm:ss"));
                sw.Write("Titular da conta: " + pessoa.Nome);
                sw.Write("Agencia: " + agencia);
                sw.Write("Conta: " + numeroConta);
                sw.Write("Valor da transação: R$" + valorDoComprovante.ToString("F2", CultureInfo.InvariantCulture));
                sw.WriteLine();
                sw.WriteLine();
            }
        }

    }
}
