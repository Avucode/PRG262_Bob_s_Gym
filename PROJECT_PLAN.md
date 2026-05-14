# Project plan
** Project Bob's Gym **
**Authors:** Hanro Lombard

# 1. Project Overview

### Description
This is a project we were given for a module called PRG 262, the goal was to create
a Windows-based .NET Framework forms GUI application for a local gym to manage memmber information.
The application should feature CRUD operations for persistemt storage, these data must be stored 
in SQL databases.

### Goals & Objectives
 	- Provide secure staff login wit account lockout after 3 failed attempts.
    - Enable efficient and robust management of members  and classes/Training programs
    - Implement robust CRUD ops using ADO.NET and SQL stored procedures.
    - Deliver a user-friendly GUI system for gym staff

### Target audience: 
    Gym staff / admins

### Functional Requirements (As per project file)
    - Login Form (username + password)
    - Store creds in text file
    - 3 failed attempts -> lock account (admin has to unlock)
    - Staff registration

### Member management
    - Fields required: classID, Name, Desc, Instructor, Schedule, Capacity, Duration
    - Full CRUD + Search + Display

### Non-Functional Requirements
    - Windows Forms GUI (user-friendly)
    - ADO.NET for database operations
    - SQL Server backend
    - Proper Exception Handling + Custom Exceptions
    - File I/O for authentication



