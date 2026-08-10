# SOLID Principles in C#

> Five small C#/.NET projects, one per SOLID principle, showing the "before" and "after" of applying it.

---

## 🧩 Problem / Context

Repo from a Platzi course on C# best practices (2024). Each folder is an independent console project (or API) that isolates **a single principle**, so you can see the design problem and the refactor without the noise of a larger codebase.

---

## 🛠️ Stack

| Layer           | Technology                          |
|-----------------|--------------------------------------|
| Language        | C# / .NET 6 and .NET 8              |
| Project type    | Console apps (1-4) and Web API + xUnit (5) |
| API docs        | Swagger / OpenAPI (project 5 only)  |

---

## 🏗️ Architecture

No single diagram applies here: these are 5 independent projects inside one solution (`.sln`), each with its own `.csproj`. The exception is principle 5, which does split into layers (`Api` + `Api.Tests`), since that's where Dependency Inversion is demonstrated with real dependency injection via `IStudentRepository` / `ILogbook`.

---

## 🧠 Principles and decisions

- **1. Single Responsibility** (`1-SingleResponsability`) — `StudentRepository` only handles data access and `ExportHelper` only handles exporting. Before, both responsibilities lived in a single class.
- **2. Open/Closed** (`2-OpenClose`) — `Employee` is the abstract base class; `EmployeeFullTime`, `EmployeePartTime`, and `EmployeeContractor` each calculate their own salary. Adding a new employee type doesn't require touching existing code.
- **3. Liskov Substitution** (`3-LiskovSubstitution`) — `Employee` subclasses are interchangeable without breaking the `CalculateSalary()` contract, unlike a poorly designed hierarchy where a subclass breaks what the client expects from the parent.
- **4. Interface Segregation** (`4-InterfaceSegregation`) — Instead of one fat `IActivities` interface, it's split into `IWorkTeamActivities`, `IDesignActivities`, `IDevelopActivities`, and `ITestActivities`. `Developer` and `Tester` only implement what applies to them.
- **5. Dependency Inversion** (`5-DependencyInversion`) — `StudentController` depends on the abstractions `IStudentRepository` and `ILogbook`, not on their concrete implementations, which are wired up via DI in `Program.cs`. Includes a real API (Swagger) and xUnit tests.

---

## 🚀 How to run it

```bash
git clone https://github.com/Carlou134/curso-principios-solid-csharp-1-reponsabilidadunica.git
cd curso-principios-solid-csharp-1-reponsabilidadunica

# Any console project (1 to 4)
dotnet run --project 1-SingleResponsability

# Project 5 (Web API with Swagger)
dotnet run --project 5-DependencyInversion/Api
```
