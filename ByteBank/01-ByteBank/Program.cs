using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriella = new ContaCorrente();
            contaDaGabriella.titular = "Gabriella";
            contaDaGabriella.agencia = 863;
            contaDaGabriella.numero = 863452;
            contaDaGabriella.saldo = 100;

            Console.WriteLine(contaDaGabriella.titular);
            Console.WriteLine("Agência: " + contaDaGabriella.agencia);
            Console.WriteLine("Número: " +contaDaGabriella.numero);
            Console.WriteLine("Saldo: " +contaDaGabriella.saldo);

            contaDaGabriella.saldo += 200;

            Console.WriteLine("Saldo: " + contaDaGabriella.saldo);



            Console.ReadLine();
        }
    }
}
