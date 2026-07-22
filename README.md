# Unit Converter API

A simple and extensible ASP.NET Core 8.0 Web API for converting units. The project currently supports conversions for Length, Temperature, and Weight, and is designed using common design patterns to make future enhancements easy.

## Features

- Meter → Feet
- Celsius → Fahrenheit
- Kilogram → Pound

## Tech Stack

- ASP.NET Core 8.0
- C#
- REST API

## Design Patterns Used

- **Factory Pattern** - Creates the appropriate converter based on the selected conversion type.
- **Strategy Pattern** - Each conversion is implemented as a separate strategy.
- **Dependency Injection** - Used for loose coupling and better maintainability.

## API Endpoint

### Convert Units

**POST**

```http
/api/unitconverter/convert
```

### Request Body

```json
{
  "unitType": "Length",
  "value": 10
}
```

> **unitType** is an enum with the following supported values:
>
> - Temperature
> - Length
> - Weight

### Sample Response

```json
{
  "result": 32.8084
}
```

## Extending the Project

The project is designed to be easily extensible.

To add a new conversion type:

1. Add a new value to the `ConverterUnit` enum.
2. Create a new converter implementing `IUnitConverter`.
3. Register the converter in `ConverterFactory`.
4. No controller changes are required.

## How to Run

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages (if prompted).
4. Press **F5** or **Ctrl + F5** to run the application.
5. Open Swagger at:

```
https://localhost:<port>/swagger
```
