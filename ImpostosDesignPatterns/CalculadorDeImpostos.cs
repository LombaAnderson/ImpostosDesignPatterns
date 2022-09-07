﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace ImpostosDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
            
        }
      
    }
}
