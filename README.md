E-Commerce Web Application - ASP.NET Core MVC

This is a fully-featured **E-Commerce Web Application** built using **ASP.NET Core MVC**, **Entity Framework Core**, and **Microsoft SQL Server**.

The application is designed with a clean separation of concerns using the **MVC architectural pattern**. It allows users to browse products, register and manage their accounts, and place orders. Administrators have special privileges to manage users, roles, and products.

Features:

User Functionality:

Browse and filter products by name, category, or price
Search and sort products
Add products to a **shopping cart** (stored in cookies)
Create and manage orders
Register, login, logout
Change password and request password reset via email
Edit personal profile

Admin Functionality:

Full CRUD for managing products (create, update, delete)
View all registered users
Assign roles (e.g., Admin, Customer)
Delete user accounts
Update order statuses with visual badges

Additional Features:

Form validation using model attributes and model binding
Configuration management via `appsettings.json`
Image upload support
Dependency Injection for services and repositories
Database access with **Entity Framework Core**
Pagination, search, and sort functionality for lists

Tools and Technologies:

Language: C#
Framework: ASP.NET Core MVC
ORM: Entity Framework Core
Database: Microsoft SQL Server
Identity System: ASP.NET Core Identity
Frontend: Razor Views, HTML/CSS, Bootstrap
IDE: Visual Studio 2022
