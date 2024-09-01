using Microsoft.EntityFrameworkCore;
using RepositoryPattern._2___Domain.Concreta;
using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;

namespace RepositoryPattern.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private ICategoria?       Categoria;
        private IGasto?           Gasto;
        private ILogin?           Login;
        private IMesGasto?        MesGasto;
        private IReceita?         Receita;
        private IUsuario?         Usuario;
        private IBanco?           Banco;
        private IRelatorio? ReceitaMesGasto;


        public AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public ILogin _Login
        {
            get
            {
                return Login = Login ?? new LoginDomain(_context);
            }
        }

        public ICategoria _Categoria
        {
            get
            {
                return Categoria = Categoria ?? new CategoriaDomain(_context);
            }
        }
        public IGasto _Gasto
        {
            get
            {
                return Gasto = Gasto ?? new GastoDomain(_context);
            }
        }
        public IMesGasto _MesGasto
        {
            get
            {
                return MesGasto = MesGasto ?? new MesGastoDomain(_context);
            }
        }
        public IReceita _Receita
        {
            get
            {
                return Receita = Receita ?? new ReceitaDomain(_context);
            }
        }

        public IUsuario _Usuario
        {
            get
            {
                return Usuario = Usuario ?? new UsuarioDomain(_context);
            }
        }
        public IBanco _Banco
        {
            get
            {
                return Banco = Banco ?? new BancoDomain(_context);
            }
        }

        public IRelatorio _ReceitaMesGasto
        {
            get
            {
                return ReceitaMesGasto = ReceitaMesGasto ?? new RelatorioDomain(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
