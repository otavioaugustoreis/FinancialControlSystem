using System.ComponentModel.DataAnnotations.Schema;

//Feita
namespace RepositoryPattern.Entity
{
    [Table("TB_RECEITA")]
    public class ReceitaEntity : EntityPattern
    {
        [Column("ds_nome")]
        public string DsNome { get; set; }

        public ReceitaEntity() { }

        public ReceitaEntity(int id, string DsNome) : base(id, DateTime.Now) {
            this.DsNome = DsNome;
        }
    }
}

