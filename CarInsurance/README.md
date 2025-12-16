# Car Insurance Application

This is an ASP.NET MVC Web Application built with Entity Framework for managing car insurance quotes and customer information.

## Project Structure

- **Models**: Contains the `Insuree` model and `InsuranceEntities` Entity Framework context
- **Controllers**: Contains `InsureeController` with full CRUD functionality
- **Views**: Contains all MVC views for Insuree management (Index, Create, Edit, Details, Delete)
- **App_Data**: Contains the database file `Insurance.mdf` and SQL schema

## Database Setup

The database schema is defined in `App_Data/Insurance_Schema.sql`. The SQL Server Database file `Insurance.mdf` should be created in the App_Data folder.

### SQL Schema

The Insurees table includes the following fields:
- Id (Primary Key, Identity)
- FirstName
- LastName
- EmailAddress
- DateOfBirth
- CarYear
- CarMake
- CarModel
- DUI (Boolean)
- SpeedingTickets
- CoverageType
- Quote

## Entity Framework

The project uses Entity Framework 6.x with Database First approach. The `InsuranceEntities.edmx` file contains the Entity Data Model.

## Features

The application provides full CRUD (Create, Read, Update, Delete) functionality:

- **Index**: Lists all insurees
- **Create**: Create a new insuree record
- **Edit**: Edit an existing insuree record
- **Details**: View details of a specific insuree
- **Delete**: Delete an insuree record

## Building the Project

To build the project:
1. Open the solution in Visual Studio
2. Restore NuGet packages
3. Build the solution (Ctrl+Shift+B)

## Notes

- The controller is named `InsureeController` (singular) as specified
- The connection string is configured in `Web.config` as `InsuranceEntities`
- Entity Framework 6.x is used for data access

