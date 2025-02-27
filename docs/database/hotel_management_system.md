```sql
CREATE TABLE Hotels (
  hotel_id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(100) NOT NULL,
  address VARCHAR(255),
  phone VARCHAR(20),
  email VARCHAR(100)
);

CREATE TABLE RoomTypes (
  room_type_id INT PRIMARY KEY AUTO_INCREMENT,
  type_name VARCHAR(50) NOT NULL, -- Standard/Deluxe/Suite
  description TEXT,
  base_price DECIMAL(10,2) NOT NULL
);

CREATE TABLE BedTypes (
  bed_type_id INT PRIMARY KEY AUTO_INCREMENT,
  type_name VARCHAR(50) NOT NULL, -- King/Single/Dual
  capacity INT NOT NULL
);

CREATE TABLE Rooms (
  room_id INT PRIMARY KEY AUTO_INCREMENT,
  hotel_id INT NOT NULL,
  room_type_id INT NOT NULL,
  bed_type_id INT NOT NULL,
  room_number VARCHAR(10) NOT NULL,
  FOREIGN KEY (hotel_id) REFERENCES Hotels(hotel_id),
  FOREIGN KEY (room_type_id) REFERENCES RoomTypes(room_type_id),
  FOREIGN KEY (bed_type_id) REFERENCES BedTypes(bed_type_id)
);

CREATE TABLE Seasons (
  season_id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(50) NOT NULL, -- Peak/Off-peak
  start_date DATE NOT NULL,
  end_date DATE NOT NULL,
  multiplier DECIMAL(3,2) NOT NULL -- e.g., 1.20 for 20% increase
);

CREATE TABLE Promotions (
  promotion_id INT PRIMARY KEY AUTO_INCREMENT,
  code VARCHAR(20) UNIQUE NOT NULL,
  discount_type ENUM('percentage', 'fixed') NOT NULL,
  discount_value DECIMAL(10,2) NOT NULL,
  start_date DATE NOT NULL,
  end_date DATE NOT NULL
);

CREATE TABLE AdditionalServices (
  service_id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(100) NOT NULL, -- Breakfast/Spa/Parking
  price DECIMAL(10,2) NOT NULL,
  is_recurring BOOLEAN DEFAULT false -- Daily service or one-time
);

CREATE TABLE Users (
  user_id INT PRIMARY KEY AUTO_INCREMENT,
  email VARCHAR(100) UNIQUE NOT NULL,
  phone VARCHAR(20),
  first_name VARCHAR(50),
  last_name VARCHAR(50)
);

CREATE TABLE Bookings (
  booking_id INT PRIMARY KEY AUTO_INCREMENT,
  user_id INT NOT NULL,
  room_id INT NOT NULL,
  check_in DATE NOT NULL,
  check_out DATE NOT NULL,
  base_price DECIMAL(10,2) NOT NULL,
  seasonal_multiplier DECIMAL(3,2) NOT NULL,
  promotion_discount DECIMAL(10,2) DEFAULT 0.00,
  total_price DECIMAL(10,2) NOT NULL,
  status ENUM('pending', 'confirmed', 'canceled') DEFAULT 'pending',
  FOREIGN KEY (user_id) REFERENCES Users(user_id),
  FOREIGN KEY (room_id) REFERENCES Rooms(room_id)
);

CREATE TABLE BookingServices (
  booking_service_id INT PRIMARY KEY AUTO_INCREMENT,
  booking_id INT NOT NULL,
  service_id INT NOT NULL,
  quantity INT DEFAULT 1,
  FOREIGN KEY (booking_id) REFERENCES Bookings(booking_id),
  FOREIGN KEY (service_id) REFERENCES AdditionalServices(service_id)
);
```
