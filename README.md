Summary of File Storage API service

This simple File Storage API service application consists of four prjects:  1. Agorus.Domian, 2. Agorus.Repository, 3. AgoruaFileService.Tests, and 4. AgorusFileService.

This simple File Storage API service application has been developed in Microsoft Visual Studio Professional 2022. This software interacts with Microsoft SQL server 2019 and data files are stored in this SQL database.

1. The SQL database called AgorusDatabase can be restored from the backup file AgorusFileDatabase-2023-09-03, which contains only one table: FileData. This table Bars is used to save binary 
data. The table has 7 columns: ID, FileName, FileContent, CreateOn, CreatedBy,ModifiedOn and ModifiedBy, 
herein ID is designed as a primary key. 

2. The porject Agorus.Domian is created for building a library containing data models. The project Agorus.Repository is created for building database context and object relationship mappings.
AgorusFileService is created for providing simple file storage API services, and AgoruaFileService.Tests
is created for performing unit tests by using xUnit which is an open-source, community-driven testing framework. 

3. The Swagger UI is provided for testing file storage API services, including create, update, delete, retrieve data files. 

4. AgorusFileService and AgoruaFileService.Tests should be placed in the same directory.To run the simple 
file storage API service application, either Microsoft Visual Studio Professional 2022 or IIS server is required.
