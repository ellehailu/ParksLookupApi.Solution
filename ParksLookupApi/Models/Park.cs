namespace ParksLookupApi.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Designation { get; set; }

        public DateTime DateOfEstablishment { get; set; }
    }
}