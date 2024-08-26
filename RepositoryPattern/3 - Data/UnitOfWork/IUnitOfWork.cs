using RepositoryPattern._2___Domain.Interface;

namespace RepositoryPattern.UnitOfWork
{
   public interface IUnitOfWork
    {

        ICategoria       _Categoria       { get; }
        IGasto           _Gasto           { get; }
        ILogin           _Login           { get; }
        IMesGasto        _MesGasto        { get; }
        IReceita         _Receita         { get; }
        IUsuario         _Usuario         { get; }
        IBanco           _Banco           { get; }
        IReceitaMesGasto _ReceitaMesGasto { get;}
        void Commit();
    }
}
