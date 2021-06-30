using System;

namespace PraticandoCSharp.Listas
{
    class ListaSimplesEncadeada<T> : ILista<T>
    {
        //  Atributos
        private No<T> inicio;
        private No<T> fim;
        private int qtdList;

        // Construtor
        public ListaSimplesEncadeada()
        {
            this.inicio = null;
            this.fim = null;
            this.qtdList = 0;
        }

        //  Metodos
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
                fim = novo;
            }
            qtdList++;
        }

        public void adicionarInicio(T dado)
        {
            if (existeDado(dado)) throw new Exception("Dado já existente na lista.");
            if (estaVazia()) adicionarFim(dado);
            else
            {
                No<T> novo = new No<T>(dado);
                novo.Proximo = inicio;
                inicio = novo;
                qtdList++;
            }
        }

        public void adicionarPosicao(T dado, int posicao)
        {
            if (existeDado(dado)) throw new Exception("Dado já existente na lista.");
            if (posicao < 0 || posicao > qtdList)
            {
                throw new Exception("Posição inválida");
            }
            else if (posicao == 0) adicionarInicio(dado);
            else if (posicao == qtdList) adicionarFim(dado);
            else
            {
                No<T> novo = new No<T>(dado);
                No<T> anterior = buscar(posicao - 1);

                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
                qtdList++;
            }
        }

        public No<T> buscar(int posicao)
        {
            if (posicao < 0 || posicao > qtdList) throw new Exception("Posição inválida.");
            return buscar(inicio, posicao);
        }

        private No<T> buscar(No<T> temp, int position) 
        {
            if (position != 0)
            {
                temp = temp.Proximo;
                position--;
                return buscar(temp, position);
            }
            return temp;
        }

        public int buscarPosicao(T dado)
        {
            if (existeDado(dado))
                return buscarPosicao(dado, inicio, 0);
            else throw new Exception("Valor não existente!");
        }

        private int buscarPosicao(T dado, No<T> temp, int posicao)
        {
            if (!temp.Dado.Equals(dado))
            {
                temp = temp.Proximo;
                posicao++;
                return buscarPosicao(dado, temp, posicao);
            }
            return posicao;
        }

        public bool estaVazia() { return qtdList == 0; }

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
            qtdList = 0;
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
            if (qtdList == 0) throw new Exception("A lista já esta vazia.");
            else
            {
                int posicaoFim = buscarPosicao(fim.Dado);
                No<T> anterior = buscar(posicaoFim - 1);
                anterior.Proximo = null;
                fim = anterior;
                qtdList--;
            }
        }

        public void removerInicio()
        {
            if (qtdList == 0) throw new Exception("A lista já esta vazia.");
            else
            {
                No<T> proximo = buscar(1);
                inicio.Proximo = null;
                inicio = proximo;
                qtdList--;
            }
        }

        public void removerPosicao(int posicao)
        {
            if (qtdList == 0) throw new Exception("A lista já esta vazia.");
            else if (posicao == 0) removerInicio();
            else if (posicao == buscarPosicao(fim.Dado)) removerFim();
            else
            {
                No<T> anterior = buscar(posicao - 1);
                No<T> proximo = buscar(posicao + 1);
                anterior.Proximo = proximo;
                qtdList--;
            }
        }

        public int tamanhoLista()
        {
            return qtdList;
        }
    }
}
