using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDB.Entities
{
    public class FacturaProveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? FacturaProveedorId { get; set; }

        [Required, MaxLength(50)]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaFactura { get; set; }

        [Required]
        public Decimal MontoTotal { get; set; }

        [Required]
        public Decimal MontoPagado { get; set; }

        [MaxLength(100)]
        public string Notas { get; set; }

        public string StatusFactura { get; set; }

        public virtual ICollection<Proveedor>? Proveedores { get; set; }

    }
}
