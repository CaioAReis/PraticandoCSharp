
namespace PraticandoCSharp.Listas
{
    interface ILista<T>
    {
        // Adicionar
        void adicionarFim(T dado);
        void adicionarInicio(T dado);
        void adicionarPosicao(T dado, int posicao);
        // Remover
        void removerFim();
        void removerInicio();
        void removerPosicao(int posicao);
        // Buscar
        No<T> buscar(int position);
        int buscarPosicao(T dado);
        bool existeDado(T dado);
        // Tamanho da lista
        int tamanhoLista();
        //  Limpar a lista
        void LimparLista();
        //  Está vazia?
        bool estaVazia();
        //  Listar
        void listar();
    }
}
