# ASPNETCore_SimpleAPI
A simple API of an employees informations CRUD

How to start:

1. Open project on Visual Studio

2. Set your Connection String on 'appsettings.json'

3. On the Package Manager Console run 'Update-Database'
    * It will create an new Database (from 'Initial' migration).
    * Be sure that the service for SQL server is ruuning.

4. CRTL+F5 to start application
    * It will seed the Database (DBInitializer present on 'program.cs') with 3 objects 'Employees'.
    
5. API ready to be used (through Repositories).
