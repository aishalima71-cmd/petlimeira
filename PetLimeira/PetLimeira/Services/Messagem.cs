using System;
using System.Collections.Generic;
using System.Text;

namespace PetLimeira.Services
{
    internal class Messagem
    {
        // metodo para erro
        public static void Erro(string msg)
        {
            MessageBox.Show(
             msg,
            "Erro",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
        // metodo para aviso
        public static void Aviso(string msg)
        {
            MessageBox.Show(
            msg,
            "Aviso",
             MessageBoxButtons.OK,
             MessageBoxIcon.Warning
             );
        }
        public static DialogResult Confirmação(string msg)
        {
            return MessageBox.Show(
                msg,
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
        }


    }
}
