# 🔐 Password Manager

A simple yet functional desktop Password Manager built using **WinForms**, **ADO.NET**, and **SQL Server**. This application helps users store, retrieve, and manage their passwords securely. It includes a built-in password generator and supports user **Sign Up / Login** with password **hashing** for security.

---

## 🧰 Features

- ✅ **User Authentication**
  - Sign Up and Login with password hashing
  - Secure password storage using SHA256 (or similar algorithm)

- 🔐 **Password Management (CRUD)**
  - Create, Read, Update, and Delete saved credentials
  - Categorize or tag entries (e.g., Email, Social Media, Banking, etc.)

- 🔄 **Password Generator**
  - Built-in tool to generate strong, random passwords

- 📁 **Database Integration**
  - Uses **SQL Server** as backend database
  - Data access via **ADO.NET**

---

## 💻 Technologies Used

- **C#**
- **Windows Forms (WinForms)**
- **ADO.NET**
- **SQL Server**
- **.NET Framework**


---

## 🔒 Security Considerations

- Passwords in the login system are **hashed** (e.g., using SHA256) before being stored in the database.
- Users can only access and manage their own saved credentials.
- Use parameterized SQL queries to prevent SQL injection.

---


