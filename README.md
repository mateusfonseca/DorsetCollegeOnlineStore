# ASP.NET Core MVC: Online Store Web App

**Dorset College Dublin**  
**BSc in Science in Computing & Multimedia**  
**Object-Oriented Programming - BSC20921**  
**Stage 2, Semester 2**  
**Continuous Assessment 2**

**Lecturer name:** Nitya Govindaraju  
**Lecturer email:** nitya.govindaraju@faculty.dorset-college.ie

**Student Name:** Mateus Fonseca Campos  
**Student Number:** 24088  
**Student Email:** 24088@student.dorset-college.ie

**Submission date:** 8 May 2022

This repository contains an "Online Store" ASP.NET Core MVC web application developed for my CA2 at Dorset College BSc in Computing, Year 2, Semester 2.

## Part 1: Requirements

This projects requires both Microsoft's Entity Framework Core and SQLite to be installed and accessible in order to be executed successfully.

InitialMigration is included in the package and the database will be populated at first run.

For more information, please visit the [official repository](https://github.com/dotnet/efcore).

## Part 2: Background

MVC, Model-View-Controller, is an architectural pattern for designing and developing applications, and, at its core, there resides one of the key principles of programming: *separation of concerns*.

Through separation of concerns, different modules within a project are organized according to the type of work they perform and kept separate with minimum dependency between them. This allows the project to be tested more efficiently and to grow dynamically, as its parts can be handled individually and internal changes to specific modules are less likely to stop other modules from working.

The MVC pattern divides the project into three distinct components with different responsibilities:

- **Model:** models are a representation of the application's state. They can be constituted by business and operational logic as well as runtime reflections of the database's entities and their instances.


- **View:** views are concerned with presentation of content through the user interface. They should house little to no logic and decision-making.


- **Controller:** controllers are responsible for handling user interaction and requests. They are the entry point of the application and select what views to display and what models' data to feed said views with.

Applying robust architectural principles to software development, such as MVC, are an indispensable part of creating reliable and scalable products. 

## Part 3: Report

This project was developed based on Microsoft's ASP.NET Core platform and the MVC design pattern. The following scheme explains the organization of its main components:

- **1. Models**  
  - **1.1. Cart**  
  This class represents the Cart entity in the database.
  - **1.2. CartProduct**  
  This class represents the CartProduct entity in the database.
  - **1.3. CartProductViewModel**  
    This class does not represent an entity in the database, rather, it performs logical operations in order to feed a specific view.
  - **1.4. ErrorViewModel**  
    This class does not represent an entity in the database, rather, it performs logical operations in order to feed a specific view.
  - **1.5. Order**  
    This class represents the Order entity in the database.
  - **1.6. OrderProduct**  
  This class represents the OrderProduct entity in the database.
  - **1.7. OrderProductViewModel**  
    This class does not represent an entity in the database, rather, it performs logical operations in order to feed a specific view.
  - **1.8. Product**  
    This class represents the Product entity in the database.
  - **1.9. ProductCategoryViewModel**  
    This class does not represent an entity in the database, rather, it performs logical operations in order to feed a specific view.
  - **1.10 SeedData**  
  This class populates the database to provide the application a starting point.
  - **1.11 Session**  
    This class does not represent an entity in the database, rather, it solely holds a reference to the ID of the user that is currently logged in.
  - **1.12 User**  
    This class represents the User entity in the database.


- **2. Views**  
  - **2.1 CartProducts**  
  The Razor files in this folder define the CartProducts view and its actions:
    - Create/Delete/Details/Edit - CRUD.
    - Index - list of cart products.
  - **2.2 Carts**  
  The Razor files in this folder define the Carts view and its actions:
    - Create/Delete/Details/Edit - CRUD.
    - Index - list of carts.
    - Empty - empties a cart's content.
  - **2.3 Home**  
    The Razor files in this folder define the Home view and its actions:
    - Index - list of product categories.
    - Privacy - displays privacy policy.
  - **2.4 OrderProducts**  
  The Razor files in this folder define the OrderProducts view and its actions:
    - Create/Delete/Details/Edit - CRUD.
    - Index - list of order products.
  - **2.5 Orders**  
  The Razor files in this folder define the Orders view and its actions:
    - Create/Delete/Details/Edit - CRUD.
    - Index - list of orders.
  - **2.6 Products**  
  The Razor files in this folder define the Products view and its actions:
    - Create/Delete/Details/Edit - CRUD.
    - Index - list of products.
  - **2.7 Shared**  
    The Razor files in this folder define the views that are shared by other views in the application:
    - _Layout - for navbar and footer.
    - _ValidationScriptsPartial - for jQuery validation.
    - Error - general error message.
    - Components/MiniCart/Default - layout for MiniCart display.
  - **2.8 Users**  
  The Razor files in this folder define the Users view and its actions:
    - Create/Delete/Details/Edit - CRUD.
    - Index - displays sign-in page.


- **3. Controllers**  
  - **3.1 CartProductsController**  
  This class controls users requests through actions related to the CartProducts view.
  - **3.2 CartsController**  
  This class controls users requests through actions related to the Carts view.
  - **3.3 HomeController**  
  This class controls users requests through actions related to the Home view.
  - **3.4 OrderProductsController**  
  This class controls users requests through actions related to the OrderProducts view.
  - **3.5 OrdersController**  
  This class controls users requests through actions related to the Orders view.
  - **3.6 ProductsController**  
  This class controls users requests through actions related to the Products view.
  - **3.7 UsersController**  
  This class controls users requests through actions related to the Users view.

Additionally:

- **4. ViewComponents**  
  - **4.1. MiniCartViewComponent**  
  This class defines a ViewComponent that inflates a MiniCart view dynamically, based on the ID of the currently logged-in user.

## Part 4: References

Conceptually, every line of code in this project was written based on official documentation:

- **[ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/)**
- **[MDN Web Docs](https://developer.mozilla.org/)**

Clarifying code snippets from **[W3Schools](https://www.w3schools.com/)**.

Visits to our most beloved **[StackOverflow](https://stackoverflow.com/)** certainly happened, for insight and understanding.

This app uses data from the **[Fake Store API](https://fakestoreapi.com/)**.

## Part 5: Copyright Disclaimer

This project may feature content that is copyright protected. Please, keep in mind this is a student's project and has no commercial purpose whatsoever. Having said that, if you are the owner of any content featured here and would like for it to be removed, please, contact me and I will do so promptly.

Thank you very much,  
Mateus Campos.