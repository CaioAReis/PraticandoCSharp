using System;
using System.Collections.Generic;

namespace PraticandoCSharp.Listas
{
    public class No<T>
    {
        //  Atributos
        private T dado;
        private No<T> proximo;
        private No<T> anterior;

        //  Construtor
        public No (T dado)
        {
            this.dado = dado;
            this.anterior = null;
            this.proximo = null;
        }
        
        //  Propriedade Acessoras e Modificadoras
        public T Dado 
        { 
            get { return dado; } 
            set { dado = value; }
        }

        public No<T> Proximo 
        {
            get { return proximo; } 
            set { proximo = value; } 
        }

        public No<T> Anterior 
        {   get { return anterior; }
            set { anterior = value; } 
        }

        public override bool Equals(object obj)
        {
            return obj is No<T> no &&
                   EqualityComparer<T>.Default.Equals(dado, no.dado) &&
                   EqualityComparer<T>.Default.Equals(Dado, no.Dado);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(dado, Dado);
        }
    }
}
