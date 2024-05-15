using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class ValyutaDTO
    {
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
