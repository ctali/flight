# Flight Information

A RESTful API for managing flight information 

Quick Start
1. Clone and run:

bash
git clone https://github.com/ctali/flight.git
cd flight/FlightInformationAPI
dotnet run

2. Visit https://localhost:PORT/swagger to explore the API

API Endpoints
GET /api/flights - Get all flights

GET /api/flights/{id} - Get specific flight

POST /api/flights - Create new flight

PUT /api/flights/{id} - Update flight

DELETE /api/flights/{id} - Delete flight

GET /api/flights/search - Search flights

Testing
Run the test suite with:

bash
dotnet test
Features
In-memory database

Swagger documentation

Input validation

Error handling

Search functionality

The API uses an in-memory database, so data resets when the application restarts.
