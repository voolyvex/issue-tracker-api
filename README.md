# Issue Tracker API

The Issue Tracker API is a web API built with ASP.NET Core that provides full CRUD (Create, Read, Update, Delete) functionality for managing issues. It serves as the backend for the Issue Tracker application, allowing users to track and manage various issues within a project.

This project is based on a fork of the [TrackingAPI](https://github.com/techwithpat/trackingapi) project by techwithpat.

## Installation

To run the Issue Tracker API locally or deploy it to a server, follow these steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/voolyvex/issue-tracker-api.git

2. Navigate to the project directory:

    ```bash
    Copy code
    cd issue-tracker-api
3. Restore packages and build the project:

    ```bash
    Copy code
    dotnet build
4. Create an instance of SQL Server and connect to it. Modify the "DefaultConnection" connection string in the appsettings.json file to match your SQL Server configuration.

5. Apply database migrations:

    ```bash
    Copy code
    dotnet ef database update
6. Run the application:

    ```bash
    Copy code
    dotnet run
The API will be accessible at http://localhost:5000 by default.

## Usage

Once the Issue Tracker API is running, you can interact with it using HTTP requests. Refer to the API documentation or explore the available endpoints using Swagger at http://localhost:5000/swagger for more details on request and response formats.

## Contributing
Contributions to the Issue Tracker API are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your changes.
3. Make your changes and commit them.
4. Push your branch to your forked repository.
5. Submit a pull request detailing your changes.

## License
This project is licensed under the MIT License. 
