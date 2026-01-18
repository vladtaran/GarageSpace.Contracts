# GarageSpace.Contracts

Shared contracts library for GarageSpace microservices communication. This package contains event definitions and DTOs used for inter-service messaging and event-driven architecture.

## Overview

GarageSpace.Contracts is a .NET 8.0 library that provides shared contract definitions for the GarageSpace microservices ecosystem. It enables type-safe communication between services through standardized event contracts, typically used with message brokers like RabbitMQ.

## Installation

### NuGet Package

```bash
dotnet add package GarageSpace.Contracts
```

Or via Package Manager Console:

```powershell
Install-Package GarageSpace.Contracts
```

### Package Reference

Add to your `.csproj` file:

```xml
<PackageReference Include="GarageSpace.Contracts" Version="0.1.0" />
```

## Available Contracts

### User Events

- **`UserCreated`** - Published when a new user is created
  - `UserId` (long) - The unique identifier of the user
  - `Name` (string) - The name of the user

### Vehicle Journal Events

- **`VehicleJournalCreated`** - Published when a new vehicle journal is created
  - `JournalId` (long) - The unique identifier of the journal
  - `OwnerId` (long) - The ID of the journal owner
  - `Name` (string) - The name of the journal
  - `Model` (string) - The vehicle model

- **`VehicleJournalFollowedEvent`** - Published when a user follows a vehicle journal
  - `JournalId` (long) - The ID of the journal being followed
  - `FollowerUserId` (long) - The ID of the user following the journal
  - `OccurredAt` (DateTime) - When the follow action occurred

- **`VehicleJournalUnfollowedEvent`** - Published when a user unfollows a vehicle journal
  - `JournalId` (long) - The ID of the journal being unfollowed
  - `UnFollowerUserId` (long) - The ID of the user unfollowing the journal
  - `OccurredAt` (DateTime) - When the unfollow action occurred

### User Blog Events

- **`UserBlogFollowedEvent`** - Published when a user follows another user's blog
  - `UserId` (long) - The ID of the user whose blog is being followed
  - `FollowerUserId` (long) - The ID of the user following the blog
  - `OccurredAt` (DateTime) - When the follow action occurred

- **`UserBlogUnfollowedEvent`** - Published when a user unfollows another user's blog
  - `UserId` (long) - The ID of the user whose blog is being unfollowed
  - `FollowerUserId` (long) - The ID of the user unfollowing the blog
  - `OccurredAt` (DateTime) - When the unfollow action occurred

## Usage Example

```csharp
using GarageSpace.Contracts;

// Publishing an event (example with a message broker)
var userCreated = new UserCreated
{
    UserId = 12345,
    Name = "John Doe"
};

// Subscribe to events
public class UserEventHandler
{
    public void Handle(UserCreated @event)
    {
        // Process the event
        Console.WriteLine($"User {@event.Name} (ID: {@event.UserId}) was created");
    }
}
```

## Building from Source

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 or VS Code / Rider

### Build

```bash
dotnet build
```

### Pack

To create a NuGet package:

```bash
dotnet pack
```

The package will be generated in the `bin/Debug` or `bin/Release` directory.

## Project Information

- **Target Framework:** .NET 8.0
- **Version:** 0.1.0
- **Author:** Vlad Taran
- **Company:** GarageSpace
- **Repository:** https://github.com/vladtaran/GarageSpace.Contracts

## Contributing

When adding new contracts:

1. Follow the existing naming conventions
2. Use appropriate property types (`init` for immutable properties, `set` for mutable)
3. Include all necessary properties with clear names
4. Update this README with the new contract documentation
5. Ensure the project builds without warnings (warnings are treated as errors)

## License

[Add your license information here]

## Related Projects

This contracts library is part of the GarageSpace microservices ecosystem. Other related projects may include:

- Service implementations that publish/subscribe to these events
- Message broker configuration and infrastructure
- API gateways and service discovery components
