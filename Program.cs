using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    public class Program
    {
        public Program()
        {
            ListaDuplamenteEncadeada lista = new ListaDuplamenteEncadeada();

            // Exercício 1: Lista Encadeada Simples Básica
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Exibir(); // Saída: 10 -> 20 -> 30
            lista.Remover(20);
            lista.Exibir(); // Saída: 10 -> 30
            */


            // Exercício 2: Contagem de Elementos
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            int count = lista.ContarElementos();
            Console.WriteLine($"Número de elementos: {count}"); // Saída: Número de elementos: 3
            */


            // Exercício 3: Busca por Elemento
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            bool found = lista.Buscar(20);
            Console.WriteLine(found); // Saída: True
            bool notFound = lista.Buscar(40);
            Console.WriteLine(notFound); // Saída: False
            */


            // Exercício 4: Inserção no Início
            /*
            lista.Inserir(20);
            lista.InserirNoInicio(10);
            lista.Exibir(); // Saída: 10 -> 20
            */


            // Exercício 5: Inversão da Lista
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inverter();
            lista.Exibir(); // Saída: 30 -> 20 -> 10
            */


            // Exercício 6: Concatenação de Listas
            /*
            ListaDuplamenteEncadeada lista1 = new ListaDuplamenteEncadeada();
            lista1.Inserir(10);
            lista1.Inserir(20);
            ListaDuplamenteEncadeada lista2 = new ListaDuplamenteEncadeada();
            lista2.Inserir(30);
            lista2.Inserir(40);
            lista1.Concatenar(lista2);
            lista1.Exibir(); // Saída: 10 -> 20 -> 30 -> 40
            */


            // Exercício 7: Remoção de Duplicatas
            /*
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(10);
            lista.Inserir(30);
            lista.RemoverDuplicatas();
            lista.Exibir(); // Saída: 10 -> 20 -> 30
            */


            // Exercício 8: Interseção de Listas
            /*
            ListaDuplamenteEncadeada lista1 = new ListaDuplamenteEncadeada();
            lista1.Inserir(10);
            lista1.Inserir(20);
            lista1.Inserir(30);
            ListaDuplamenteEncadeada lista2 = new ListaDuplamenteEncadeada();
            lista2.Inserir(20);
            lista2.Inserir(30);
            lista2.Inserir(40);
            ListaDuplamenteEncadeada intersecao = lista1.Intersecao(lista2);
            intersecao.Exibir(); // Saída: 20 -> 30
            */


            // Exercício 9: Ordenação da Lista
            /*
            lista.Inserir(30);
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Ordenar();
            lista.Exibir(); // Saída: 10 -> 20 -> 30
            */


            // Exercício 10: Divisão da Lista

            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inserir(40);
            ListaDuplamenteEncadeada[] listasDivididas = lista.Dividir();
            listasDivididas[0].Exibir(); // Saída: 10 -> 20
            listasDivididas[1].Exibir(); // Saída: 30 -> 40

        }
        static void Main(string[] args)
        {
            Program exec = new Program();
            Console.ReadKey();
        }
    }
}
