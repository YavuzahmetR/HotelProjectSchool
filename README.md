# Hotel Management & Reservation System

An asynchronous, API-driven hotel administration and room booking platform developed with .NET 7. The system features a decoupled architecture where a rich administration UI consumes a central RESTful API to manage hotel operations, social proof counters, real-time mail notifications, and automated database-level statistics.

## 🚀 Key Features

* **Decoupled API-First Architecture:** Built on top of an API-consuming infrastructure, ensuring the presentation layer interacts purely with endpoints via asynchronous HTTP clients.
* **Robust Authentication & Identity:** Integrated ASP.NET Core Identity for secure user enrollment and role-based dashboard access, enforcing strict password complexity rules.
* **Automated Data Sync via SQL Triggers:** Implemented native SQL database triggers to dynamically adjust room, guest, and staff counts in real-time upon record mutations.
* **Social Media Follower Integration:** Integrates with the RapidAPI dashboard to fetch and cache live follower metrics from Twitter, Instagram, and LinkedIn.
* **Automated Mail Delivery:** Built-in SMTP engine powered by MailKit to authenticate through secure app-specific keys and send operational/administrative emails.

## 🛠️ Tech Stack & Dependencies

* **Backend Engine:** .NET 7 (C#)
* **Architecture:** N-Layer Data Architecture (MVC, Web API, DataAccess, Business, Entity, DTO)
* **ORM & Database:** Entity Framework Core & SQL Server (LocalDB)
* **Security & Auth:** ASP.NET Core Identity
* **Third-Party Services:** RapidAPI (Social Analytics), MailKit & MimeKit (SMTP Service)
* **Validation:** FluentValidation
