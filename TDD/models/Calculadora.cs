using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD.models
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listaHistorico.Insert(0, $"Resultado: {resultado} Data {data}" );
            return resultado;
        }

         public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listaHistorico.Insert(0, $"Resultado: {resultado} Data {data}" );
            return resultado;
            
        }

         public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listaHistorico.Insert(0, $"Resultado: {resultado} Data {data}" );
            return resultado;
            
        }

         public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listaHistorico.Insert(0, $"Resultado: {resultado} Data {data}" );
            return resultado;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count-3);
            return listaHistorico;
        }
    }
}