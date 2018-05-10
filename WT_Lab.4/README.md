# Laboratory Work Nr.3
### How to start the application
* Download the application from this repository;
* Open Microsoft SQL Server Management Studio;
* Connect to the server;
* Create on your server a database named "StoreDataBase";
* Open the application in Visual Studio;
* In the file Web.config which is in eUseControl.Web project change:
  * addname = "StoreDataBase";
  * connectionString="Data Source = Name of Your Server";
  * InitialCatalog = StoreDataBase;
* Open NuGet Package Manager Console and type update-database;
* Run the application;
