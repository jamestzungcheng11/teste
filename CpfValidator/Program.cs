using System;
using System.Linq;

namespace CpfValidatorTests
{

    public   class CpfValidatorTests
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello-world");
        }
        public static string RemoverCarateresNaoNumericos(string cpf)
        {
            return new string(cpf.Where(char.IsDigit).ToArray());
        }

        public static  bool  VerificarTamanho(string cpf)
        {
            return cpf.Length == 11;
        }
        public static bool TodosDigitosIguais(string cpf)
        {
            return cpf.Distinct().Count() == 1;
        }

    }
}
