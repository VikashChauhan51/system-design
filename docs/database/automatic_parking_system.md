```sql
CREATE TABLE vehicle_type (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(20) NOT NULL UNIQUE,  -- Bike, Car, Bus
    space_required INT NOT NULL        -- 1, 2, 4
);

CREATE TABLE vehicle (
    id INT PRIMARY KEY AUTO_INCREMENT,
    license_plate VARCHAR(20) NOT NULL UNIQUE,
    vehicle_type_id INT NOT NULL,
    FOREIGN KEY (vehicle_type_id) REFERENCES vehicle_type(id)
);

CREATE TABLE floor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    floor_number INT NOT NULL UNIQUE,
    total_slots INT NOT NULL
);

CREATE TABLE slot (
    id INT PRIMARY KEY AUTO_INCREMENT,
    floor_id INT NOT NULL,
    slot_number INT NOT NULL,
    parking_session_id INT DEFAULT NULL,
    FOREIGN KEY (floor_id) REFERENCES floor(id),
    UNIQUE (floor_id, slot_number)
);

CREATE TABLE parking_session (
    id INT PRIMARY KEY AUTO_INCREMENT,
    vehicle_id INT NOT NULL,
    entry_time DATETIME NOT NULL,
    exit_time DATETIME DEFAULT NULL,
    assigned_floor_id INT NOT NULL,
    status ENUM('active', 'completed') NOT NULL DEFAULT 'active',
    FOREIGN KEY (vehicle_id) REFERENCES vehicle(id),
    FOREIGN KEY (assigned_floor_id) REFERENCES floor(id)
);

CREATE TABLE sensor_log (
    id INT PRIMARY KEY AUTO_INCREMENT,
    sensor_type ENUM('entry', 'exit') NOT NULL,
    vehicle_id INT NOT NULL,
    timestamp DATETIME NOT NULL,
    floor_id INT NOT NULL,
    FOREIGN KEY (vehicle_id) REFERENCES vehicle(id),
    FOREIGN KEY (floor_id) REFERENCES floor(id)
);




```


```sql
SELECT s1.id AS start_slot_id
FROM slot s1
JOIN slot s2 ON s2.floor_id = s1.floor_id
    AND s2.slot_number = s1.slot_number + 1
WHERE s1.floor_id = 1
    AND s1.parking_session_id IS NULL
    AND s2.parking_session_id IS NULL
ORDER BY s1.slot_number
LIMIT 1;

SELECT v.license_plate, vt.name AS vehicle_type, f.floor_number
FROM parking_session ps
JOIN vehicle v ON ps.vehicle_id = v.id
JOIN vehicle_type vt ON v.vehicle_type_id = vt.id
JOIN floor f ON ps.assigned_floor_id = f.id
WHERE ps.status = 'active';

```

```sql

```
