using RepositoryPattern.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RepositoryPattern._2___Domain.Entity
{
    [Table("TB_LOGIN")]
    public class LoginEntity : EntityPattern
    {
        public LoginEntity()
        {
        }

        public LoginEntity(int fkUsuario, string dsSenha, int id) : base(id, DateTime.Now)
        {
            FkUsuario = fkUsuario;
            DsSenha = dsSenha;
        }

        public UsuarioEntity Usuario { get; set; }

        [Column("fk_usuario")]
        [Required]
        public int FkUsuario {  get; set; }

        [Column("ds_senha")]
        public string DsSenha { get; set; }


    }
}
