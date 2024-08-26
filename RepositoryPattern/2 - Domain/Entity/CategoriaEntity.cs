using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


//Feito
namespace RepositoryPattern.Entity
{
    [Table("TB_CATEGORIA")]
    public class CategoriaEntity : EntityPattern
    {
        [Column("ds_nome")]
        public string DsNome { get; set; }

        public CategoriaEntity(string dsNome, int id, ReceitaEntity receitaEntities) : base(id, DateTime.Now)
        {
            DsNome = dsNome;
            ReceitaEntities = receitaEntities;
            FkReceita = ReceitaEntities.Id;
        }

        [JsonIgnore]
        public List<GastoEntity> GastoEntities { get; set; }

        [Column("fk_receita")]
        [JsonIgnore]
        public int FkReceita  { get; set; }
        
        public ReceitaEntity ReceitaEntities { get; set; }

    }
}
