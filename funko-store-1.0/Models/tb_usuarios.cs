//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace funko_store_1._0.Models
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_usuarios()
        {
            this.tb_pedido = new HashSet<tb_pedido>();
        }

        [DisplayName("Cod. Usuario")]
        public string idusu { get; set; }

        [Required(ErrorMessage = "El Usuario es Obligatorio")]
        [DisplayName("Usuario")]
        public string nomusu { get; set; }

        [Required(ErrorMessage = "La Contraseña es Obligatoria")]
        [DisplayName("Contraseña")]
        public string pass { get; set; }

        [DisplayName("Tipo de Usuario")]
        public string tipusu { get; set; }

        [DisplayName("Correo")]
        public string correo { get; set; }

        [DisplayName("Dirección")]
        public string direcenvio { get; set; }

        [DisplayName("Tarjeta")]
        public string tarjeta { get; set; }

        [DisplayName("Estado")]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido> tb_pedido { get; set; }
    }
}
