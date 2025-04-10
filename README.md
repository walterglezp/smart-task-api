# Smart Tasks API

**Smart Tasks API** is an intelligent and modular REST API built with ASP.NET Core for managing and prioritizing tasks efficiently. This project is designed to showcase modern .NET practices and clean architectural patterns inspired by leading tech companies.

## 🚀 Features (So Far)

- ✅ Clean and modular solution structure
- ✅ ASP.NET Core Web API (`SmartTasks.API`)
- ✅ xUnit testing project (`SmartTasks.Tests`)
- ✅ CI/CD-ready GitHub Actions workflow (to be added soon)
- ✅ Streamlined `.gitignore` for Visual Studio and VS Code environments

## 📁 Project Structure

SmartTasksAPI/
├── src/
│ └── SmartTasks.API/ # Main ASP.NET Core Web API project
├── tests/
│ └── SmartTasks.Tests/ # Unit and integration test project
├── SmartTasksAPI.sln # Solution file └── README.md

## 🛠️ Tech Stack

- .NET 8
- ASP.NET Core Web API
- xUnit for testing
- GitHub Actions (coming soon)
- Clean Architecture (coming soon)

## 💡 Vision

This project will evolve into a full-featured, cloud-ready API that uses:

- JWT-based authentication and authorization
- Background jobs for task reminders
- AI-enhanced prioritization (TBD)
- PostgreSQL with EF Core
- Docker containerization
- OpenAPI (Swagger) documentation
- Deployment to Azure / AWS

## 📦 Getting Started

```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run the API
cd src/SmartTasks.API
dotnet run
```
