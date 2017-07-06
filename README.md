# Tour of Heroes

ASP.NET Core backend implementation for Tour of Heroes Angular 2 tutorial. Application uses SQLLite as database mockup.

## Getting Started

This project will give you a good start on how to develop applications using Angular 2 and .NET Core

### Prerequisites

You need to install

* Dotnet Core
* Angular cli

### Installing

To install this project

Create database

Enter in terminal folder TourOfHeroes/TourOfHeroes/ and run
```
dotnet ef database update
```

Build Angular in watch mode

Enter in terminal to TourOfHeroes/TourOfHeroes/frontend folder and run
```
ng build --watch
```
Build application

Enter in terminal folder TourOfHeroes/TourOfHeroes/ and run
```
dotnet build
```

Run application

Enter in terminal folder TourOfHeroes/TourOfHeroes/ and run
```
dotnet run
```

Navigate in browser to http://localhost:5000