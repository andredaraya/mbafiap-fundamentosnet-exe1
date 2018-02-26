using System.Text.RegularExpressions;

namespace MovimentacaoBancaria.Dominio.Utils
{
    public static class Extensoes
    {
        public static bool ValidarEmail(this string texto)
        {
            if (!Regex.IsMatch(texto, @"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$"))
            {
                return false;
            }

            return true;
        }

        public static string FormatarTexto(this string texto)
        {
            string com_Acentos = "ÄÀÁÂÃäàáâãËÈÉÊëèéêÏÌÍÎïìíîÖÒÓÔÕöòóôõÜÙÚÛüùúûÇçÑñ";
            string sem_Acentos = "AAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUUuuuuCcNn";

            for (int i = 0; i < com_Acentos.Length; i++)
            {
                texto = texto.Replace(com_Acentos[i], sem_Acentos[i]);
            }

            texto = texto.ToUpper();

            return texto;
        }

        public static string FormatarCpf(this string texto)
        {
            texto = texto.Replace(".", string.Empty);
            texto = texto.Replace("-", string.Empty);
            return texto;
        }

        public static bool ValidarCpf(this string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
