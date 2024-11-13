# Tourism Accommodation Management System
### Developed By: Tiago Carneiro
**Number:** 28002
**Course:** Information Systems Engineering
**University:** IPCA

### Overview
The Tourism Accommodation Management System is a C# application built using Windows Forms. Designed for managing tourist accommodations, it supports various functions including user registration, client and accommodation management, reservations, and check-ins. This system provides an intuitive interface for managing client information and accommodations, simplifying the process for administrators in the tourism sector.

### Features
**User Management:** Supports adding new users with roles, login functionality, and user role assignment (e.g., admin, client).
**Client Management:** Stores and retrieves client data, allowing for quick access and efficient customer support.
**Accommodation Management:** Manages information about available accommodations, including booking status, and amenities.
**Reservations and Check-ins:** Supports reservations, check-ins, and check-outs, helping manage occupancy efficiently.
**Data Persistence:** User and client data is stored and loaded from local text files, ensuring data retention between sessions.

### Project Structure
**Objects:** Contains object classes, including User, Client, and Accommodation.
**Dados:** Handles data storage and loading functions, responsible for reading and writing data to text files.
**Excecoes:** Custom exception classes to handle data validation and user interaction errors.
**Forms:** UI forms for interaction, including user registration, client information, and accommodation booking.

### Usage
**User Registration:** Register new users by entering name, email, birth date, and role.
**Accommodation Management:** View and edit accommodation details, set availability, and manage amenities.
**Reservation and Check-ins:** Make reservations for clients, confirm check-ins, and update occupancy status.
