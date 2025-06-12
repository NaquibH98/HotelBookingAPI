# # 🏨 Hotel Booking API – Technical Assessment

Hi there, I hope you're having a good day. My name is Naquib and I am a fresh graduate from UiTM Jasin!

This project is a submission for the **Junior Back-End C# Developer Technical Assessment**. It's a simple RESTful API built using **ASP.NET Core (.NET 8)** and **Entity Framework Core (InMemory)** that allows users to view hotel rooms, make bookings, and list all existing bookings.

---

## 🚀 What the API Can Do

- ✅ View all available rooms
- ✅ Book a room for a guest
- ✅ View all bookings
- 🚫 Prevent booking if a room is already taken
- 🔁 Automatically sets a room as unavailable after booking
- 💻 Test all endpoints using Swagger UI

---

## 🛠️ Tech Stack Used

- **.NET 8**
- **ASP.NET Core Web API**
- **Entity Framework Core (InMemory provider)**
- **Swagger (Swashbuckle)** for API testing

---

## 🔧 How to Run the Project

> Make sure you have [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download) installed.

1. Clone the repository:
   ```bash
   git clone https://github.com/NaquibH98/HotelBookingAPI.git
   cd HotelBookingAPI
   ```

2. Run the project:
   ```bash
   dotnet run
   ```

3. Open your browser and go to:
   ```
   https://localhost:5001/swagger
   ```

This will open **Swagger UI**, where you can easily test all the endpoints.

---

## 🧪 API Endpoints Overview

### 1️⃣ GET `/api/rooms`

Returns all hotel rooms.

**Response example:**
```json
[
  {
    "id": 1,
    "name": "101",
    "type": "Single",
    "isAvailable": true
  }
]
```

---

### 2️⃣ GET `/api/bookings`

Returns all bookings, including guest info and the associated room.

**Response example:**
```json
[
  {
    "id": 1,
    "guestName": "Haziq",
    "roomId": 1,
    "checkInDate": "2025-06-15T14:00:00",
    "checkOutDate": "2025-06-17T12:00:00",
    "room": {
      "id": 1,
      "name": "101",
      "type": "Single",
      "isAvailable": false
    }
  }
]
```

---

### 3️⃣ POST `/api/bookings`

Creates a new booking. The room must be available.

**Request body example:**
```json
{
  "guestName": "Naquib",
  "roomId": 1,
  "checkInDate": "2025-06-15T14:00:00",
  "checkOutDate": "2025-06-17T12:00:00"
}
```

If the room is not available, you'll get:
```json
{
  "status": 400,
  "message": "Room is not available."
}
```

---

## 🏗️ Project Structure (Simplified)

```
HotelBookingAPI/
├── Controllers/
│   ├── RoomsController.cs
│   └── BookingsController.cs
├── Models/
│   ├── Room.cs
│   ├── Booking.cs
│   └── BookingCreateDto.cs
├── Data/
│   └── AppDbContext.cs
├── Program.cs
├── README.md
```

---

## 🧠 Design Decisions & Assumptions

- All rooms are initially available and pre-seeded on app start.
- Once a room is booked, it's immediately marked as unavailable.
- Date range conflict checks are not included for simplicity.
- Booking DTO (`BookingCreateDto`) is used to keep input clean.
- Project uses an in-memory database for quick testing (no setup needed).

---

## 💡 Ideas for Future Improvements

- [ ] Add cancellation or delete booking endpoint
- [ ] Handle overlapping date ranges (bookings on future dates)
- [ ] Add unit tests using xUnit
- [ ] Implement Clean Architecture (with Services and Repositories)
- [ ] Add logging and request validation

---

## 📬 Submission Notes

This repo is created for the assessment. Please let me know if you'd like me to enhance or extend the API in any way. Thank you for the opportunity! 

**GitHub Repo Link:** 👉 https://github.com/NaquibH98/HotelBookingAPI  
**Submission by:** Naquib Haziq
**Date:** 12th June 2025

---
