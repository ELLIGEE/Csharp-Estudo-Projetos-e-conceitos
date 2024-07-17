using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Conta
    {
        public string _cliente;
        public double _saldo;
        private double _taxa = 10;

        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if (value != "João" && value != "Logan")
                {
                    _cliente = "Visitante";
                    Saldo = 0;
                }
                else { _cliente = value; Saldo = 100; }
            }
        }

            public double Saldo 
            {
                get 
            { return _saldo; }
            private set { _saldo = value; }
            }

            public void Depositar(double valor)
            {
            valor += _taxa;
            _saldo += valor;
             }

             public void Sacar(double valor)
             {
            _saldo = valor;
             }


    }

    }



