# TEMSystem

A full-stack web application for managing thematic events, built with ASP.NET Core MVC and MySQL. This system allows administrators to perform CRUD operations on events and provides a public gallery view for users to browse events.

## Description

TEMSystem is designed to handle the complete lifecycle of thematic events (such as music, sports, cultural, or niche events like anime). It features a modern, professional UI using Material Design principles, ensuring an attractive and responsive user experience. The application separates administrative functionality from public viewing, providing a clean and intuitive interface for both roles.

## Features

- **Event Management (CRUD)**: Create, read, update, and delete events with fields like name, date, description, location, and image URL.
- **Admin Panel**: Dedicated interface for administrators to manage events.
- **Public Gallery**: Responsive grid view of events for public access.
- **Material Design UI**: Modern, visually appealing interface using Materialize CSS.
- **MySQL Integration**: Persistent data storage with Entity Framework Core.
- **Responsive Design**: Optimized for desktop and mobile devices.

## Prerequisites

Before running this application, ensure you have the following installed:

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) (version 8.0 or later recommended)
- A code editor like [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

## Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd TEMSystem
   ```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

## Configuration

1. **Database Setup**:
   - Create a MySQL database for the application.
     - Update the connection string in `appsettings.json`:
        ```json
        {
            "Logging": {
              "LogLevel": {
                  "Default": "Information",
                  "Microsoft.AspNetCore": "Warning"
              }
            },
            "ConnectionStrings": {
                "DefaultConnection": "server=your-server;port=3306;database=your-database;user=your-username;password=your-password"
            },
            "AllowedHosts": "*"
        }
        ```
   - Replace the placeholder values with your actual MySQL server details.

2. **Apply Database Migrations**:
   - Run the Entity Framework migrations to create the database schema:
     ```bash
     dotnet ef database update
     ```

## Running the Application

1. Build the project:
   ```bash
   dotnet build
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Open your browser and navigate to `https://localhost:5001` (or the URL shown in the console).

## Docker Usage

To run the application using Docker, follow these steps:

1. Ensure Docker is installed on your system.

2. Build the Docker image:
   ```bash
   docker build -t temsystem .
   ```

3. Run the container:
   ```bash
   docker run -d -p 8080:8080 temsystem
   ```

4. Open your browser and navigate to `http://localhost:8080` to access the application.

Note: Make sure your MySQL database is accessible from the Docker container. You may need to update the connection string in `appsettings.json` or use environment variables for Docker configuration.

```
TEMSystem/
├── Controllers/          # MVC Controllers (EventController, HomeController)
├── Data/                 # Database context (MysqlDbContext)
├── Models/               # Data models (Event, ErrorViewModel)
├── Views/                # Razor views organized by controller
│   ├── Event/            # Event-related views (Index, Create, Edit, Public)
│   ├── Home/             # Home views (Index, Privacy)
│   └── Shared/           # Shared layouts and partials
├── wwwroot/              # Static assets (CSS, JS, images)
│   ├── css/              # Custom styles
│   ├── js/               # JavaScript files
│   └── lib/              # Third-party libraries (Materialize CSS, etc.)
├── Migrations/           # Entity Framework migrations
├── appsettings.json      # Application configuration
└── Program.cs            # Application entry point
```

## Technologies Used

- **Backend**: ASP.NET Core MVC (.NET 10.0)
- **Database**: MySQL with Entity Framework Core 9.0
- **Frontend**: Materialize CSS, HTML5, CSS3, JavaScript
- **ORM**: Entity Framework Core with Pomelo.EntityFrameworkCore.MySql

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a feature branch: `git checkout -b feature/your-feature-name`
3. Commit your changes: `git commit -m 'Add some feature'`
4. Push to the branch: `git push origin feature/your-feature-name`
5. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.