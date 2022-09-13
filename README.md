#### 📬 Find me at
[![Github Badge](http://img.shields.io/badge/-Github-black?style=flat&logo=github&link=https://github.com/mkaanerinc/)](https://github.com/mkaanerinc/) 
[![Linkedin Badge](https://img.shields.io/badge/-LinkedIn-blue?style=flat&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/mkaanerinc/)](https://www.linkedin.com/in/mkaanerinc)
[![Hackerrank Badge](https://img.shields.io/badge/-Hackerrank-2EC866?style=flat&logo=HackerRank&logoColor=white&link=https://www.hackerrank.com/mkaanerinc)](https://www.hackerrank.com/mkaanerinc)
[![Gmail Badge](https://img.shields.io/badge/-Gmail-d14836?style=flat&logo=Gmail&logoColor=white&link=mailto:mkaanerinc@gmail.com)](mailto:mkaanerinc@gmail.com)

<br />
<p align="center">
  <h2 align="center">eTickets</h2>
</p>
<br />
<p>

# About The Project

## Built With

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=flat&logo=c-sharp&logoColor=white)&nbsp;
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=flat&logo=.net&logoColor=white)&nbsp;
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=flat&logo=microsoft%20sql%20server&logoColor=white)&nbsp;
![Entity-Framework](https://img.shields.io/badge/Entity%20Framework%20Core-004880?style=flat&logo=nuget&logoColor=white)&nbsp;
![ASP .NET CORE MVC](https://img.shields.io/badge/ASP%20.NET%20CORE%20MVC-004880?style=flat&logo&logo=nuget&logoColor=white)&nbsp;
![.NET IDENTITY](https://img.shields.io/badge/.NET%20IDENTITY-004880?style=flat&logo&logo=nuget&logoColor=white)&nbsp;
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=flat&logo=visual-studio&logoColor=white)&nbsp;

## Some of the topics that this app covers

<details>
  <summary>Click to see topics</summary>

* Models vs ViewModels

* Views vs PartialViews

* SQL server configuration with Entity framework

* Entity Framework migrations

* Adding, Getting, Updating and Deleting data from an SQL database using Entity Framework

* Working with relational and non-relational data

* Dependency injection

* Major dependency injection lifetimes

* Static and generic services/repositories

* Model binding and validation

* Routing

* Cookie-based authentication

* Role-based authorization

* Role-based UI rendering

* Dynamic rendering with ViewComponents

</details><p></p>

## Models

<details>
  <summary>Click to see models</summary>

### Actors

| Name                | Data Type     | Allow Nulls |
| :-----------------  | :-----------  | :---------- |
| Id                  | int           | False       |
| ProfilePictureUrl   | nvarchar(MAX) | False       |
| FullName            | nvarchar(50)  | False       |
| Bio                 | nvarchar(MAX) | False       |

### Actors_Movies

| Name                         | Data Type     | Allow Nulls |
| :--------------------------  | :-----------  | :---------- |
| MovieId                      | int           | False       |
| ActorIdId                    | int           | False       |

### Producers

| Name                | Data Type     | Allow Nulls |
| :-----------------  | :-----------  | :---------- |
| Id                  | int           | False       |
| ProfilePictureUrl   | nvarchar(MAX) | False       |
| FullName            | nvarchar(50)  | False       |
| Bio                 | nvarchar(MAX) | False       |
  
### Cinemas

| Name                | Data Type     | Allow Nulls |
| :-----------------  | :-----------  | :---------- |
| Id                  | int           | False       |
| Logo                | nvarchar(MAX) | False       |
| Name                | nvarchar(50)  | False       |
| Description         | nvarchar(MAX) | False       |

### Movies

| Name                | Data Type     | Allow Nulls |
| :-----------------  | :-----------  | :---------- |
| Id                  | int           | False       |
| Name                | nvarchar(MAX) | False       |
| Description         | nvarchar(MAX) | False       |
| Price               | float         | False       |
| ImageUrl            | nvarchar(MAX) | False       |
| StartDate           | datetime2(7)  | False       |
| EndDate             | datetime2(7)  | False       |
| MovieCategory       | int           | False       |
| CinemaId            | int           | False       |
| ProducerId          | int           | False       |

### Orders

| Name                | Data Type     | Allow Nulls |
| :-----------------  | :-----------  | :---------- |
| Id                  | int           | False       |
| Email               | nvarchar(MAX) | True        |
| UserId              | nvarchar(MAX) | True        |

### OrderItems

| Name                | Data Type     | Allow Nulls |
| :-----------------  | :-----------  | :---------- |
| Id                  | int           | False       |
| Amount              | int           | False       |
| Price               | float         | False       |
| MovieId             | int           | False       |
| OrderIdId           | int           | False       |

### ShoppingCartItems

| Name                | Data Type     | Allow Nulls |
| :-----------------  | :-----------  | :---------- |
| Id                  | int           | False       |
| MovieId             | int           | True        |
| Amount              | int           | False       |
| ShoppingCartId      | nvarchar(MAX) | True        |

</details><p></p>

## Required Packages for Back-End

<details>
<summary>Click to see required packages</summary>

| Package Name  | Version |
| ------------- | ------------- |
| Microsoft.AspNetCore.Identity.EntityFrameworkCore  | 5.0.17  |
| Microsoft.EntityFrameworkCore  | 5.0.17  |
| Microsoft.EntityFrameworkCore.Tools  | 5.0.17  |
| Microsoft.EntityFrameworkCore.SqlServer  | 5.0.17  |

</details><p></p>

# License

Distributed under the MIT License. See `LICENSE` for more information.

# Contact

Mustafa Kaan Erinç - [Linkedin](https://www.linkedin.com/in/mkaanerinc/) [Gmail](mailto:mkaanerinc@gmail.com)
