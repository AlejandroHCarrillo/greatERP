using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDB.Entities
{
    public class Proveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ProveedorId { get; set; }
        
        [Required, MaxLength(80) ]
        public string Name { get; set; }
        
        [Required, MaxLength(15) ]
        public string Code { get; set; }
        
        [Required, MaxLength(200) ]
        public string Descripcion { get; set; }

        public virtual ICollection<FacturaProveedor>? FacturasProveedor { get; set; }
    }
}
