using System.Collections.Generic;

namespace projetosesc.interfaces
{
    public interface IRepositorio <T>
    {

        List<T> Lista();
        T RetornarPorId( int id);
        void Insere(T entidade);

        void exclui (int id);

        void atualizar(int id , T entidade);

        int ProximoId();
         
    }
}