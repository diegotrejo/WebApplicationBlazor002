using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationBlazor002.Models
{
    public class Proveedor
    {
        [Key]
        public int Codigo { get; set; }

        [DataType(DataType.EmailAddress)]
        public string RUC { get; set; }

        [Range(10, 100,ErrorMessage ="Dato fuera de rango")]
        public string RazonSocial { get; set; }

        [Display(Name ="Dirección del domicilio")]
        public string Direccion {  get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="dato obligatorio")]
        public string Telefono { get; set; }

        // propieadades de navegacion
        public List<Producto> Productos { get; set; }
    }
}
