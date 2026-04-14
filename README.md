---

# 📘 Examination System

A scalable and modular **Online Examination System** built with **ASP.NET Core Minimal APIs**, designed to handle complete exam workflows — from creation to evaluation and reporting.

---

## 🚀 Overview

This system enables institutions to:

* Create and manage tests
* Add questions dynamically
* Allow users to attempt exams
* Automatically evaluate results
* Generate reports and analytics

---

## 🎯 Key Features

* 🔐 User Registration & Login
* 📝 Test Creation & Publishing
* ❓ Question & Options Management
* ⏱️ Timed Test Attempts
* 📊 Auto Evaluation
* 📈 Result Tracking
* 📑 Report Generation

---

## 🏗️ Architecture

```
Frontend (React / JS)
        ↓
Minimal API Endpoints
        ↓
Services (Business Logic)
        ↓
Entity Framework Core
        ↓
SQL Server
```

---

## 🛠️ Tech Stack

| Layer    | Technology                 |
| -------- | -------------------------- |
| Backend  | ASP.NET Core (Minimal API) |
| ORM      | Entity Framework Core      |
| Database | SQL Server                 |
| API      | RESTful APIs               |
| Tools    | Postman, Git               |

---

# 🌐 API BASE URL

```bash
http://localhost:5179/api
```

---

# 👤 User APIs

## 🔹 Register

**POST** `/users/register`

```json
{
  "role": "Student",
  "name": "Sonu",
  "email": "sonu@gmail.com",
  "password": "123456"
}
```

### ✅ Response

```json
{
  "id": 1,
  "name": "Sonu",
  "email": "sonu@gmail.com",
  "role": "Student"
}
```

---

## 🔹 Login

**POST** `/users/login`

```json
{
  "email": "sonu@gmail.com",
  "password": "123456"
}
```

---

# 📝 Test APIs

## 🔹 Create Test

**POST** `/tests`

```json
{
  "name": "Math Test",
  "subject": "Math",
  "description": "Basic Algebra",
  "duration": 60
}
```

---

## 🔹 Get All Tests

**GET** `/tests/all`

---

## 🔹 Get Published Tests

**GET** `/tests`

---

## 🔹 Get Test By Id

**GET** `/tests/{id}`

---

## 🔹 Publish Test

**PUT** `/tests/{id}/publish`

---

# ❓ Question APIs

## 🔹 Create Question

**POST** `/questions`

```json
{
  "testId": 1,
  "questionText": "2 + 2 = ?",
  "options": [
    { "text": "3", "isCorrect": false },
    { "text": "4", "isCorrect": true }
  ]
}
```

---

## 🔹 Get Questions by Test

**GET** `/questions/{testId}`

---

## 🔹 Delete Question

**DELETE** `/questions/{id}`

---

# 🧠 Attempt APIs

## 🔹 Start Attempt

**POST** `/attempts/start`

```json
{
  "userId": 1,
  "testId": 1
}
```

---

## 🔹 Submit Answer

**POST** `/attempts/answer`

```json
{
  "attemptId": 1,
  "questionId": 2,
  "selectedOptionId": 3
}
```

---

## 🔹 Submit Test

**POST** `/attempts/{attemptId}/submit`

---

# 📊 Result APIs

## 🔹 Get All Results

**GET** `/results`

---

## 🔹 Get Results by User

**GET** `/results/user/{userId}`

---

## 🔹 Get Result by Attempt

**GET** `/results/{attemptId}`

---

### ✅ Sample Response

```json
{
  "attemptId": 1,
  "userId": 1,
  "userName": "Sonu",
  "testId": 1,
  "testName": "Math Test",
  "totalScore": 5,
  "isPassed": true,
  "attemptDate": "2026-04-13T16:30:00"
}
```

---

# 📑 Report APIs

## 🔹 Get Reports

**GET** `/reports`

---

### ✅ Sample Response

```json
{
  "testId": 1,
  "testName": "Math Test",
  "totalAttempts": 10,
  "passedCount": 6,
  "failedCount": 4,
  "averageScore": 3.5
}
```

---

# ⚙️ Setup Instructions

### 1️⃣ Clone Repository

```bash
git clone https://github.com/D-pex/Examination-System-.git
cd Examination-System-
```

---

### 2️⃣ Configure Database

Update connection string in:

```json
appsettings.json
```

---

### 3️⃣ Run Backend

```bash
dotnet run
```

---

# 🔒 Security Notes

* Password stored in plain text (not secure)
* JWT Authentication can be added
* Role-based access can be implemented

---

# 🚀 Future Enhancements

* JWT Authentication 🔐
* Role-based Authorization
* Leaderboard System 🏆
* Advanced Analytics Dashboard 📊
* Frontend Integration (React)
* Timer-based auto submit

---

# 👨‍💻 Author

**D-Pex**

---

# ⭐ Support

If you found this helpful, give it a ⭐ on GitHub!
