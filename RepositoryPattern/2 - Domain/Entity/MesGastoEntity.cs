using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern._2___Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

//Feita
namespace RepositoryPattern.Entity
{
    [Table("TB_MESGASTO")]
    public class MesGastoEntity : EntityPattern
    {

        [Required]
        [Column("ds_mes")]
        public string DsMes { get; set; }

        [Required]
        [Column("vl_total")]
        public int VlTotal { get; set; }

        public MesGastoEntity() { }

        public MesGastoEntity(int month, int vlTotal, int id) : base(id, DateTime.Now)
        {
            DsMes = MonthsName.ReturnMonths(month);
            VlTotal = vlTotal;
        }

        [JsonIgnore]
        public ICollection<ReceitaMesGastoEntity> ReceitaMesGastos { get; set; }


    }
}
