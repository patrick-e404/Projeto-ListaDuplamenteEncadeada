using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
    public class ListaDuplamenteEncadeada
    {
        private Nodo _raiz;

        /* Exercício 1: Lista Duplamente Encadeada 
        Descrição do Problema: Crie uma lista encadeada simples que permita a inserção e remoção de elementos. */

        // Inserir(valor): Insere um elemento no final da lista.

        public void Inserir(int valor)
        {
            Nodo novoNodo = new Nodo(valor);

            if (_raiz == null)
            {
                _raiz = novoNodo;
            }
            else
            {
                Nodo nodo = _raiz;
                while (nodo.Proximo != null)
                {
                    nodo = nodo.Proximo;
                }

                novoNodo.Anterior = nodo;
                nodo.Proximo = novoNodo;
            }
        }

        // Exibir(): Exibe os elementos da lista.
        public void Exibir()
        {
            if (_raiz == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Nodo nodo = _raiz;

            while (nodo != null)
            {
                Console.Write($"{nodo.Conteudo}");

                if (nodo.Proximo != null)
                {
                    Console.Write($" -> ");
                }

                nodo = nodo.Proximo;
            }

            Console.WriteLine("");
        }

        //Remover(valor): Remove a primeira ocorrência do elemento com o valor especificado. 
        public void Remover(int valor)
        {
            if (_raiz == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            if (_raiz.Conteudo == valor)
            {
                _raiz = _raiz.Proximo;
                if (_raiz != null)
                {
                    _raiz.Anterior = null;
                }
                return;
            }

            Nodo nodoAtual = _raiz;

            while (nodoAtual != null && nodoAtual.Conteudo != valor)
            {
                nodoAtual = nodoAtual.Proximo;
            }

            if (nodoAtual == null)
            {
                Console.WriteLine($"Valor não encontrado na lista.");
                return;
            }

            if (nodoAtual.Anterior != null)
            {
                nodoAtual.Anterior.Proximo = nodoAtual.Proximo;
            }

            if (nodoAtual.Proximo != null)
            {
                nodoAtual.Proximo.Anterior = nodoAtual.Anterior;
            }
        }

        /*
       Exercício 2: Contagem de Elementos
       Descrição do Problema: Adicione um método que retorne o número de elementos na lista.
       Métodos Adicionais: - ContarElementos(): Retorna o número de elementos na lista.
        */

        public int ContarElementos()
        {
            int contador = 0;
            Nodo nodo = _raiz;

            while (nodo != null)
            {
                contador++;
                nodo = nodo.Proximo;
            }
            return contador;
        }

        /*
        Exercício 3: Busca por Elemento
        Descrição do Problema: Implemente um método que busque um elemento na lista.
        Métodos Adicionais: - Buscar(valor): Retorna true se o elemento com o valor especificado estiver na lista, senão retorna false.
        */

        public bool Buscar(int valor)
        {
            Nodo nodo = _raiz;

            do
            {
                if (nodo.Conteudo == valor)
                {
                    return true;
                }
                nodo = nodo.Proximo;
            }
            while (nodo != null);

            return false;
        }

        /*
        Exercício 4: Inserção no Início
        Descrição do Problema: Permita a inserção de elementos no início da lista.
        Métodos Adicionais: - InserirNoInicio(valor): Insere um elemento no início da lista.
        */

        public void InserirNoInicio(int valor)
        {
            Nodo novoNodo = new Nodo(valor);

            if (_raiz != null)
            {
                novoNodo.Proximo = _raiz;
                _raiz.Anterior = novoNodo;
            }
            _raiz = novoNodo;
        }



        public void Inverter()
        {
            Nodo nodoAtual = _raiz;
            Nodo nodoAnterior = null;
            Nodo nodoProximo = null;

            while (nodoAtual != null)
            {
                nodoProximo = nodoAtual.Proximo;

                nodoAtual.Proximo = nodoAnterior;
                nodoAtual.Anterior = nodoProximo;

                nodoAnterior = nodoAtual;
                nodoAtual = nodoProximo;
            }
            _raiz = nodoAnterior;
        }

        /*
        Exercício 6: Concatenação de Listas
        Descrição do Problema: Crie um método que concatene duas listas encadeadas.
        Métodos Adicionais: - Concatenar(outraLista): Concatena a lista atual com outra lista encadeada.
         */

        public Nodo PegarUltimoNodo()
        {
            if (_raiz == null)
            {
                return null;
            }

            Nodo nodo = _raiz;
            while (nodo.Proximo != null)
            {
                nodo = nodo.Proximo;
            }
            return nodo;
        }

        public void Concatenar(ListaDuplamenteEncadeada outraLista)
        {
            if (_raiz == null)
            {
                _raiz = outraLista._raiz;
                if (_raiz != null)
                {
                    _raiz.Anterior = null;
                }
            }
            else
            {
                Nodo ultimoNodo = PegarUltimoNodo();

                if (ultimoNodo != null)
                {
                    ultimoNodo.Proximo = outraLista._raiz;

                    if (outraLista._raiz != null)
                    {
                        outraLista._raiz.Anterior = ultimoNodo;
                    }
                }
            }
        }

        /*
        Exercício 7: Remoção de Duplicatas
        Descrição do Problema: Implemente um método que remova elementos duplicados da lista.
        Métodos Adicionais: - RemoverDuplicatas(): Remove elementos duplicados da lista.
         */

        public void RemoverDuplicatas()
        {
            if (_raiz == null || _raiz.Proximo == null)
            {
                return;
            }

            Nodo nodoAtual = _raiz;

            while (nodoAtual != null)
            {
                Nodo nodoComparacao = nodoAtual.Proximo;

                while (nodoComparacao != null)
                {
                    if (nodoComparacao.Conteudo == nodoAtual.Conteudo)
                    {
                        nodoComparacao.Anterior.Proximo = nodoComparacao.Proximo;

                        if (nodoComparacao.Proximo != null)
                        {
                            nodoComparacao.Proximo.Anterior = nodoComparacao.Anterior;
                        }
                    }

                    nodoComparacao = nodoComparacao.Proximo;
                }
                nodoAtual = nodoAtual.Proximo;
            }
        }

        /*
        Exercício 8: Interseção de Listas
        Descrição do Problema: Crie um método que retorne uma nova lista contendo a interseção de duas listas encadeadas.
        Métodos Adicionais: - Intersecao(outraLista): Retorna uma nova lista contendo os elementos que estão presentes em 
        ambas as listas.
         */

        public ListaDuplamenteEncadeada Intersecao(ListaDuplamenteEncadeada outraLista)
        {
            ListaDuplamenteEncadeada resultado = new ListaDuplamenteEncadeada();

            Nodo nodoLista1 = _raiz;

            while (nodoLista1 != null)
            {
                Nodo nodoLista2 = outraLista._raiz;

                while (nodoLista2 != null)
                {
                    if (nodoLista1.Conteudo == nodoLista2.Conteudo)
                    {
                        resultado.Inserir(nodoLista1.Conteudo);
                        break;
                    }

                    nodoLista2 = nodoLista2.Proximo;
                }

                nodoLista1 = nodoLista1.Proximo;
            }
            return resultado;
        }

        /*
       Exercício 9: Ordenação da Lista
       Descrição do Problema: Implemente um método que ordene os elementos da lista em ordem crescente.
       Métodos Adicionais: - Ordenar(): Ordena os elementos da lista em ordem crescente
       */

        public void Ordenar()
        {
            if (_raiz == null || _raiz.Proximo == null)
            {
                return;
            }

            bool troca;

            do
            {
                troca = false;
                Nodo nodoAtual = _raiz;
                Nodo nodoAnterior = null;

                while (nodoAtual.Proximo != null)
                {
                    if (nodoAtual.Conteudo > nodoAtual.Proximo.Conteudo)
                    {
                        Nodo temp = nodoAtual.Proximo;
                        nodoAtual.Proximo = temp.Proximo;
                        temp.Proximo = nodoAtual;

                        temp.Anterior = nodoAtual.Anterior;
                        nodoAtual.Anterior = temp;

                        if (nodoAnterior != null)
                        {
                            nodoAnterior.Proximo = temp;
                        }
                        else
                        {
                            _raiz = temp;
                        }

                        if (nodoAtual.Proximo != null)
                        {
                            nodoAtual.Proximo.Anterior = nodoAtual;
                        }

                        nodoAnterior = temp;
                        troca = true;
                    }
                    else
                    {
                        nodoAnterior = nodoAtual;
                        nodoAtual = nodoAtual.Proximo;
                    }
                }
            }
            while (troca);
        }

        /*
        Exercício 10: Divisão da Lista
        Descrição do Problema: Crie um método que divida uma lista encadeada em duas, de modo que cada nova lista 
        contenha metade dos elementos originais.
        Métodos Adicionais: Dividir(): Divide a lista em duas listas com aproximadamente a mesma quantidade de elementos.
        */

        public ListaDuplamenteEncadeada[] Dividir()
        {
            ListaDuplamenteEncadeada[] listas = new ListaDuplamenteEncadeada[2];
            listas[0] = new ListaDuplamenteEncadeada();
            listas[1] = new ListaDuplamenteEncadeada();

            double metade = ContarElementos() / 2;
            double cont = 0;

            Nodo nodo = _raiz;

            while (nodo != null)
            {
                cont++;

                Nodo proximo = nodo.Proximo;

                if (cont <= metade)
                {
                    listas[0].Inserir(nodo.Conteudo);
                }
                else
                {
                    if (nodo.Anterior != null)
                    {
                        nodo.Anterior.Proximo = null;
                    }

                    listas[1].Inserir(nodo.Conteudo);
                }

                nodo = proximo;
            }
            return listas;
        }
    }
}
