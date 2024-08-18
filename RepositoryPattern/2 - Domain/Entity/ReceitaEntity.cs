using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public List<CategoriaEntity> CategoriaEntity { get; set; }

        public void AdicionarCategoria(CategoriaEntity categoriaEntity)
        {
            CategoriaEntity.Add(categoriaEntity);
        }
    }
}

