# Laboratory Work Nr.2
### How to start the application
* Download the application from this repository;
* Open Microsoft SQL Server Management Studio;
* Connect to the server;
* Create on your server a database named "eUseControl";
* Open the application in Visual Studio;
* In the file Web.config which is in eUseControl.Web project change:
  * addname = "eUseControl";
  * connectionString="Data Source = Name of Your Server";
  * InitialCatalog = eUseControl;
* Open NuGet Package Manager Console and type update-database;
* Run the application;
