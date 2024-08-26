using RepositoryPattern.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RepositoryPattern._2___Domain.Entity
{
    [Table("TB_RECEITAMESGASTO")]
    public class ReceitaMesGastoEntity : EntityPattern
    {
        [Column("nr_valor")]
        [Required]
        public Int32 NrValor {  get; set; }

        [Column("fk_receita")]
        [Required]
        public int FkReceita { get; set; }
        
        [JsonIgnore]
        public ReceitaEntity ReceitaEntity { get; set; }

        [Column("fk_mesgasto")]
        [Required]
        public int FkMesGasto { get; set; }

        [JsonIgnore]
        public MesGastoEntity MesGastoEntity { get; set; }

        public ReceitaMesGastoEntity() : base()
        {
        }

        public ReceitaMesGastoEntity(int id, MesGastoEntity MesGastoEntity, ReceitaEntity ReceitaEntity) : base(id, DateTime.Now)
        {
            this.MesGastoEntity = MesGastoEntity; 
            this.ReceitaEntity  =  ReceitaEntity;
            this.FkReceita      = ReceitaEntity.Id;
            this.FkMesGasto     = MesGastoEntity.Id;
        }
    }
}
