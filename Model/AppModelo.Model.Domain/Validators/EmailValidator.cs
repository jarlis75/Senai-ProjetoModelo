﻿using System.Text.RegularExpressions;

namespace AppModelo.Model.Domain.Validators
{
    public static partial class Validadores
    {
        /// <summary>
        /// Classe feita com strRegex para reconhecer email valido no campo.
        /// </summary>
        /// <param name="inputEmail"></param>
        /// <returns></returns>
        public static bool EmailEValido(string inputEmail)
        {
            var strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
