using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bpls.validaSenha.API.Logica
{
    public class ValidaSenha
    {
        public bool ValidaNoveOuMaisCaracteres(string senha)
        {
            if (!String.IsNullOrWhiteSpace(senha) && senha.Length > 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidaSeExisteCaracterRepetido(string senha)
        {
            var regex = new Regex(@"(\w)*.*\1");
            var repetido = regex.Match(senha);

            if (!String.IsNullOrWhiteSpace(senha) && repetido.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ValidaSeExisteUmDigito(string senha)
        {
            var regex = new Regex(@"[0-9]+");
            var repetido = regex.Match(senha);

            if (!String.IsNullOrWhiteSpace(senha) && repetido.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public bool ValidaSeExisteUmCaracterMaiusculo(string senha)
        {
            var regex = new Regex(@"[A-Z]+");
            var repetido = regex.Match(senha);

            if (!String.IsNullOrWhiteSpace(senha) && repetido.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidaSeExisteUmCaracterMinusculo(string senha)
        {
            var regex = new Regex(@"[a-z]+");
            var repetido = regex.Match(senha);

            if (!String.IsNullOrWhiteSpace(senha) && repetido.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidaSeExisteUmCaracterEspecial(string senha)
        {
            var regex = new Regex(@"[!@#$%^&*()-+]");
            var repetido = regex.Match(senha);

            if (!String.IsNullOrWhiteSpace(senha) && repetido.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidaSeExisteEspacoEmBranco(string senha)
        {
            if (!String.IsNullOrWhiteSpace(senha))
            {
                var split = senha.Split(' ');
                if (split.Length > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
