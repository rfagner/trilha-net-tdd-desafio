using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.models
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;
        public Calculadora(string data)
        {
            ListaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;

            ListaHistorico.Insert(0, "Res: " + resultado + "Data: " + data );

            return resultado;
        }

        public int Subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;

            ListaHistorico.Insert(0, "Res: " + resultado + "Data: " + data);

            return resultado;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;

            ListaHistorico.Insert(0, "Res: " + resultado + "Data: " + data);

            return resultado;
        }

        public int Dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;

            ListaHistorico.Insert(0, "Res: " + resultado + "Data: " + data);

            return resultado;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}