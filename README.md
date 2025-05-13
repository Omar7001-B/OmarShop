# OmarShop

A modern, feature-rich e-commerce platform built with ASP.NET Core MVC.

![OmarShop](https://img.shields.io/badge/OmarShop-E--Commerce-0d6efd)
![License](https://img.shields.io/badge/License-MIT-green)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blueviolet)

## Overview

OmarShop is a comprehensive e-commerce solution that provides a seamless shopping experience for customers and powerful management tools for administrators. The application features product management, shopping cart functionality, user authentication, checkout processing, and order management.

## Features

- **User Features**
  - Product browsing with filtering and search
  - Product details view
  - Shopping cart management
  - Checkout process
  - User profile management with image upload
  - Order history

- **Admin Features**
  - Product management (CRUD operations)
  - Order management
  - User management
  - Dashboard with statistics

- **Technical Features**
  - Responsive design for all devices
  - User authentication and authorization
  - Image upload and management
  - AJAX for dynamic page updates
  - Client-side validation

## Technologies

- ASP.NET Core MVC 8.0
- Entity Framework Core
- SQL Server
- Bootstrap 5
- jQuery
- HTML5 & CSS3
- Identity Framework for Authentication

## Prerequisites

- .NET 8.0 SDK or later
- SQL Server (Local or Express)
- Visual Studio 2022 or Visual Studio Code

## Installation

1. Clone the repository:
```
git clone https://github.com/TryOmar/OmarShop.git
```

2. Navigate to the project directory:
```
cd OmarShop
```

3. Restore dependencies:
```
dotnet restore
```

4. Update the database with migrations:
```
dotnet ef database update
```

## Running the Application

### Standard Run
To run the application without hot reload:

```
dotnet run
```

Then open your browser and navigate to: `https://localhost:5001` or `http://localhost:5000`

### Run with Hot Reload
Hot reload allows you to see changes immediately without restarting the application:

```
dotnet watch run
```

The browser should open automatically. If not, navigate to: `https://localhost:5001` or `http://localhost:5000`

## User Accounts

The application seeds the following accounts for testing:

- **Admin**
  - Email: admin@omarshop.com
  - Password: Admin123!

- **Customer**
  - Email: user@omarshop.com
  - Password: User123!

## Project Structure

- **Areas:** Contains Admin area and Identity pages
- **Controllers:** Application controllers for user features
- **Models:** Data models and view models
- **Views:** UI templates
- **Data:** Database context and configurations
- **wwwroot:** Static files (CSS, JS, images)

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Author

Created by [TryOmar](https://github.com/TryOmar)

---

*Thank you for checking out OmarShop!* 