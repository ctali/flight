using FlightInformationAPI.Data;
using FlightInformationAPI.Models;

namespace FlightInformationAPI.Services
{
    public class DataSeeder
    {
        public static void Initialize(FlightContext context)
        {
            if (!context.Flights.Any())
            {
                var flights = new List<Flight>
                {
                    new Flight { Id = 1, FlightNumber = "AI101", Airline = "Air New Zealand", DepartureAirport = "CHC", ArrivalAirport = "SYD", DepartureTime = DateTime.Parse("2025-06-24T23:00:00"), ArrivalTime = DateTime.Parse("2025-06-25T11:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 2, FlightNumber = "VI102", Airline = "Virgin Australia", DepartureAirport = "AKL", ArrivalAirport = "DXB", DepartureTime = DateTime.Parse("2025-06-20T11:00:00"), ArrivalTime = DateTime.Parse("2025-06-20T17:00:00"), Status = FlightStatus.Delayed },
new Flight { Id = 3, FlightNumber = "QA103", Airline = "Qantas", DepartureAirport = "NPE", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-18T05:00:00"), ArrivalTime = DateTime.Parse("2025-06-18T11:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 4, FlightNumber = "JE104", Airline = "Jetstar", DepartureAirport = "ZQN", ArrivalAirport = "DXB", DepartureTime = DateTime.Parse("2025-06-06T07:00:00"), ArrivalTime = DateTime.Parse("2025-06-06T09:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 5, FlightNumber = "QA105", Airline = "Qantas", DepartureAirport = "DUD", ArrivalAirport = "SYD", DepartureTime = DateTime.Parse("2025-06-30T20:00:00"), ArrivalTime = DateTime.Parse("2025-07-01T06:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 6, FlightNumber = "JE106", Airline = "Jetstar", DepartureAirport = "AKL", ArrivalAirport = "LAX", DepartureTime = DateTime.Parse("2025-06-01T11:00:00"), ArrivalTime = DateTime.Parse("2025-06-01T17:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 7, FlightNumber = "JE107", Airline = "Jetstar", DepartureAirport = "NSN", ArrivalAirport = "LAX", DepartureTime = DateTime.Parse("2025-06-22T17:00:00"), ArrivalTime = DateTime.Parse("2025-06-23T05:00:00"), Status = FlightStatus.Delayed },
new Flight { Id = 8, FlightNumber = "AI108", Airline = "Air New Zealand", DepartureAirport = "CHC", ArrivalAirport = "MEL", DepartureTime = DateTime.Parse("2025-06-03T08:00:00"), ArrivalTime = DateTime.Parse("2025-06-03T10:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 9, FlightNumber = "QA109", Airline = "Qantas", DepartureAirport = "ZQN", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-19T18:00:00"), ArrivalTime = DateTime.Parse("2025-06-19T23:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 10, FlightNumber = "VI110", Airline = "Virgin Australia", DepartureAirport = "NPE", ArrivalAirport = "DXB", DepartureTime = DateTime.Parse("2025-06-20T16:00:00"), ArrivalTime = DateTime.Parse("2025-06-20T22:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 11, FlightNumber = "VI111", Airline = "Virgin Australia", DepartureAirport = "NSN", ArrivalAirport = "BNE", DepartureTime = DateTime.Parse("2025-06-16T22:00:00"), ArrivalTime = DateTime.Parse("2025-06-17T10:00:00"), Status = FlightStatus.Delayed },
new Flight { Id = 12, FlightNumber = "QA112", Airline = "Qantas", DepartureAirport = "NSN", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-28T12:00:00"), ArrivalTime = DateTime.Parse("2025-06-28T21:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 13, FlightNumber = "JE113", Airline = "Jetstar", DepartureAirport = "NPE", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-15T22:00:00"), ArrivalTime = DateTime.Parse("2025-06-16T02:00:00"), Status = FlightStatus.Delayed },
new Flight { Id = 14, FlightNumber = "AI114", Airline = "Air New Zealand", DepartureAirport = "CHC", ArrivalAirport = "MEL", DepartureTime = DateTime.Parse("2025-06-25T04:00:00"), ArrivalTime = DateTime.Parse("2025-06-25T15:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 15, FlightNumber = "FI115", Airline = "Fiji Airways", DepartureAirport = "DUD", ArrivalAirport = "SYD", DepartureTime = DateTime.Parse("2025-06-22T11:00:00"), ArrivalTime = DateTime.Parse("2025-06-22T19:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 16, FlightNumber = "FI116", Airline = "Fiji Airways", DepartureAirport = "DUD", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-11T07:00:00"), ArrivalTime = DateTime.Parse("2025-06-11T18:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 17, FlightNumber = "EM117", Airline = "Emirates", DepartureAirport = "DUD", ArrivalAirport = "DXB", DepartureTime = DateTime.Parse("2025-06-08T21:00:00"), ArrivalTime = DateTime.Parse("2025-06-09T04:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 18, FlightNumber = "VI118", Airline = "Virgin Australia", DepartureAirport = "AKL", ArrivalAirport = "BNE", DepartureTime = DateTime.Parse("2025-06-23T15:00:00"), ArrivalTime = DateTime.Parse("2025-06-23T20:00:00"), Status = FlightStatus.Delayed },
new Flight { Id = 19, FlightNumber = "AI119", Airline = "Air New Zealand", DepartureAirport = "DUD", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-03T05:00:00"), ArrivalTime = DateTime.Parse("2025-06-03T13:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 20, FlightNumber = "FI120", Airline = "Fiji Airways", DepartureAirport = "ZQN", ArrivalAirport = "BNE", DepartureTime = DateTime.Parse("2025-06-28T21:00:00"), ArrivalTime = DateTime.Parse("2025-06-29T03:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 21, FlightNumber = "JE121", Airline = "Jetstar", DepartureAirport = "NSN", ArrivalAirport = "BNE", DepartureTime = DateTime.Parse("2025-06-24T17:00:00"), ArrivalTime = DateTime.Parse("2025-06-25T01:00:00"), Status = FlightStatus.Delayed },
new Flight { Id = 22, FlightNumber = "VI122", Airline = "Virgin Australia", DepartureAirport = "AKL", ArrivalAirport = "LAX", DepartureTime = DateTime.Parse("2025-06-30T23:00:00"), ArrivalTime = DateTime.Parse("2025-07-01T09:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 23, FlightNumber = "AI123", Airline = "Air New Zealand", DepartureAirport = "ZQN", ArrivalAirport = "DXB", DepartureTime = DateTime.Parse("2025-06-05T03:00:00"), ArrivalTime = DateTime.Parse("2025-06-05T08:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 24, FlightNumber = "EM124", Airline = "Emirates", DepartureAirport = "CHC", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-12T03:00:00"), ArrivalTime = DateTime.Parse("2025-06-12T15:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 25, FlightNumber = "AI125", Airline = "Air New Zealand", DepartureAirport = "WLG", ArrivalAirport = "LAX", DepartureTime = DateTime.Parse("2025-06-06T16:00:00"), ArrivalTime = DateTime.Parse("2025-06-07T04:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 26, FlightNumber = "JE126", Airline = "Jetstar", DepartureAirport = "AKL", ArrivalAirport = "DXB", DepartureTime = DateTime.Parse("2025-06-03T05:00:00"), ArrivalTime = DateTime.Parse("2025-06-03T15:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 27, FlightNumber = "FI127", Airline = "Fiji Airways", DepartureAirport = "NPE", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-19T18:00:00"), ArrivalTime = DateTime.Parse("2025-06-19T21:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 28, FlightNumber = "JE128", Airline = "Jetstar", DepartureAirport = "NPE", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-10T16:00:00"), ArrivalTime = DateTime.Parse("2025-06-10T20:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 29, FlightNumber = "QA129", Airline = "Qantas", DepartureAirport = "ZQN", ArrivalAirport = "LAX", DepartureTime = DateTime.Parse("2025-06-04T07:00:00"), ArrivalTime = DateTime.Parse("2025-06-04T17:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 30, FlightNumber = "VI130", Airline = "Virgin Australia", DepartureAirport = "AKL", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-05T22:00:00"), ArrivalTime = DateTime.Parse("2025-06-06T00:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 31, FlightNumber = "VI131", Airline = "Virgin Australia", DepartureAirport = "WLG", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-26T06:00:00"), ArrivalTime = DateTime.Parse("2025-06-26T08:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 32, FlightNumber = "JE132", Airline = "Jetstar", DepartureAirport = "NSN", ArrivalAirport = "DXB", DepartureTime = DateTime.Parse("2025-07-02T04:00:00"), ArrivalTime = DateTime.Parse("2025-07-02T13:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 33, FlightNumber = "VI133", Airline = "Virgin Australia", DepartureAirport = "WLG", ArrivalAirport = "SYD", DepartureTime = DateTime.Parse("2025-06-07T21:00:00"), ArrivalTime = DateTime.Parse("2025-06-08T03:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 34, FlightNumber = "JE134", Airline = "Jetstar", DepartureAirport = "CHC", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-06T06:00:00"), ArrivalTime = DateTime.Parse("2025-06-06T08:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 35, FlightNumber = "FI135", Airline = "Fiji Airways", DepartureAirport = "NSN", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-17T23:00:00"), ArrivalTime = DateTime.Parse("2025-06-18T07:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 36, FlightNumber = "FI136", Airline = "Fiji Airways", DepartureAirport = "CHC", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-30T16:00:00"), ArrivalTime = DateTime.Parse("2025-06-30T21:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 37, FlightNumber = "AI137", Airline = "Air New Zealand", DepartureAirport = "DUD", ArrivalAirport = "DXB", DepartureTime = DateTime.Parse("2025-06-14T15:00:00"), ArrivalTime = DateTime.Parse("2025-06-15T00:00:00"), Status = FlightStatus.Delayed },
new Flight { Id = 38, FlightNumber = "FI138", Airline = "Fiji Airways", DepartureAirport = "NPE", ArrivalAirport = "MEL", DepartureTime = DateTime.Parse("2025-06-14T03:00:00"), ArrivalTime = DateTime.Parse("2025-06-14T09:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 39, FlightNumber = "VI139", Airline = "Virgin Australia", DepartureAirport = "DUD", ArrivalAirport = "SYD", DepartureTime = DateTime.Parse("2025-06-15T19:00:00"), ArrivalTime = DateTime.Parse("2025-06-16T06:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 40, FlightNumber = "EM140", Airline = "Emirates", DepartureAirport = "CHC", ArrivalAirport = "LAX", DepartureTime = DateTime.Parse("2025-06-06T19:00:00"), ArrivalTime = DateTime.Parse("2025-06-07T02:00:00"), Status = FlightStatus.Delayed },
new Flight { Id = 41, FlightNumber = "SI141", Airline = "Singapore Airlines", DepartureAirport = "DUD", ArrivalAirport = "FJI", DepartureTime = DateTime.Parse("2025-06-17T13:00:00"), ArrivalTime = DateTime.Parse("2025-06-17T21:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 42, FlightNumber = "JE142", Airline = "Jetstar", DepartureAirport = "AKL", ArrivalAirport = "SYD", DepartureTime = DateTime.Parse("2025-06-10T23:00:00"), ArrivalTime = DateTime.Parse("2025-06-11T10:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 43, FlightNumber = "SI143", Airline = "Singapore Airlines", DepartureAirport = "DUD", ArrivalAirport = "LAX", DepartureTime = DateTime.Parse("2025-06-06T18:00:00"), ArrivalTime = DateTime.Parse("2025-06-06T21:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 44, FlightNumber = "QA144", Airline = "Qantas", DepartureAirport = "AKL", ArrivalAirport = "BNE", DepartureTime = DateTime.Parse("2025-06-27T22:00:00"), ArrivalTime = DateTime.Parse("2025-06-28T07:00:00"), Status = FlightStatus.Scheduled },
new Flight { Id = 45, FlightNumber = "FI145", Airline = "Fiji Airways", DepartureAirport = "NPE", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-22T05:00:00"), ArrivalTime = DateTime.Parse("2025-06-22T15:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 46, FlightNumber = "FI146", Airline = "Fiji Airways", DepartureAirport = "NSN", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-18T09:00:00"), ArrivalTime = DateTime.Parse("2025-06-18T11:00:00"), Status = FlightStatus.Landed },
new Flight { Id = 47, FlightNumber = "FI147", Airline = "Fiji Airways", DepartureAirport = "WLG", ArrivalAirport = "MEL", DepartureTime = DateTime.Parse("2025-06-03T11:00:00"), ArrivalTime = DateTime.Parse("2025-06-03T13:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 48, FlightNumber = "FI148", Airline = "Fiji Airways", DepartureAirport = "WLG", ArrivalAirport = "LAX", DepartureTime = DateTime.Parse("2025-06-13T16:00:00"), ArrivalTime = DateTime.Parse("2025-06-13T23:00:00"), Status = FlightStatus.InAir },
new Flight { Id = 49, FlightNumber = "VI149", Airline = "Virgin Australia", DepartureAirport = "NSN", ArrivalAirport = "BNE", DepartureTime = DateTime.Parse("2025-06-29T05:00:00"), ArrivalTime = DateTime.Parse("2025-06-29T15:00:00"), Status = FlightStatus.Cancelled },
new Flight { Id = 50, FlightNumber = "JE150", Airline = "Jetstar", DepartureAirport = "WLG", ArrivalAirport = "SIN", DepartureTime = DateTime.Parse("2025-06-30T15:00:00"), ArrivalTime = DateTime.Parse("2025-07-01T02:00:00"), Status = FlightStatus.InAir }
                };

                context.Flights.AddRange(flights);
                context.SaveChanges();
            }
        }
    }
}