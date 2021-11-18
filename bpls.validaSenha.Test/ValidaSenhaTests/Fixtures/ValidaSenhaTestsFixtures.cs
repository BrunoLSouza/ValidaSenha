﻿using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bpls.validaSenha.Test.ValidaSenhaTests.Fixtures
{
    public class ValidaSenhaTestsFixtures : IDisposable
    {

        private readonly static Faker _faker = new Faker();

        public API.Logica.ValidaSenha CriaValidaSenha()
        {
            return new API.Logica.ValidaSenha();
        }
        public string GerarSenhaValido(int minLength)
        {
            var r = _faker.Internet.Random;
            var rnd = new Random();

            var lowercase = r.Char('a', 'z').ToString();
            var uppercase = r.Char('A', 'Z').ToString();
            var number = r.Char('0', '9').ToString();

            string[] arraySimbol = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+" };
            int asIndex = rnd.Next(arraySimbol.Length);
            var symbol = arraySimbol[asIndex];

            var chars = (lowercase + uppercase + number + symbol
                ).ToList();

            List<char> padding = new List<char>();
            var tamanhoInicial = 4;
            while (tamanhoInicial < minLength)
            {
                var addChar = r.Char('a', 'z');

                if (padding.Any(p => p == addChar) || chars.Any(c => c == addChar))
                {
                    addChar = r.Char('A', 'Z');
                    if (!padding.Any(a => a == addChar) && !chars.Any(c => c == addChar))
                    {
                        padding.Add(addChar);
                        tamanhoInicial++;
                    }
                }
                else
                {
                    padding.Add(addChar);
                    tamanhoInicial++;
                }

            }




            List<char> listaOpcoes = new List<char>();

            listaOpcoes.AddRange(chars);
            listaOpcoes.AddRange(padding);


            var senha = r.Shuffle(listaOpcoes.ToArray()).ToArray();

            return new string(senha);
        }
        public string GerarSenhaNAOValido(int minLength)
        {
            var r = _faker.Internet.Random;
            var rnd = new Random();

            var lowercase = r.Char('a', 'z').ToString();
            var uppercase = r.Char('A', 'Z').ToString();
            var number = r.Char('0', '9').ToString();

            string[] arraySimbol = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+" };
            int asIndex = rnd.Next(arraySimbol.Length);
            var symbol = arraySimbol[asIndex];

            var chars = (lowercase + uppercase + number + symbol
                ).ToList();

            List<char> padding = new List<char>();
            var tamanhoInicial = 4;
            while (tamanhoInicial < minLength)
            {
                var addChar = r.Char('a', 'z');

                if (padding.Any(p => p == addChar) && chars.Any(c => c == addChar))
                {
                    addChar = r.Char('A', 'Z');
                    if (!padding.Any(a => a == addChar) && !chars.Any(c => c == addChar))
                    {
                        padding.Add(addChar);
                        tamanhoInicial++;
                    }
                }
                else
                {
                    padding.Add(addChar);
                    tamanhoInicial++;
                }

            }

            List<char> listaOpcoes = new List<char>();

            listaOpcoes.AddRange(chars);
            listaOpcoes.AddRange(padding);


            var idx = rnd.Next(0, listaOpcoes.Count);
            var charRepetido = listaOpcoes[idx];
            listaOpcoes.Add(charRepetido);

            var senha = r.Shuffle(listaOpcoes.ToArray()).ToArray();

            return new string(senha);
        }

        public void Dispose()
        {
            
        }
    }
}