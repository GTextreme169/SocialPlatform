# Project Structure

[MVP Features](MVP.md#features)

## Introduction
The Project is divided into 3 main parts:
1. **Client (Frontends)**: The part of the project that the user interacts with.
2. **Server (Backend)**: The part of the project that the user does not interact with.
3. **Core**: The part of the project that is shared between the Client and the Server.
    - Data Models
    - JSON Responses
    - Helper Functions
    - Validators
    - Interfaces

## Client
The Client is divided into 3 main parts:
1. **Web**: The web interface that the user interacts with.
2. **MAUI (Mobile/Desktop)**: The mobile interface that the user interacts with.
3. **Shared**: The shared code between the Web and MAUI interfaces.
    - Blazor Components
    - Services (or abstraction of services)
    - Helper Functions

## Server
The Server is divided into a single part: (for now)
1. **Server**: The server-side code that the Client interacts with.
    - Controllers
    - Services
    - Helper Functions