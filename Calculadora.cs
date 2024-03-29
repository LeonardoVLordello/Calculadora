using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
     public class Calculadora
    {
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
         public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
         public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
         public void dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
        Console.WriteLine($"{x}ˆ{y} = {pot}");
        }
         public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI/180;
            double Seno = Math.Sin(radiano);
        Console.WriteLine($"seno de {angulo}* = {Math.Round(Seno,4)}");
        }
         public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI/180;
            double Coseno = Math.Cos(radiano);
        Console.WriteLine($"coseno de {angulo}* = {Math.Round(Coseno,4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI/180; // representa o PI
            double Tangente = Math.Tan(radiano);
        Console.WriteLine($"Tangente de {angulo}* = {Math.Round(Tangente,4)}");  //math esta arredondando 
        }
        public void RaizQuadrado(double x)
        {
        double raiz = Math.Sqrt(x);
        Console.WriteLine($"Raiz Quadrada de {x} = {raiz}");
        }
    }
}