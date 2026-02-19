# 🚀 MyCRM

### Enterprise-Grade Customer Relationship Management System

Built with ASP.NET Core (.NET 10)

------------------------------------------------------------------------

## 📖 Overview

**MyCRM** is a modular, layered, and production-oriented Customer
Relationship Management system designed to demonstrate enterprise
backend architecture and real-world domain modeling.

The project focuses on:

-   Scalable backend design\
-   Clean separation of concerns\
-   Explicit relational data modeling\
-   Structured service-based business logic\
-   Production-ready system architecture

This repository showcases engineering thinking beyond CRUD-level
applications.

------------------------------------------------------------------------

## 🧠 Why This Project Matters

Most CRM demos stop at basic CRUD operations.\
MyCRM goes further by implementing:

-   Layered Architecture
-   Explicit Business Logic Isolation
-   Fluent API Relationship Configuration
-   Soft Delete Strategy
-   Claims-Based Authentication
-   Strict Foreign Key Constraints
-   Service-Oriented Domain Handling

It demonstrates how real business systems are structured in enterprise
environments.

------------------------------------------------------------------------

## 🏗 System Architecture

MyCrm.Web → Presentation Layer (ASP.NET Core MVC)\
MyCrm.Application → Business Logic Layer\
MyCrm.Data → Data Access Layer (Entity Framework Core)\
MyCrm.Domain → Core Domain Models & ViewModels\
MyCrm.IoC → Dependency Injection Configuration

### Architectural Concepts Applied

✔ Separation of Concerns\
✔ Dependency Injection\
✔ Service Layer Abstraction\
✔ Domain-Oriented Modeling\
✔ ViewModel Isolation\
✔ Soft Delete Mechanism\
✔ Restrictive Delete Rules\
✔ Fluent API Configuration

------------------------------------------------------------------------

## 🛠 Technology Stack

-   ASP.NET Core (.NET 10)
-   Entity Framework Core (Code-First)
-   SQL Server / LocalDB
-   Razor MVC
-   Cookie-Based Authentication
-   Claims-Based Identity
-   Custom Password Hashing (MD5 - demonstration)
-   Bootstrap UI

------------------------------------------------------------------------

## 🔐 Authentication & Security

-   Custom login implementation\
-   Claims-based identity\
-   Cookie authentication middleware\
-   Password hashing via `PasswordHelper`\
-   Logical deactivation (Soft Delete)

> Note: MD5 is used for demonstration. In production, secure hashing
> such as BCrypt or ASP.NET Identity is recommended.

------------------------------------------------------------------------

## 📊 Core Functional Modules

### 👤 User & Customer Management

-   Create / Edit Customers\
-   Marketer Management\
-   Profile Image Upload\
-   Structured Entity Relationships

### 📦 Order Management

-   One-to-One Order--Marketer mapping\
-   Business rule enforcement\
-   Referential integrity via Fluent API

### 📈 Lead & Event Tracking

-   Lead ownership management\
-   Creator tracking\
-   Restrictive delete rules\
-   Event and task association

### 🧮 Predictive Modeling Layer

-   PredictMarketer entity
-   Business domain simulation example

------------------------------------------------------------------------

## ⚙ Installation

``` bash
git clone https://github.com/your-username/MyCRM.git
cd MyCRM
dotnet restore
dotnet ef database update --project MyCrm.Data --startup-project MyCrm.Web
dotnet run --project MyCrm.Web
```

------------------------------------------------------------------------

## 🎯 Engineering Highlights

✔ Enterprise-style backend layering\
✔ Business rule isolation\
✔ EF Core advanced configuration\
✔ Authentication flow implementation\
✔ Structured domain modeling\
✔ Clean controller-service separation\
✔ Scalable architecture foundations

------------------------------------------------------------------------

## 🔮 Future Improvements

-   Replace MD5 with BCrypt / ASP.NET Identity\
-   Implement Role-Based Authorization\
-   Introduce REST API Layer\
-   Implement JWT Authentication\
-   Add Unit Testing (xUnit)\
-   Docker containerization\
-   Structured logging (Serilog)\
-   Apply Clean Architecture fully\
-   Introduce CQRS Pattern

------------------------------------------------------------------------

## 👤 Author

Ashkan \[Your Last Name\]\
.NET Backend Developer\
Open to international opportunities
