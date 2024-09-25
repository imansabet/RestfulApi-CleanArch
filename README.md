# Description
This RESTful API project is designed to manage a simple product catalog. Built using ASP.NET Core, the API allows clients to perform CRUD (Create, Read, Update, Delete) operations on products. Each product has an ID, name, and price, which are stored in memory for demonstration purposes.

The API follows the principles of Clean Architecture  , separating concerns into distinct layers:

Core: Contains the domain entities and interfaces.
Application: Implements the business logic and service layer.
Infrastructure: Provides the repository pattern for data access.
WebApi: Acts as the entry point for client requests, exposing endpoints for interacting with the product catalog.
