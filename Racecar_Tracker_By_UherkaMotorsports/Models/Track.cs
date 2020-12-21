using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Racecar_Tracker_By_UherkaMotorsports.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        [Column(TypeName = "decimal(10, 8)")]
        public double Latitude { get; set; }
        [Column(TypeName = "decimal(11, 8)")]
        public double Longitude { get; set; }
        public double Gears { get; set; }
    }
}
