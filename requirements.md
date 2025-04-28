# Omar Shop: ASP.NET MVC E-Commerce Project Documentation

## Project Overview
Omar Shop is a mini e-commerce platform built with ASP.NET MVC. This documentation outlines the complete requirements and structure needed to successfully complete the project.

## Technology Stack
- **Backend Framework**: ASP.NET MVC (Controllers return HTML pages)
- **Database**: SQL Server (LocalDB for development)
- **Authentication**: ASP.NET Identity (Admin & Customer roles)
- **Storage**: File System (save product images in `/uploads` or `/images/products`)
- **Frontend**: Plain HTML + CSS + JavaScript (with Bootstrap for faster UI)
- **Package Management**: NuGet (backend) + manually include frontend libraries (or use LibMan)
- **Development Tools**: Visual Studio 2022 (or Visual Studio Code with extensions)

## Project Structure
```
OmarShop/
├── Controllers/
├── Models/
├── Views/
├── Areas/
├── wwwroot/
│   ├── css/
│   ├── js/
│   ├── lib/
│   └── uploads/images/
└── Data/
```

## Database Schema

### Main Entities
1. **Users**
   - Id, Name, Email, PasswordHash, ProfilePicture, Role (admin/user)

2. **Products**
   - Id, Name, Description, Price, StockQuantity, ImageUrl

3. **Orders**
   - Id, UserId, OrderDate, Status, TotalPrice

4. **OrderItems**
   - Id, OrderId, ProductId, ProductName, ProductPrice, Quantity

5. **CartItems**
   - Id, UserId, ProductId, Quantity

## Features Implementation

### 1. User Authentication
- Registration and login forms
- Role-based access (Admin/User)
- Password hashing via ASP.NET Identity
- Authentication cookies and session management

### 2. Role-Based Access
- Admin area for product and order management
- User area for shopping and profile management
- Authorization filters on controllers

### 3. Homepage & Dashboard
- Admin dashboard with management options
- User homepage with product catalog
- Different views based on user role

### 4. Product Management (Admin)
- Create, Read, Update, Delete (CRUD) operations
- Image upload functionality
- Product listing with pagination
- Form validation

### 5. Cart System
- Session-based cart
- Add, update, remove items
- Stock validation
- Cart summary with totals

### 6. Order Management
- Order creation process
- Status updates (Pending, Processing, Shipped, Delivered, Cancelled)
- Order history for users
- Admin order management interface

### 7. Profile Management
- User profile editing
- Password change functionality
- Profile picture upload
- Form validation

### 8. JavaScript Interactivity
- Form validation
- Live product search/filtering
- Stock alerts
- Dynamic UI updates

### 9. UI/UX Implementation
- Responsive Bootstrap layout
- Dynamic navigation based on user role
- Clean, modern design
- Mobile-friendly interface

## Implementation Steps

### 1. Project Setup
- Create new ASP.NET MVC project
- Configure SQL Server LocalDB connection
- Set up Entity Framework 
- Configure ASP.NET Identity

### 2. Database and Models
- Create C# model classes
- Set up database contexts
- Create database migrations
- Initialize database with seed data

### 3. Authentication System
- Implement login/registration
- Configure role-based security
- Create authorization filters

### 4. Admin Features
- Product management views and controllers
- Order management dashboard
- User list view

### 5. User Features
- Product browsing interface
- Shopping cart functionality
- Checkout process
- Profile management

### 6. Frontend Development
- Implement Bootstrap layout
- Create JavaScript for interactive features
- Style application with CSS
- Create form validations

### 7. File Upload System
- Create upload directories
- Implement file upload functionality
- Image resizing/optimization
- File validation

## Required Features Checklist

- ✅ **Authentication**: Login and registration
- ✅ **Role-Based Access**: Admin and User areas
- ✅ **Product Management**: Complete CRUD operations
- ✅ **Shopping Cart**: Add, edit, remove items
- ✅ **Order System**: Creation and management
- ✅ **Profile Management**: Edit profile and upload picture
- ✅ **Responsive UI**: Bootstrap-based interface
- ✅ **JavaScript Features**: Search, validation, alerts

## Development Recommendations

1. Start with authentication and user roles
2. Implement product management for admins
3. Create the product catalog for users
4. Build the cart and checkout functionality
5. Implement order management
6. Add profile management features
7. Enhance with JavaScript and styling
8. Test thoroughly across user roles

This structured approach ensures all requirements are met while maintaining a clean, maintainable codebase. The project follows MVC architecture patterns with clear separation of concerns between data, business logic, and presentation layers.