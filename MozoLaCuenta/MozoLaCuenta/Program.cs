using MozoLaCuenta.Clientes;
using System;

namespace MozoLaCuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Comida asado = new Comida(100);
            ClienteFeliz clienteFeliz = new ClienteFeliz(asado);
            ClienteEnojado clienteEnojado = new ClienteEnojado(asado);
            ClienteIndiferente clienteIndiferente = new ClienteIndiferente(100, asado);

            Console.WriteLine(string.Format("Cliente Feliz paga: {0}", clienteFeliz.calcularCosto()));
            Console.WriteLine(string.Format("Cliente Enojado paga: {0}", clienteEnojado.calcularCosto()));
            Console.WriteLine(string.Format("Cliente Indiferente paga: {0}", clienteIndiferente.calcularCosto()));
                Console.ReadLine();
        }
    }
}
