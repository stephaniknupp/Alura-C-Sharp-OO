﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 8675543);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente um = new ContaCorrente(855, 8552672);


            ContaCorrente dois = new ContaCorrente(755, 7556432);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            Console.ReadLine();

        }
    }
}
