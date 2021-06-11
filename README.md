  # Local Business Finder

####  A Project Exploring Basic APIs With MVC C#, Entity, swagger, and MySQL Workbench

#### By _**Sammai Gutierrez**_

## Technologies Used

* _GitHub_
* _VS Code_
* _ASP .NET Core MVC_
* _C#_
* _GitBash_
* _MySQL Workbench
* _Entity Framework_
* _Postman_
* _Swagger_
## Description

_In brief, this project allows a user use this API and all its CRUD functionality._

## Pre-requisites

* _C#/.NET 5_
* _VS Code or another text editor of choice_
* _Internet browser_
* _An account with GitHub_
* _MySQL Workbench_
* _A command line interface (Terminal or GitBash) to run and interact with the application._

## Installation Instruction
1.  
    * _Clone the repository with command `$ git clone gitHub-URL-repository`_
    * _Open the repository on your computer in your text editor._
    * _Navigate to the BusinessLookup folder & create a file called `appsettings.json`._
    * _Once inside `appsettings.json`, write the following code:_
        * _`{
              "ConnectionStrings": {
              "DefaultConnection": "Server=localhost;Port=3306;database=[NAME YOUR DATABASE HERE];uid=[MySQL USER-NAME HERE];pwd=[MySQL PASSWORD HERE];"
              }
            }`_
        * _Fill in the required info. (database name, MySQL user-name & password) without the squared brackets._
    * _Still in the BusinessLookup folder, run the command `$dotnet build`_
    * _Navigate to the BusinessLookup folder and run the command `$dotnet ef database update`
    * _To begin using the MVC application, run the command `$dotnet run`_
    * _To see the raw data via the browser: 'localhost:5000/api/localBusinesses'_
    * _To see the data in json format or to explore CRUD functionality, use postman: 'localhost:5000/api/localBusinesses'_

## Known Bugs

* _Nothing yet_

## License

_MIT &copy; 2021 Sammai Gutierrez_
