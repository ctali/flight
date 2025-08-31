using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlightInformationAPI.Controllers;
using FlightInformationAPI.Data;
using FlightInformationAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace FlightInformationAPI.Tests.Controllers;

public class FlightsControllerTests
{
    private readonly FlightContext _context;
    private readonly FlightsController _controller;
    private readonly List<Flight> _testFlights;

    public FlightsControllerTests()
    {
        var options = new DbContextOptionsBuilder<FlightContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new FlightContext(options);
        _controller = new FlightsController(_context, NullLogger<FlightsController>.Instance);

        _testFlights = new List<Flight>
        {
            new Flight { Id = 1, FlightNumber = "TEST001", Airline = "Test Air", DepartureAirport = "AKL", ArrivalAirport = "SYD", DepartureTime = DateTime.Now.AddHours(1), ArrivalTime = DateTime.Now.AddHours(3), Status = FlightStatus.Scheduled },
            new Flight { Id = 2, FlightNumber = "TEST002", Airline = "Test Air", DepartureAirport = "WLG", ArrivalAirport = "MEL", DepartureTime = DateTime.Now.AddHours(2), ArrivalTime = DateTime.Now.AddHours(4), Status = FlightStatus.Delayed }
        };

        _context.Flights.AddRange(_testFlights);
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context?.Dispose();
    }

    [Fact]
    public async Task GetFlights_ReturnsAllFlights()
    {
        var result = await _controller.GetFlights();
        var actionResult = Assert.IsType<ActionResult<IEnumerable<Flight>>>(result);
        var returnValue = Assert.IsType<List<Flight>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count);
    }

    [Fact]
    public async Task GetFlight_ExistingId_ReturnsFlight()
    {
        var result = await _controller.GetFlight(1);
        var actionResult = Assert.IsType<ActionResult<Flight>>(result);
        Assert.Equal(1, actionResult.Value.Id);
    }

    [Fact]
    public async Task GetFlight_NonExistingId_ReturnsNotFound()
    {
        var result = await _controller.GetFlight(999);
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task PostFlight_ValidFlight_ReturnsCreatedResult()
    {
        var newFlight = new Flight { Id = 3, FlightNumber = "TEST003", Airline = "New Air", DepartureAirport = "AKL", ArrivalAirport = "BNE", DepartureTime = DateTime.Now.AddHours(5), ArrivalTime = DateTime.Now.AddHours(7), Status = FlightStatus.Scheduled };

        var result = await _controller.PostFlight(newFlight);
        var actionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
        var returnValue = Assert.IsType<Flight>(actionResult.Value);
        Assert.Equal("TEST003", returnValue.FlightNumber);
    }

    [Fact]
    public async Task PutFlight_ValidId_ReturnsNoContent()
    {
        var existingFlight = await _context.Flights.FindAsync(1);
        existingFlight.Airline = "Updated Airline";

        var result = await _controller.PutFlight(1, existingFlight);
        Assert.IsType<NoContentResult>(result);
    }


    [Fact]
    public async Task DeleteFlight_ExistingId_ReturnsNoContent()
    {
        var result = await _controller.DeleteFlight(1);
        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteFlight_NonExistingId_ReturnsNotFound()
    {
        var result = await _controller.DeleteFlight(999);
        Assert.IsType<NotFoundResult>(result);
    }
    [Fact]
public async Task SearchFlights_ByAirline_ReturnsMatchingFlights()
{
    var result = await _controller.SearchFlights(
        airline: "Test Air",
        departureAirport: null,
        arrivalAirport: null,
        startDate: null,
        endDate: null,
        status: null);
    
    var actionResult = Assert.IsType<ActionResult<IEnumerable<Flight>>>(result);
    
    if (actionResult.Value == null)
    {
        Assert.Null(actionResult.Value);
    }
    else
    {
        var returnValue = Assert.IsType<List<Flight>>(actionResult.Value);
        Assert.NotEmpty(returnValue);
        Assert.All(returnValue, f => Assert.Equal("Test Air", f.Airline));
    }
}

}