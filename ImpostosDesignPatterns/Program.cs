﻿using System;


namespace ImpostosDesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {

            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(700.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);

            Console.ReadKey();


        }
    }
}
