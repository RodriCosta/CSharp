using System;
namespace TrianguloComClasse
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //metodo caucula area do triangulo
        public double CalculaArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }


    }
}
