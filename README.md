# CTSProject


[project file link](https://cognizantonline.sharepoint.com/:b:/r/sites/GTP-Solutions/Gencsharepath/Shared%20Documents/Internship%202025/ADM-DE%20FSE%20Tracks%20-%20Project%20Case%20Studies/Smart%20Hotel%20Booking%20System.pdf?csf=1&web=1&e=ObuBLL)

# Smart Hotel Booking System

## Introduction
This document outlines the Low-Level Design (LLD) for a Smart Hotel Booking System, which allows users to search, book, and manage hotel reservations. The platform supports hotel owners in listing their properties, defining room availability, and handling payments. This design supports both Java (Spring Boot) and .NET (ASP.NET Core) frameworks for backend development.

## Module Overview

### 1. User & Role Management
- Role-based access control (Admin, Hotel Manager, Guest).
- Secure user authentication and profile management.

### 2. Hotel & Room Management
- Hotel managers can list hotels and manage rooms.
- Set room types, pricing, amenities, and availability.

### 3. Booking & Payment Processing
- Users can search, book, and pay for rooms securely.
- Integration with payment gateways for transactions.

### 4. Reviews & Ratings
- Guests can rate hotels and leave reviews.
- Hotels can respond to feedback.

### 5. Loyalty & Rewards Program
- Guests earn reward points for bookings.
- Redeem points for discounts on future stays.

## Architecture Overview

### Architectural Style
- Frontend: Angular or React
- Backend: REST API-based architecture
- Database: Relational Database (MySQL/SQL Server)

### Component Interaction
- Frontend communicates with the backend via REST APIs.
- Backend manages hotel data, booking operations, and payments.

## Module-Wise Design

### 1. User & Role Management Module
#### Features
- User authentication using JWT tokens.
- Role-based permissions: Admin, Hotel Manager, Guest.

#### Data Flow
1. Users register and log in.
2. Role-based permissions are assigned.
3. Admins manage hotel manager accounts.

#### Entities
- User (UserID, Name, Email, Password, Role, ContactNumber)

### 2. Hotel & Room Management Module
#### Features
- Hotel managers can list and manage hotels.
- Define room types, pricing, and amenities.

#### Data Flow
1. Hotel managers add hotel details and room inventory.
2. Users search for available rooms.
3. Availability updates when bookings are confirmed.

#### Entities
- Hotel (HotelID, Name, Location, ManagerID, Amenities, Rating)
- Room (RoomID, HotelID, Type, Price, Availability, Features)

### 3. Booking & Payment Processing Module
#### Features
- Users can search and book rooms.
- Secure payment processing and booking confirmation.

#### Data Flow
1. Users select a hotel and book a room.
2. Payments are processed securely.
3. Booking details are sent to users and hotel managers.

#### Entities
- Booking (BookingID, UserID, RoomID, CheckInDate, CheckOutDate, Status, PaymentID)
- Payment (PaymentID, UserID, BookingID, Amount, Status, PaymentMethod)

### 4. Reviews & Ratings Module
#### Features
- Guests can rate hotels and write reviews.
- Hotels can respond to reviews.

#### Data Flow
1. Users submit reviews after their stay.
2. The system moderates and publishes reviews.
3. Hotel managers can respond to feedback.

#### Entities
- Review (ReviewID, UserID, HotelID, Rating, Comment, Timestamp)

### 5. Loyalty & Rewards Program Module
#### Features
- Guests earn points for bookings.
- Points can be redeemed for discounts.

#### Data Flow
1. When a user books a hotel, reward points are added to their account.
2. Users can view their accumulated points.
3. At checkout, users can redeem points for discounts.

#### Entities
- LoyaltyAccount (LoyaltyID, UserID, PointsBalance, LastUpdated)
- Redemption (RedemptionID, UserID, BookingID, PointsUsed, DiscountAmount)

## Deployment Strategy

### Local Deployment
- Frontend Deployment: Angular/React dev server.
- Backend Deployment: Spring Boot/ASP.NET Core locally.
- Database: MySQL/PostgreSQL/SQL Server.

## Database Design

### Tables and Relationships
- User (UserID, Name, Email, Password, Role, ContactNumber)
- Hotel (HotelID, Name, Location, ManagerID, Amenities, Rating)
- Room (RoomID, HotelID, Type, Price, Availability, Features)
- Booking (BookingID, UserID, RoomID, CheckInDate, CheckOutDate, Status, PaymentID)
- Payment (PaymentID, UserID, BookingID, Amount, Status, PaymentMethod)
- Review (ReviewID, UserID, HotelID, Rating, Comment, Timestamp)
- LoyaltyAccount (LoyaltyID, UserID, PointsBalance, LastUpdated)
- Redemption (RedemptionID, UserID, BookingID, PointsUsed, DiscountAmount)

## User Interface Design

### Wireframes
- Guest Dashboard: Search and book rooms.
- Hotel Manager Dashboard: List and manage hotel properties.
- Admin Panel: Manage hotels, users, and reviews.
- Loyalty Program Page: View and redeem points.

## Non-Functional Requirements

### Performance
- Handles high-traffic room searches efficiently.

### Scalability
- Supports multiple hotel chains and properties.

### Security
- Secure JWT-based authentication.
- Encrypted payment transactions.

### Usability
- Mobile-friendly interface for seamless booking experience.

## Assumptions and Constraints

### Assumptions
- Users can cancel bookings up to 24 hours before check-in.
- Hotels must verify their identity before listing.

### Constraints
- The system must support different currencies for payments.
- Hotels must comply with legal policies for cancellations and refunds.
