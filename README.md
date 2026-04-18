# Selling Albums - ASP.NET Core MVC & Web API Study

## Project Purpose
This project was developed as a hands-on introduction to **ASP.NET Core MVC** and as a way to deepen my knowledge of **Web APIs**. The main goal is to build a functional web application for selling music albums, focusing on modern development practices.

## Course Context
The project is being built during the course **"ASP .NET Core MVC - Criando um Site do Zero (NET 6)"** taught by **Jose Carlos Macoratti**. 
* **Instructor Profile:** Macoratti has been recognized as a *Microsoft Most Valuable Professional (MVP) in Visual Studio and Development Technologies* since 2009.
* **Why Macoratti?** Learning from a MVP ensures a high-quality pedagogical approach, focusing on real-world problems, best practices, and the solid foundation needed for any .NET developer.

## Tech Stack
* **Framework:** .NET 6 (with updates to version 8)
* **Architecture:** ASP.NET Core MVC & Web API
* **ORM:** Entity Framework Core (Code First approach)
* **Database:** SQL Server Express
* **Tools:** Visual Studio 2026 & SQL Server Management Studio (SSMS)

> **Note on Versioning:** While .NET 10 is the latest current release and .NET 6 is technically out of support, this project uses .NET 6 to maintain compatibility with the course's structured curriculum. The core concepts of MVC, dependency injection, and Entity Framework learned here are highly transferable and serve as a robust foundation for migrating to newer versions like .NET 8 or 10.

## Business Model & Domain Entities
The application is a simple e-commerce platform for selling a curated selection of music albums. To keep the focus on learning the framework, the domain model is kept lean but effective.

### Data Models
Based on the **Code First** approach, the following entities were defined:

* **Album**: The core entity representing a music record.
    * `Title`, `Year`, `Price`, `CoverUrl`, `IsAvailable`, etc.
* **Artist**: Represents the creator of the album.
    * `Name` and a collection of related `Albums`.
* **Genre**: Categorizes the music (e.g., Rock, Jazz, Pop).
    * `Name` and its associated `Albums`.
