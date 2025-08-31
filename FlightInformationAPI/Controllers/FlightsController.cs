using FlightInformationAPI.Data;
using FlightInformationAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlightInformationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly FlightContext _context;
        private readonly ILogger<FlightsController> _logger;

        public FlightsController(FlightContext context, ILogger<FlightsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Flights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetFlights()
        {
            _logger.LogInformation("Getting all flights");
            return await _context.Flights.ToListAsync();
        }

        // GET: api/Flights/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            _logger.LogInformation("Getting flight with ID: {FlightId}", id);
            var flight = await _context.Flights.FindAsync(id);

            if (flight == null)
            {
                _logger.LogWarning("{FlightId} not found", id);
                return NotFound();
            }

            return flight;
        }
        // POST: api/Flights
[HttpPost]
public async Task<ActionResult<Flight>> PostFlight(Flight flight)
{
    try
    {
        _context.Flights.Add(flight);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetFlight), new { id = flight.Id }, flight);
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error creating flight");
        return StatusCode(500, "Internal server error");
    }
}

        // PUT: api/Flights/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlight(int id, Flight flight)
        {
            if (id != flight.Id)
            {
                return BadRequest("ID mismatch");
            }

            try
            {
                _context.Entry(flight).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error updating flight with ID: {id}");
                return StatusCode(500, "Internal server error");
            }

            return NoContent();
        }

// GET: api/Flights/search
[HttpGet("search")]
public async Task<ActionResult<IEnumerable<Flight>>> SearchFlights(
    [FromQuery] string? airline,
    [FromQuery] string? departureAirport,
    [FromQuery] string? arrivalAirport,
    [FromQuery] DateTime? startDate,
    [FromQuery] DateTime? endDate,
    [FromQuery] FlightStatus? status)
{
    try
    {
        var query = _context.Flights.AsQueryable();

        if (!string.IsNullOrEmpty(airline))
            query = query.Where(f => f.Airline.Contains(airline));
        
        if (!string.IsNullOrEmpty(departureAirport))
            query = query.Where(f => f.DepartureAirport.Contains(departureAirport));
        
        if (!string.IsNullOrEmpty(arrivalAirport))
            query = query.Where(f => f.ArrivalAirport.Contains(arrivalAirport));
        
        if (startDate.HasValue)
            query = query.Where(f => f.DepartureTime >= startDate.Value);
        
        if (endDate.HasValue)
            query = query.Where(f => f.DepartureTime <= endDate.Value);
        
        if (status.HasValue)
            query = query.Where(f => f.Status == status.Value);

        var results = await query.ToListAsync();
        return Ok(results);
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error searching flights");
        return StatusCode(500, "Internal server error");
    }
}

        // DELETE: api/Flights/5
        [HttpDelete("{id}")]
public async Task<IActionResult> DeleteFlight(int id)
{
    try
    {
        var flight = await _context.Flights.FindAsync(id);
        if (flight == null)
        {
            return NotFound();
        }

        _context.Flights.Remove(flight);
        await _context.SaveChangesAsync();

        return NoContent();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, $"Error deleting flight with ID: {id}");
        return StatusCode(500, "Internal server error");
    }
}

private bool FlightExists(int id)
{
    return _context.Flights.Any(e => e.Id == id);
}

    }
}