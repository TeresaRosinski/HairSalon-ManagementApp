# _Hair Salon Management App_

#### _7.31.20_

#### By _**Teresa Rosinski**_



# Setup/Installation Requirements

* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program


# SQL Schema Query #

```
CREATE DATABASE IF NOT EXISTS teresa_rosinski; USE teresa_rosinski;
DROP TABLE IF EXISTS `clients`;
SET character_set_client = utf8mb4 ;
CREATE TABLE `clients` (
 `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `ClientNotes` varchar(255) DEFAULT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  `EmailAddress` varchar(45) DEFAULT NULL,
  `StylistId` int(11) DEFAULT '0',
  PRIMARY KEY (`ClientId`)
)

DROP TABLE IF EXISTS `stylists`;
CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `ClientId` int(11) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Title` varchar(255) DEFAULT NULL,
   PRIMARY KEY (`StylistId`)
 )
```

# Importing creating this Database in MySql

 * Open MySql
 * Click the Schema tab at the top of the program
 * Right click in the box that holds the 'sys' table
 * Select 'create schema'
 * Name the schema 'teresa_rosinski'
 * Click 'Apply' at the bottom of the page
 * Create two tables that model the data above
 * Navigate to the appsettings.json file in the VS Code
 * Change the database password to reflect your password for MySql
 * Run these commands in the terminal : 
    * dotnet restore
    * dotnet build


# Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program creates instance of the Stylist class** | N/A | N/A |
| **Program creates instance of the Client class** | N/A | N/A |
| **Program only allows the user to add stylists** | "N/A" | "N/A"  |
| **Program only allows user to see all stylists** | "N/A" | "N/A"  |
| **Program adds clients to specific stylists** | "Client: Ann" | "Client Added to Tom's Client List" |
| **Program only allows user to select a stylist and see a list of their clients** | "N/A" | "N/A"  |
| **Program only allows each client to have one stylist** | "N/A" | "N/A"  |

### Strech Goals
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
|**Clients can leave Requests for Stylists**| N/A | N/A|
|**Stylists can leave Comments for Clients**| N/A | N/A |
|**Clients can sign up for specific Appointments**|N/A | N/A|
|**When a Client signs up for an appointment, they can attach pictures of styles they prefer** | N/A | N/A |

# Support and contact details

_For question, concerns, or if you would like to make contributions to this work, please contact Teresa Rosinski at trosinski89@gmail.com_

# Technologies Used

* VSCode
* C#
* MySqL
* Entity Framework
* .NET Core
* BootStrap

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Teresa Rosinski_**
