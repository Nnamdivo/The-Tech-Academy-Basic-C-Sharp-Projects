# Car Insurance Project Setup Instructions

This document summarizes the steps that have been completed to set up the Car Insurance ASP.NET MVC project.

## Completed Steps

### 1. Project Creation
- ✅ Created ASP.NET MVC project structure
- ✅ Solution file: `CarInsurance.sln`
- ✅ Project file: `CarInsurance.csproj`
- ✅ Configured for .NET Framework 4.7.2

### 2. Database Setup
- ✅ Created `App_Data` folder
- ✅ Created SQL schema file: `App_Data/Insurance_Schema.sql`
- ✅ Database will be created as `Insurance.mdf` in App_Data folder

### 3. Entity Framework Model
- ✅ Created `InsuranceEntities.edmx` Entity Data Model
- ✅ Created `InsuranceEntities.Designer.cs` with DbContext
- ✅ Configured connection string in `Web.config` as "InsuranceEntities"
- ✅ Model uses Entity Framework 6.x

### 4. Models
- ✅ Created `Insuree` model class with all required properties:
  - Id, FirstName, LastName, EmailAddress
  - DateOfBirth, CarYear, CarMake, CarModel
  - DUI, SpeedingTickets, CoverageType, Quote

### 5. Controller
- ✅ Created `InsureeController` (singular name as specified)
- ✅ Implemented full CRUD operations:
  - Index (list all)
  - Create (GET and POST)
  - Edit (GET and POST)
  - Details
  - Delete (GET and POST)

### 6. Views
- ✅ Created all five standard MVC views:
  - `Index.cshtml` - Lists all insurees
  - `Create.cshtml` - Form to create new insuree
  - `Edit.cshtml` - Form to edit existing insuree
  - `Details.cshtml` - View details of an insuree
  - `Delete.cshtml` - Confirmation page to delete an insuree

### 7. Configuration Files
- ✅ `Web.config` with Entity Framework configuration
- ✅ Connection string configured
- ✅ `Global.asax` and `Global.asax.cs`
- ✅ `RouteConfig.cs`, `FilterConfig.cs`, `BundleConfig.cs`
- ✅ `packages.config` with all required NuGet packages

### 8. Supporting Files
- ✅ Shared layout (`_Layout.cshtml`)
- ✅ ViewStart configuration
- ✅ Home controller and views
- ✅ CSS styling

## Next Steps (To be done in Visual Studio)

1. **Create the Database**:
   - In Visual Studio, right-click `App_Data` folder
   - Select Add > New Item > SQL Server Database
   - Name it `Insurance.mdf`
   - Open the database in Server Explorer
   - Right-click Tables > Add New Table
   - Execute the SQL from `App_Data/Insurance_Schema.sql`
   - Click Update, then Update Database

2. **Update Entity Framework Model**:
   - The EDMX file is already created, but you may need to:
   - Right-click the EDMX file > Update Model from Database
   - Ensure the Insurees table is selected

3. **Build the Project**:
   - Press Ctrl+Shift+B to build
   - Ensure all NuGet packages are restored

4. **Run the Application**:
   - Press F5 to run
   - Navigate to `/Insuree` to see the CRUD interface

## Project Structure

```
CarInsurance/
├── CarInsurance.sln
├── CarInsurance/
│   ├── App_Data/
│   │   ├── Insurance_Schema.sql
│   │   └── Insurance.mdf (to be created)
│   ├── App_Start/
│   │   ├── BundleConfig.cs
│   │   ├── FilterConfig.cs
│   │   └── RouteConfig.cs
│   ├── Controllers/
│   │   ├── HomeController.cs
│   │   └── InsureeController.cs
│   ├── Models/
│   │   ├── Insuree.cs
│   │   ├── InsuranceEntities.edmx
│   │   ├── InsuranceEntities.edmx.diagram
│   │   └── InsuranceEntities.Designer.cs
│   ├── Views/
│   │   ├── Home/
│   │   ├── Insuree/
│   │   │   ├── Index.cshtml
│   │   │   ├── Create.cshtml
│   │   │   ├── Edit.cshtml
│   │   │   ├── Details.cshtml
│   │   │   └── Delete.cshtml
│   │   └── Shared/
│   ├── Content/
│   ├── Scripts/
│   ├── Global.asax
│   ├── Global.asax.cs
│   ├── Web.config
│   └── packages.config
└── README.md
```

## Features

The application provides a complete CRUD interface for managing car insurance quotes:

- **Index View**: Displays a table of all insurees with links to edit, view details, or delete
- **Create View**: Form to add a new insuree with validation
- **Edit View**: Form to modify an existing insuree's information
- **Details View**: Read-only view of a single insuree's complete information
- **Delete View**: Confirmation page before deleting an insuree

All views include proper validation, error handling, and follow MVC best practices.

