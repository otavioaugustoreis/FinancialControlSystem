using RepositoryPattern._2___Domain.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RepositoryPattern.Entity
{
    [Table("TB_USUARIO")]
    public class UsuarioEntity : EntityPattern
    {
        [Column("ds_nome")]
        [Required]
        public string DsNome { get; set; }

        [Column("ds_cpf")]
        [Required]
        public string DsCPF { get; set; }

        [Column("ds_email")]
        [Required]
        public string DsEmail { get; set; }

        [JsonIgnore]
        public List<GastoEntity> GastosEntity { get; set; }

        [JsonIgnore]
        public LoginEntity LoginEntity { get; set; }

        public UsuarioEntity() : base()
        {
        }

        public UsuarioEntity(string dsNome, string dsCPF, string dsEmail, LoginEntity loginEntity, int id) : base(id, DateTime.Now)
        {
            DsNome = dsNome;
            DsCPF = dsCPF;
            DsEmail = dsEmail;
            LoginEntity = loginEntity;
        }
        public void AdicionarGasto(GastoEntity gastoEntity)
        {
            GastosEntity.Add(gastoEntity);
        }
    }
}
