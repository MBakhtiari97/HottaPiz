using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HottaPiz.DataLayer.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; }
    }
}
