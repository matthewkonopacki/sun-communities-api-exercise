# Sun Communities Assessment

A RESTful API built with ASP.NET Core demonstrating fee calculation logic with an accompanying unit test suite.

## Description

This project contains two components:
- **SunCommunitiesApi**: An ASP.NET Core Web API with two endpoints implementing the fee calculation requirements from the coding exercise.
- **SunCommunitiesTests**: xUnit test suite verifying the fee calculation business logic

## How to Run

**Install the .NET 10 sdk:**

If the .NET 10 isn't installed please install it.

**Run the API:**
```bash
dotnet run --project SunCommunitiesApi
```
The API will be available at `https://localhost:[port]`

**Run the tests:**
```bash
dotnet test
```

## Improvements With More Time

Given additional time, I would focus on:

- **Error handling and validation**: Implement comprehensive input validation with appropriate error responses and status codes for edge cases (e.g., negative values, any other possible issues)
- **Logging**: Add more commprehensive logging using ILogger to track requests and errors for debugging and monitoring
- **API documentation**: Add Swagger/OpenAPI documentation with detailed endpoint descriptions and request/response examples
- **Additional test coverage**: Add integration tests for the API endpoints and expand edge case coverage in unit tests

## Development Approach

**Background**: This was my first project using C# and the .NET framework, coming from a TypeScript/Node.js background.

**Documentation and AI Usage**:
- Referenced official Microsoft ASP.NET Core documentation often to understand framework fundamentals (dependency injection, routing conventions, etc)
- Used documentation and AI assistance to learn C# syntax patterns, xUnit testing framework, and resolve initial compilation errors
- Leveraged Claude as a reference tool for troubleshooting specific error messages and understanding .NET conventions
- **All business logic and architectural decisions were implemented independently** after understanding the framework basics

The strong syntactic similarities between C# and TypeScript helped accelerate the learning curve once I understood the .NET-specific patterns.