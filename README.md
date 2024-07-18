# E-Commerce API

## Details

The e-commerce API streamlines user interactions and management, encompassing authentication, product handling, cart management, orders, and payments, providing a comprehensive solution for online store operations.

<div align="center">
   <img src="./assets/images/cover.jpg" width="100%">
</div>

## ⚙ Tools and Technologies used

1. **[C#](https://dotnet.microsoft.com/en-us/languages/csharp)**: The C# language is the most popular language for the .NET platform, a free, cross-platform, open-source development environment.
2. **[.NET Core](https://dotnet.microsoft.com/en-us/apps/aspnet)**: ASP.NET Core is an open-source modular web-application framework. It is a redesign of ASP.NET that unites the previously separate ASP.NET MVC and ASP.
3. **[Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)**: Microsoft SQL Server (Structured Query Language) is a proprietary relational database management system developed by Microsoft.
4. **[JWT (JSON Web Tokens)](https://jwt.io/)**: A standard for securely transmitting information between parties as JSON objects, commonly used for authentication and authorization in web applications.
5. **[Docker](https://www.docker.com/)**: Containerization platform that simplifies the deployment and management of applications by packaging them into portable containers, ensuring consistency across different environments.
6. **[Docker Compose](https://docs.docker.com/compose/)**: Tool for defining and running multi-container Docker applications, enabling seamless configuration and orchestration of complex application architectures.

---

## 🛠 Installation and setup

1. Install Docker [here](https://www.docker.com/get-started/)
2. Install Git [here](https://git-scm.com/downloads)
3. Create a working directory:

   ```bash
   mkdir ~/ECommerce && cd ~/ECommerce
   ```

4. Clone the repository

   ```bash
   git clone https://github.com/ak4m410x01/ECommerceAPI.git .
   ```

5. Start the application

   ```bash
    docker compose up -d
   ```

6. Access API: http://localhost:8080/Swagger/index.html

7. Access DB: localhost:1433

8. Don't forget .env file with variables
 

| Variable                               | Value                                                                                                        |
| -------------------------------------- | ------------------------------------------------------------------------------------------------------------ |
| SA_PASSWORD                            | P@ssw0rd                                                                                                     |
| ConnectionStrings\_\_DefaultConnection | Server=sqlserver;Database=SakanyDb;User ID=sa;Password=P@ssw0rd;Encrypt=False;Trust Server Certificate=True; |
| ASPNETCORE_ENVIRONMENT                 | Development                                                                                                  |

note:
these variables are for the lab environment only... don't use these in xxx production environments xxx

---

## 🛠 Documentation and Endpoints

1. [Postman]()
2. [Apidog]()

{
  "email": "int2.fernandes@gmail.com",
  "password": "Se@122506",
  "confirmPassword": "Se@122506"
}
