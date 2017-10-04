namespace BotanikaLabs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Plant
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public short? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DatePlanted { get; set; }

        public string ImageURL { get; set; }
    }
}
