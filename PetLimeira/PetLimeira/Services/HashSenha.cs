using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PetLimeira.Services
{
    // serviço responsavel por verificar e gerar o hash a senha
    // usa SHA-256 ( que ja vem por padrão com o .NET)
    // transforma a senha em uma seuqencia de 256 bits,
    // normalmente 64 caracteres haxadecimais


    public class HashSenha
    {
        //método que recebe a senha informada e devolve o hash de texto 
        public static string Gerar(string senha)
        {
            //tranfoma a senha em bytes e calcula o hash
            byte[] bytes = Encoding.UTF8.GetBytes(senha);
            byte[] hash = SHA256.HashData(bytes);

            // converter o hash para uma string hexadecimal
            return Convert.ToHexString(hash);
        }
        // método para conferir se a senha digitada corresponde ao hash do banco 
        public static bool Verificar(string senha, string hashArmazenado)
        {
            // gera a senha, compara e retorna verdadeiro ou falso
            return Gerar(senha) == hashArmazenado;
        }


    }
}
