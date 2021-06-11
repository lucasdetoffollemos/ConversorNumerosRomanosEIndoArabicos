using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumerosRomanosEIndoArabicosTeste
{
    public class Numeros
    {
        public static readonly Dictionary<char, int> dicionarioDeRomanos;
        public static readonly Dictionary<int, string> dicionarioDeInteiros;


        private string VerificarLetrasEspeciais(string romano)
        {
            romano = romano.Replace("ĪV̄", "4");

            if (romano.Contains("V̄ĪĪĪ"))
                romano = romano.Replace("V̄ĪĪĪ", "8");
            
            else if (romano.Contains("V̄ĪĪ"))
                romano = romano.Replace("V̄ĪĪ", "7");

            else if (romano.Contains("V̄Ī"))
                romano = romano.Replace("V̄Ī", "6");

            else if (romano.Contains("V̄"))
                romano = romano.Replace("V̄", "5");

            romano = romano.Replace("ĪX̄", "9");
            romano = romano.Replace("X̄", "1");

            return romano;
        }

        static Numeros()
        {
            dicionarioDeRomanos = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
                { '4', 4000 },
                { '5', 5000 },
                { '6', 6000 },
                { '7', 7000 },
                { '8', 8000 },
                { '9', 9000 },
                { '1', 10000 }
            };

            dicionarioDeInteiros = new Dictionary<int, string>
            {
                { 10000, "X̄" },
                { 9000, "ĪX̄" },
                { 8000, "V̄ĪĪĪ" },
                { 7000, "V̄ĪĪ" },
                { 6000, "V̄Ī" },
                { 5000, "V̄" },
                { 4000, "ĪV̄" },
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };
        }


        public string ConversorInteirosARomanos(int numero)
        {
            var romano =  new StringBuilder();

            if(numero <= 10000)
            {
                foreach (var numeroNoDicionario in dicionarioDeInteiros)
                {
                    while (numero >= numeroNoDicionario.Key)
                    {
                        romano.Append(numeroNoDicionario.Value);
                        numero -= numeroNoDicionario.Key;
                    }
                }
            }

            else
            {
                romano.Append("Ainda não esta disponivel números maiores que 10.000 mil");
            }
           
            return romano.ToString();
        }

        public  int ConversorRomanosAInteiros(string romano)
        {
            romano = VerificarLetrasEspeciais(romano);

            int numero = 0;
            char letraAnterior = romano[0];
            foreach (char letraAtual in romano)
            {
                numero += dicionarioDeRomanos[letraAtual];
                if (dicionarioDeRomanos[letraAnterior] < dicionarioDeRomanos[letraAtual])
                {
                    numero -= dicionarioDeRomanos[letraAnterior] * 2;
                    
                }

                letraAnterior = letraAtual;
            }
            return numero;
        }

        
    }
}
