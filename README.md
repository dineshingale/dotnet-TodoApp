## 📖 Project Overview

A full-stack task management solution built to explore the latest capabilities of **.NET 10**.

This project deviates from the standard ASP.NET Core scaffolding by rejecting the default Bootstrap dependency in favor of **Tailwind CSS**. This architectural choice allows for a utility-first styling approach while maintaining the robust type-safety and performance of the .NET backend.

It demonstrates a modern integration pattern: utilizing **Razor Pages** for server-side logic and data rendering, coupled with a modern CSS framework for a responsive, custom UI.

## ⚙️ Technical Architecture

### Backend (.NET 10)
* **Razor Pages:** Implements a Page-Model architecture to cleanly separate UI presentation from request handling logic.
* **Entity Framework Core:** Utilizes code-first migrations to manage the SQLite database schema.
* **Data Validation:** Enforces strict server-side validation using Data Annotations (`[Required]`, `[StringLength]`) to ensure data integrity before persistence.
* **Dependency Injection:** Manages the `DbContext` lifecycle efficiently through the built-in DI container.

### Frontend (Tailwind CSS)
* **Custom Integration:** Replaced default framework styles with Tailwind CSS via CDN for rapid UI prototyping.
* **Component Design:** UI elements (Cards, Badges, Forms) are built using utility classes to ensure consistency across Create, Read, Update, and Delete views.
* **Interactive UX:** Includes hover states, visual feedback for task completion, and responsive layouts for mobile/desktop compatibility.

## 🚀 Getting Started

**Prerequisites:**
* .NET 10.0 SDK

**Installation:**

1.  **Clone the repository**
    ```bash
    git clone [https://github.com/yourusername/MyTodoApp.git](https://github.com/yourusername/MyTodoApp.git)
    cd MyTodoApp
    ```

2.  **Initialize the Database**
    This applies the Entity Framework migrations to generate the local SQLite file.
    ```bash
    dotnet ef database update
    ```

3.  **Run the Application**
    ```bash
    dotnet watch run
    ```

## 📸 Usage

The application supports full CRUD operations:
* **Dashboard:** View all active and completed tasks in a grid layout.
* **Management:** detailed Create and Edit forms with validation feedback.
* **Safety:** Dedicated confirmation views for destructive actions (Delete).