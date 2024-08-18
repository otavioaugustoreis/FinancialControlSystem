using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

//FEITA
namespace RepositoryPattern.Entity
{
    [Table("TB_GASTO")]
    public class GastoEntity : EntityPattern 
    {

        [Column("nr_valor")]
        [Required]
        public double NrValor { get; set; }

        [Column("ds_local")]
        [Required]
        public string DsLocal { get; set; }

        [Column("fk_categoria")]
        [Required]
        public int FkCategoria { get; set; }

        [JsonIgnore]
        public CategoriaEntity CategoriaEntity { get; set; }

        public UsuarioEntity UsuarioEntity { get; set; }

        [Column("fk_usuario")]
        [Required]
        public int FkUsuario { get; set; }

        public GastoEntity() : base() { }

        public GastoEntity(int id, string DsLocal, CategoriaEntity CategoriaEntity, UsuarioEntity usuario) : base(id, DateTime.Now)
        { 
            this.DsLocal = DsLocal;
            this.CategoriaEntity = CategoriaEntity;
            this.UsuarioEntity = usuario;
        }
    }
}
