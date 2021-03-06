﻿using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get;  set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public Conta() { }
        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual bool Saca(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}