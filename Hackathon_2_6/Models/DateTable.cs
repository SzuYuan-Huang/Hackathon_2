namespace Hackathon_2_6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DateTable")]
    public partial class DateTable
    {
        public int Id { get; set; }

        [Required]
        public string TickNumber { get; set; }

        public DateTime FlyingDay { get; set; }

        public DateTime Birthday { get; set; }
    }
}
