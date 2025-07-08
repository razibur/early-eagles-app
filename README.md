# 🏸 Early Eagles Badminton App

This project helps the **Early Eagles Badminton team** track and manage player availability. It's a full-stack web application built with **ASP.NET Core Web API** (backend) and **React + Tailwind CSS** (frontend).

---

## 📁 Project Structure

```
/early-eagles
├── backend/           # ASP.NET Core Web API
├── frontend/          # React with Tailwind CSS
└── README.md
```

---

## 🚀 Sprint 1 Goal

Build a **minimum viable product (MVP)** that allows players to:
- ✅ View a calendar
- ✅ Mark their availability
- ✅ Submit and fetch attendance data

---

## 🛠️ Technologies Used

### Backend
- ASP.NET Core Web API
- Entity Framework Core
- SQLite (for local development)

### Frontend
- React (with Next.js or CRA)
- Tailwind CSS

### DevOps
- GitHub for source control
- Render.com or Docker (for deployment)

---

## 🧪 Local Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/early-eagles-app.git
cd early-eagles-app
```

### 2. Backend Setup

```bash
cd backend
dotnet restore
dotnet ef database update
dotnet run
```

### 3. Frontend Setup

```bash
cd frontend
npm install
npm run dev
```

---

## 📅 Sprint 1 Status

| Feature                     | Status  |
|----------------------------|---------|
| Backend API setup          | ✅ Done |
| EF Core + SQLite           | ✅ Done |
| Basic REST API (Availability) | ✅ Done |
| React UI + calendar screen | ⏳ In Progress |
| GitHub integration         | ✅ Done |

---

## 🤝 Contributing

Currently maintained by a solo developer. Suggestions and collaboration ideas are welcome — open an issue or fork the project.

---

## 📄 License

[MIT License](LICENSE)
