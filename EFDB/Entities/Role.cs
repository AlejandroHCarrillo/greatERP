using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDB.Entities
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? RoleId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<User>? Users { get; set; }
    }
}
