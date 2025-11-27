📚 UML & C# Class Diagrams Reference Guide
==========================================

**License**
[MIT License](https://www.google.com/search?q=LICENSE "null")

**Language**
C#

**Framework**
.NET 8 / .Net 10

📝 Description
--------------

This repository serves as a practical, code-based reference guide for key concepts in **Unified Modeling Language (UML) Class Diagrams**, with corresponding implementation examples written in **C#** and **.NET 8**.

It is intended for students reviewing or learning core object-oriented design principles, specifically focusing on how UML concepts translate directly into executable C# code.

### 🧭 Project Structure

The entire project is organized within the `ParentDiagrams/` folder.

**Path**
`ParentDiagrams/KlassenDiagran_UML.ipynb`
`ParentDiagrams/KlasDemoKlasDiagrammen2`
`ParentDiagrams/KlasDemoKlasDiagrammen3`

**Content**
Jupyter Notebook
Solution (.slnx)
Solution (.slnx)


**Purpose**
Contains the *theoretical summary* and **reference symbols** for UML elements and relationships.
Practical examples demonstrating **Composition** and **Aggregation** (*Has-a*) relationships.
Practical examples demonstrating **Inheritance** and **Abstract Classes** (*Is-a*).

🛠️ Concepts Demonstrated (C# Examples)
---------------------------------------

### KlasDemoKlasDiagrammen2: Composition & Aggregation (The "*Has-A*" Relationship)

-   **Composition (Ruit Vol):** Demonstrated by the `CarCompositie` class. The `Engine` is created *inside* the car's constructor, meaning the Engine **cannot exist** without the car.

-   **Aggregation (Ruit Hol):** Demonstrated by the `CarAggregatie` class. The `Engine` is passed into the constructor, meaning the Engine **exists independently** of the car.

### KlasDemoKlasDiagrammen3: Inheritance & Abstraction (The "*Is-A*" Relationship)

-   **Abstract Class & Interface:** The `Company` class is *abstract* and implements the `ICompany` interface.

-   **Inheritance (Overerving):** The `GameCompany` class inherits from the `Company` abstract class, demonstrating *specialization* and concrete implementation.

-   **Association:** The `Game` class maintains a `List<Person>` (Players), demonstrating a simple one-to-many relationship where objects are connected.

🚀 Usage / Getting Started
--------------------------

You will need **Visual Studio 2022** or the **.NET 8 SDK** installed to work with these projects.

### 1\. Clone the Repository

Use the following command to download the project locally:

```
git clone [Your Repository URL]
cd KlassenDiagram_Samenvatting
```

### 2\. Open Solutions in Visual Studio

Navigate into the `ParentDiagrams` folder and open the required solution files:

-   Open `ParentDiagrams/KlasDemoKlasDiagrammen2/KlasDemoKlasDiagrammen2.slnx`

-   Open `ParentDiagrams/KlasDemoKlasDiagrammen3/KlasDemoKlasDiagrammen3.slnx`

### 3\. Run the Examples

The console projects (`*.Cons`) within each solution contain the main execution logic (`Program.cs`) demonstrating the relationships.

### 4\. Reference Documentation

For the theoretical breakdown of UML symbols and definitions, view the notebook:

-   View `ParentDiagrams/KlassenDiagran_UML.ipynb` directly on GitHub or open it in VS Code/Jupyter.

🤝 Contributing
---------------

This project is licensed under the [**MIT License**](https://www.google.com/search?q=LICENSE "null").

We welcome contributions, suggestions, and corrections! Improving these examples benefits all students who use this repository.

1.  **Fork the repository** and create a feature branch (`git checkout -b feature/my-improvement`).

2.  **Commit your changes** with clear and descriptive messages.

3.  **Submit a Pull Request** for review against the appropriate target branch (`dev` or `main`).

Please feel free to open an [**Issue**](https://www.google.com/search?q=https://github.com/GianniDeCock/KlassenDiagram_Samenvatting/issues "null") to report any bugs in the code or suggest new concepts to include.
