using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Calc_Interface
{
    class gerarCripto
    {
        public string criptografar(String senhaOriginal)
        {
            Byte[] bytesSenhaOriginal;
            Byte[] codificar;
            MD5 md5;


            md5 = new MD5CryptoServiceProvider();
            bytesSenhaOriginal = ASCIIEncoding.Default.GetBytes(senhaOriginal);
            codificar = md5.ComputeHash(bytesSenhaOriginal);

            return(BitConverter.ToString(codificar));
            
        }

        public string criptografarDiferente(String senhaOriginal)
        {
            Byte[] bytesSenhaOriginal;
            Byte[] codificar;
            MD5 md5;


            md5 = new MD5CryptoServiceProvider();
            bytesSenhaOriginal = ASCIIEncoding.Default.GetBytes(senhaOriginal);
            codificar = md5.ComputeHash(bytesSenhaOriginal);

            return Convert.ToBase64String(codificar);

        }


        public string _criptografarDiferente(String text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();

            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }

            return str.ToString();
        }
    }
}
