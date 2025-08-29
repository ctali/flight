using System.ComponentModel.DataAnnotations;

namespace FlightInformationAPI.Models
{
    public enum FlightStatus
    {
        Scheduled,
        Delayed,
        Cancelled,    // Fixed spelling to match CSV
        InAir,
        Landed
    }

    public class Flight
    {
        public int Id { get; set; }
        
        [Required]
        public string FlightNumber { get; set; } = string.Empty;
        
        [Required]
        public string Airline { get; set; } = string.Empty;
        
        [Required]
        public string DepartureAirport { get; set; } = string.Empty;
        
        [Required]
        public string ArrivalAirport { get; set; } = string.Empty;
        
        [Required]
        public DateTime DepartureTime { get; set; }
        
        [Required]
        public DateTime ArrivalTime { get; set; }
        
        [Required]
        public FlightStatus Status { get; set; }
    }
}