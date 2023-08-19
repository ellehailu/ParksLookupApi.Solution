using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public int YearOfEstablishment { get; set; }
    }
}