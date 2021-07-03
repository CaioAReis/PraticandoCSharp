using System;

namespace PraticandoCSharp.Listas
{
    class DuplamenteEncadeada<T> : ILista<T>
    {
        //  Atributos
        private No<T> inicio;
        private No<T> fim;
        private int qtdLista;

        //  Construtor
        public DuplamenteEncadeada()
        {
            this.inicio = null;
            this.fim = null;
            this.qtdLista = 0;
        }

        //  Métodos
        public void adicionarFim(T dado)
        {
            if (existeDado(dado)) throw new Exception("Dado já existente na lista.");

            No<T> novo = new No<T>(dado);
            if (estaVazia())
            {
                inicio = novo;
                fim = novo;
            } else
            {
                fim.Proximo = novo;
                novo.Anterior = fim;
                fim = novo;
            }
            qtdLista++;
        }

        public void adicionarInicio(T dado)
        {
            if (existeDado(dado)) throw new Exception("Dado já existente na lista.");
            if (estaVazia()) 
                adicionarFim(dado);
            else
            {
                No<T> novo = new No<T>(dado);

                inicio.Anterior = novo;
                novo.Proximo = inicio;
                inicio = novo;
                qtdLista++;
            }
        }

        public void adicionarPosicao(T dado, int posicao)
        {
            if (existeDado(dado))
                throw new Exception("Dado já existente na lista.");
            if (posicao < 0 || posicao > qtdLista)
                throw new Exception("Posição fora dos limites da lista.");
            if (posicao == 0)
                adicionarInicio(dado);
            else if (posicao == qtdLista)
                adicionarFim(dado);
            else
            {
                No<T> novo = new No<T>(dado);
                No<T> anterior = buscar(posicao - 1);
                No<T> proximo = buscar(posicao + 1);

                novo.Proximo = proximo;
                proximo.Anterior = novo;

                novo.Anterior = anterior;
                anterior.Proximo = novo;
                qtdLista++;
            }
        }

        public No<T> buscar(int position)
        {
            if (position < 0 || position > qtdLista)
                throw new Exception("Posição fora dos limites da lista.");
            
            return buscar(position, inicio);
        }

        private No<T> buscar(int position, No<T> temp)
        {
            if (position != 0)
            {
                temp = temp.Proximo;
                position--;
                return buscar(position, temp);
            }
            return temp;
        }

        public int buscarPosicao(T dado)
        {
            if (!existeDado(dado))
                throw new Exception("Dado não existente");
            return buscarPosicao(dado, inicio, 0);
        }

        private int buscarPosicao(T dado, No<T> temp, int position)
        {
            if (!temp.Dado.Equals(dado))
            {
                temp = temp.Proximo;
                position++;
                return buscarPosicao(dado, temp, position);
            }
            return position;
        }

        public bool estaVazia() { return qtdLista == 0; }

        public bool existeDado(T dado)
        {
            return existeDado(dado, inicio);
        }

        private bool existeDado(T dado, No<T> temp)
        {
            if (temp != null)
            {
                if (dado.Equals(temp.Dado)) return true;
                else
                {
                    temp = temp.Proximo;
                    return existeDado(dado, temp);
                }
            }
            return false;
        }

        public void LimparLista()
        {
            inicio = null;
            fim = null;
            qtdLista = 0;
        }

        public void listar()
        {
            listar(inicio);
        }

        private void listar(No<T> temp)
        {
            if (temp != null)
            {
                Console.Write(temp.Dado + " | ");
                temp = temp.Proximo;
                listar(temp);
            }
        }

        public void removerFim()
        {
            if (estaVazia())
                throw new Exception("A lista já esta vazia.");
            else
            {
                No<T> novoFim = fim.Anterior;
                fim.Anterior = null;
                novoFim.Proximo = null;
                fim = novoFim;
                qtdLista--;
            }
        }

        public void removerInicio()
        {
            if (estaVazia())
                throw new Exception("A lista já esta vazia.");
            else
            {
                No<T> novoInicio = inicio.Proximo;
                inicio.Proximo = null;
                novoInicio.Anterior = null;
                inicio = novoInicio;
                qtdLista--;
            }
        }

        public void removerPosicao(int posicao)
        {
            if (posicao < 0 || posicao > qtdLista)
                throw new Exception("Posição fora dos limites da lista.");
            if (estaVazia())
                throw new Exception("A lista já esta vazia.");
            else if (posicao == 0)
                removerInicio();
            else if (posicao == qtdLista)
                removerFim();
            else
            {
                No<T> anterior = buscar(posicao - 1);
                No<T> proximo = buscar(posicao + 1);

                anterior.Proximo = proximo;
                proximo.Anterior = anterior;
                qtdLista--;
            }
        }

        public int tamanhoLista() { return qtdLista; }
    }
}
