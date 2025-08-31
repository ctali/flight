# Flight Information API

A RESTful API for managing flight information built with .NET 8 and Entity Framemework Core
.NET 8
Entity Framework Core
Swagger/OpenAPI
xUnit (testing)

## Quick Start

```bash
# Clone the repository
git clone https://github.com/ctali/flight.git
cd flight

# Restore packages and run
dotnet restore
dotnet run --project FlightInformationAPI

The API will start and display listening URLs in the terminal. Use the HTTP URL with /swagger to access interactive API documentation.
Example:
http://localhost:5084/swagger

API Endpoints

| Method | Endpoint | Description |
|----------|----------|----------|
| GET   | /api/flights   | Get all flights   |
| GET   |  /api/flights/{id} | Get specific flight |
| POST | /api/flights | Create new flight |
| PUT | /api/flights/{id} | Update flight |
| DELETE | /api/flights/{id} | Delete flight |
| GET | /api/flights/search | Search flights by criteria |

Search Parameters
airline (string)
departureAirport (string)
arrivalAirport (string)
startDate (DateTime)
endDate (DateTime)
status (Enum: 0-4)

## Testing
Run the test suite with bash command:
dotnet test  

## Technologies
.NET 8
Entity Framework Core
Swagger/OpenAPI
xUnit


## Features
Full CRUD operations
Advanced search
In-memory database
Input validation
Comprehensive logging
Error handling