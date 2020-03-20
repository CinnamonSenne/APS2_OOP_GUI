using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening
{
    internal class BankRekening
    {
        public int Saldo { get; set; }

        public BankRekening(int saldo)
        {
            Saldo = saldo;
        }

        public void StortenSaldo(int getal)
        {
            Saldo += getal;
        }

        public void AfhalenSaldo(int getal)
        {
            Saldo -= getal;
        }

        public override string ToString()
        {
            return $"Saldo: {Saldo}";
        }
    }
}
