using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Valyuta
    {
        [Key]
        public int ID { get; set; }
        public string? Adi { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(10,4)")]
        public decimal Alis { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(10,4)")]
        public decimal Satis { get; set; }

        public DateTime YenilemeTarixi { get; set; }
    }
}
