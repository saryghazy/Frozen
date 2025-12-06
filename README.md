# Frozen Tunnel Project

This project simulates a frozen tunnel where ice blocks ('I') melt after three consecutive air cells ('___') appear. It demonstrates the use of:

- **Object-Oriented Programming (OOP):**  
  The project is organized using classes such as `FrozenTunnel`, `IceMelter`, and `TunnelPrinter`, each with a single responsibility.

- **Data Structures:**  
  Uses `List<char>` to store the tunnel state and efficiently track ice melting positions.

- **SOLID Principles:**  
  - **S (Single Responsibility):** Each class has a clear responsibility.  
  - **O (Open/Closed):** Easy to extend with new melting strategies.  
  - **L (Liskov Substitution):** Interfaces allow substituting different types of melters.  
  - **I (Interface Segregation):** `IMeltable` interface is small and specific.  
  - **D (Dependency Inversion):** Classes depend on abstractions rather than concrete implementations.

## How to Run
1. Clone the repository.
2. Open in Visual Studio.
3. Build and run the `Program` class.
4. Observe the tunnel state and total melted ice blocks.

