# To-Do App Backend

This repository contains the backend code for the To-Do App, developed using C# ASP.NET and SQL Server.

## Features

- Task creation, updating, and deletion
- Secure database interactions
- Scalable architecture

## Technologies Used

- C# ASP.NET
- SQL Server
- Entity Framework

## Getting Started

### Prerequisites

- .NET SDK
- SQL Server

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/todo-app-backend.git
    ```
2. Navigate to the project directory:
    ```bash
    cd todo-app-backend
    ```
3. Restore the dependencies:
    ```bash
    dotnet restore
    ```

### Configuration

1. Update the connection string in `appsettings.json` to match your SQL Server configuration:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user_id;Password=your_password;"
    }
    ```

### Running the Application

1. Apply database migrations:
    ```bash
    dotnet ef database update
    ```
2. Start the application:
    ```bash
    dotnet run
    ```

### Building for Production

1. Publish the application:
    ```bash
    dotnet publish -c Release -o ./publish
    ```

## Contributing

Contributions are welcome! Please fork this repository and submit a pull request for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.
