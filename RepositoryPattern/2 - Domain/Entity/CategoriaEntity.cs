using System.ComponentModel.DataAnnotations.Schema;


//Feito
namespace RepositoryPattern.Entity
{
    [Table("TB_CATEGORIA")]
    public class CategoriaEntity : EntityPattern
    {
        [Column("ds_nome")]
        public string DsNome { get; set; }

        public CategoriaEntity(string dsNome, int id) : base(id, DateTime.Now)
        {
            DsNome = dsNome;
        }
    }
}
