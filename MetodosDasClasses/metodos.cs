using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class metodos
    {
        //metodo simpels
        public void Cumprimentar() 
        {
            Console.WriteLine("Ola,seja bem-vindo!!");
        }

        //metodos com parametros
        public void Somar (int num1, int num2)
        {
            int Resultado = num1 + num2;
            Console.WriteLine("A soma é: " + Resultado);
        }

        public void Apresentar (string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }

        //passagem de parametros por valor
        public void AumentarValor( int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final: " + valor);
        }

        // Passagem de parametros por referencia 
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final: " + valor);
        }
        
        // metodos com retorno de valores
        public string MontaNome (string nome, string sobrenome)
        {
            string nomecompleto = nome + " " + sobrenome;
            return nomecompleto;
        }

        public int codigoChar (char caractere)
        {
          //int codigo = (int )caractere;
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;        
        }

        //sobre carga de metodos
        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia" + nome : "Boa tarde" + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar (int num1, int num2) 
        {
            return num1 == num2;
        }

        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }

    }
}
