using RepositoryPattern.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RepositoryPattern._2___Domain.Entity
{
    [Table("TB_BANCO")]
    public class BancoEntity : EntityPattern
    {

        [Column("ds_nome")]
        [Required]
        public string DsNome { get; set; }

        [Column("nr_saldo")]
        [Required]
        public decimal NrSaldo { get; set; }

        [JsonIgnore]
        public List<GastoEntity> GastoEntity { get; set; }

        public UsuarioEntity UsuarioEntity { get; set; }

        [Column("fk_usuario")]
        [Required]
        public int FKUsuario { get; set; }

        public BancoEntity() { }

        public BancoEntity(string dsNome, UsuarioEntity usuarioEntity, int id, GastoEntity GastoEntity) : base(id, DateTime.Now)
        {
            DsNome = dsNome;
            UsuarioEntity = usuarioEntity;
            FKUsuario = UsuarioEntity.Id ;
            AdicionarGasto(GastoEntity);
        }

        public void AdicionarGasto(GastoEntity gastoEntity) => GastoEntity.Add(gastoEntity);

    }
}
