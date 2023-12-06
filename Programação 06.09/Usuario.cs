﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação_06
{
    public class Usuario
    {

        private int _id;
        private string _nome;
        private string _email;
        private string _CPF;
        private string _senha;
        private string _rua;
        private string _Bairro;
        private string _Numero_casa;


        public Usuario(int id,
                string nome,
                string email,
                string CPF,
                 string senha)
        {
            Id = id;
            _nome = nome;
            _email = email;
            _CPF = CPF;
            _senha = senha;

        }
        public Usuario(string nome, string email, string senha, string CPF)
        {
            _nome = nome;
            _email = email;
            _CPF = CPF;
            _senha = senha;

        }
        public Usuario(string Rua, string Bairro, string Numero)
        {

            _rua = Rua;
            _Bairro = Bairro;
            _Numero_casa = Numero;

        }
        public Usuario(int id, string Rua, string Bairro, string Numero)
        {
            Id = id;
            _rua = Rua;
            _Bairro = Bairro;
            _Numero_casa = Numero;

        }

        public int Id
        {
            set { _id = value; }
            get { return _id; }

        }
        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO Nome");

                _nome = value;
            }
            get { return _nome; }

        }
        public string Email
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO Email");

                _email = value;
            }
            get { return _email; }

        }
        public string CPF
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO CPF");

                _CPF = value;
            }
            get { return _CPF; }

        }
        public string senha
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO senha");

                _senha = value;
            }
            get { return _senha; }

        }
        public string rua
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO rua");

                _rua = value;
            }
            get { return _rua; }

        }
        public string Bairro
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO bairro");

                _Bairro = value;
            }
            get { return _Bairro; }

        }
        public string Numero
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("PREENCHA O CAMPO numero");

                _Numero_casa = value;
            }
            get { return _Numero_casa; }

        }


    }
}
