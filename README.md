# DatabaseDrivenAPI

A .NET 6/7 Web API project designed to demonstrate a database-driven application architecture using ASP.NET Core. This project showcases how to connect to a database, structure your API endpoints, and manage configuration via `appsettings.json`.

## Features

- RESTful API design
- Centralized configuration
- Easy database connection management
- Starter endpoint (e.g., Weather Forecast)
- Can be extended to integrate with EF Core / SQL Server / PostgreSQL

## Technologies Used

- ASP.NET Core Web API
- C#
- .NET 6 / 7
- Visual Studio 2022 or newer

## Project Structure

DatabaseDrivenAPI/
├── Program.cs # Main entry point
├── WeatherForecast.cs # Sample model
├── appsettings.json # Main config
├── appsettings.Development.json
├── DatabaseDrivenAPI.csproj # Project file

## Prerequisites

- [.NET SDK 6 or 7](https://dotnet.microsoft.com/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/)
- SQL Server (if database integration added)

## Running the Application

1. Clone the repository or extract the ZIP.
2. Open the solution in Visual Studio.
3. Set `DatabaseDrivenAPI` as the startup project.
4. Run the project using IIS Express or `dotnet run`.

## API Endpoint (Sample)

```http
POST /api/student/
GET /api/student/List/
GET /api/student/
POST /api/student
DELETE /api/student/{id}
