# 🏢 IT Request Management System (ORASCOM)

**An Enterprise Workflow Automation Platform**

This project is a robust, centralized system developed to streamline, manage, and automate internal IT requests and ticketing workflows. The core engine is built entirely on the **.NET framework**, providing a secure, scalable, and high-performance backend architecture that processes business logic and data management.

## 🚀 Architecture & Tech Stack

The system is designed with a strong emphasis on backend architecture, separating the core business logic from the presentation layer.

### ⚙️ The Core Engine (Backend)
*   **Framework:** .NET (C#)
*   **Architecture:** Layered Architecture (Controllers, Services, Data Access)
*   **Database:** MS SQL Server
*   **ORM:** Entity Framework (EF)
*   **Security:** Role-Based Access Control (RBAC) and secure data transactions.

### 🖥️ The Client Application (Frontend)
*   **Technology:** VB.NET (Desktop Client)
*   **Purpose:** Serves as a lightweight user interface that consumes and interacts with the powerful .NET core services to display data to the end-users.

## ✨ Key Features (Backend Highlights)

*   **Workflow Automation:** Automates the lifecycle of an IT request from creation to resolution, reducing manual overhead.
*   **State Management:** Tracks request statuses (Pending, In Progress, Resolved) with precise timestamping and auditing.
*   **Data Integrity & Validation:** Strict backend validation ensures that no corrupt or incomplete data enters the enterprise database.
*   **Role Management:** Distinct permission levels for standard employees and IT Administrators.
*   **Optimized Queries:** Efficient database querying using Entity Framework to handle large volumes of enterprise requests seamlessly.

## 📂 Project Structure

```text
├── Backend (API)/           # The core .NET C# engine (Business logic, Models, DB Context)
│   ├── Controllers/         # Handles incoming client requests
│   ├── Models/              # Database entities and data structures
│   ├── Services/            # Core business logic and workflow rules
│   └── Data/                # Entity Framework configurations and Migrations
├── Frontend (V.B)/          # The lightweight VB.NET Desktop Client
│   ├── Forms/               # UI Screens (Login, Dashboard, Request Form)
│   └── API_Clients/         # Modules responsible for communicating with the .NET backend
└── README.md                # Project documentation
```
## 🛠️ Installation & Setup
To run this enterprise application locally:

1. Database & Backend Setup
Clone the repository:

```Bash
git clone [https://github.com/stevenashrafkamal/IT-Request-ORASCOM-Project.git](https://github.com/stevenashrafkamal/IT-Request-ORASCOM-Project.git)
```
2. Open the `.NET` Backend solution (`.sln`) in **Visual Studio**.
3. Restore the NuGet packages.
4. Update the Database Connection String in the configuration file to point to your local SQL Server instance.
5. Apply Entity Framework Migrations to generate the database schema:
   ```bash
   Update-Database
   
(Or run dotnet ef database update via CLI).

6. Build and run the Backend project.

2. Client Application Setup
Open the Frontend (V.B) project in Visual Studio.

Ensure the API endpoint configurations point to the running .NET backend URL.

Build and Run the desktop application.

## 👨‍💻 Developer
Steven Ashraf
Full-Stack Developer
