
```sql
CREATE TABLE [User] (
    user_id INT PRIMARY KEY IDENTITY,
    email NVARCHAR(255) UNIQUE NOT NULL,
    password_hash NVARCHAR(255) NOT NULL,
    full_name NVARCHAR(255),
    created_at DATETIME DEFAULT GETDATE()
);

CREATE TABLE [Plan] (
    plan_id INT PRIMARY KEY IDENTITY,
    name NVARCHAR(100) NOT NULL,
    max_warehouses INT NOT NULL,
    max_users INT NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    features NVARCHAR(MAX)
);

CREATE TABLE Company (
    company_id INT PRIMARY KEY IDENTITY,
    name NVARCHAR(255) NOT NULL,
    plan_id INT NOT NULL,
    owner_user_id INT NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (plan_id) REFERENCES [Plan](plan_id),
    FOREIGN KEY (owner_user_id) REFERENCES [User](user_id)
);

-- User-Company Relationships & Permissions
CREATE TABLE [Role] (
    role_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    name NVARCHAR(100) NOT NULL,
    is_default BIT DEFAULT 0,
    FOREIGN KEY (company_id) REFERENCES Company(company_id)
);

CREATE TABLE Permission (
    permission_id INT PRIMARY KEY IDENTITY,
    name NVARCHAR(100) UNIQUE NOT NULL,
    description NVARCHAR(255)
);

CREATE TABLE RolePermission (
    role_id INT NOT NULL,
    permission_id INT NOT NULL,
    PRIMARY KEY (role_id, permission_id),
    FOREIGN KEY (role_id) REFERENCES [Role](role_id),
    FOREIGN KEY (permission_id) REFERENCES Permission(permission_id)
);

CREATE TABLE UserCompany (
    user_id INT NOT NULL,
    company_id INT NOT NULL,
    role_id INT NOT NULL,
    invited_at DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (user_id, company_id),
    FOREIGN KEY (user_id) REFERENCES [User](user_id),
    FOREIGN KEY (company_id) REFERENCES Company(company_id),
    FOREIGN KEY (role_id) REFERENCES [Role](role_id)
);

-- Warehouse Structure
CREATE TABLE Warehouse (
    warehouse_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    name NVARCHAR(255) NOT NULL,
    location NVARCHAR(255),
    layout_data NVARCHAR(MAX),
    FOREIGN KEY (company_id) REFERENCES Company(company_id)
);

CREATE TABLE Rack (
    rack_id INT PRIMARY KEY IDENTITY,
    warehouse_id INT NOT NULL,
    name NVARCHAR(255) NOT NULL,
    [row] INT,
    [column] INT,
    FOREIGN KEY (warehouse_id) REFERENCES Warehouse(warehouse_id)
);

CREATE TABLE Shelf (
    shelf_id INT PRIMARY KEY IDENTITY,
    rack_id INT NOT NULL,
    name NVARCHAR(255) NOT NULL,
    level INT,
    FOREIGN KEY (rack_id) REFERENCES Rack(rack_id)
);

CREATE TABLE Pocket (
    pocket_id INT PRIMARY KEY IDENTITY,
    shelf_id INT NOT NULL,
    name NVARCHAR(255) NOT NULL,
    position INT,
    capacity INT,
    FOREIGN KEY (shelf_id) REFERENCES Shelf(shelf_id)
);

-- Product Catalog
CREATE TABLE Product (
    product_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    name NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX),
    sku_prefix NVARCHAR(50) NOT NULL,
    FOREIGN KEY (company_id) REFERENCES Company(company_id)
);

CREATE TABLE ItemVariant (
    variant_id INT PRIMARY KEY IDENTITY,
    product_id INT NOT NULL,
    name NVARCHAR(255) NOT NULL,
    attributes NVARCHAR(MAX),
    sku_suffix NVARCHAR(50) NOT NULL,
    FOREIGN KEY (product_id) REFERENCES Product(product_id)
);

-- Inventory Management
CREATE TABLE Item (
    item_id INT PRIMARY KEY IDENTITY,
    variant_id INT NOT NULL,
    company_id INT NOT NULL,
    pocket_id INT,
    container_item_id INT,
    barcode NVARCHAR(255) UNIQUE,
    status NVARCHAR(50) DEFAULT 'IN_STOCK',
    added_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (variant_id) REFERENCES ItemVariant(variant_id),
    FOREIGN KEY (company_id) REFERENCES Company(company_id),
    FOREIGN KEY (pocket_id) REFERENCES Pocket(pocket_id),
    FOREIGN KEY (container_item_id) REFERENCES Item(item_id)
);

CREATE TABLE InventoryTransaction (
    transaction_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    item_id INT NOT NULL,
    transaction_type NVARCHAR(50) NOT NULL,
    quantity INT NOT NULL,
    from_pocket_id INT,
    to_pocket_id INT,
    transaction_date DATETIME DEFAULT GETDATE(),
    user_id INT NOT NULL,
    notes NVARCHAR(MAX),
    FOREIGN KEY (company_id) REFERENCES Company(company_id),
    FOREIGN KEY (item_id) REFERENCES Item(item_id),
    FOREIGN KEY (from_pocket_id) REFERENCES Pocket(pocket_id),
    FOREIGN KEY (to_pocket_id) REFERENCES Pocket(pocket_id),
    FOREIGN KEY (user_id) REFERENCES [User](user_id)
);

-- Sales & Purchasing
CREATE TABLE Customer (
    customer_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    name NVARCHAR(255) NOT NULL,
    contact_info NVARCHAR(MAX),
    FOREIGN KEY (company_id) REFERENCES Company(company_id)
);

CREATE TABLE [Order] (
    order_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    customer_id INT NOT NULL,
    order_date DATETIME DEFAULT GETDATE(),
    status NVARCHAR(50) DEFAULT 'PENDING',
    total DECIMAL(18,2),
    FOREIGN KEY (company_id) REFERENCES Company(company_id),
    FOREIGN KEY (customer_id) REFERENCES Customer(customer_id)
);

CREATE TABLE OrderLine (
    order_line_id INT PRIMARY KEY IDENTITY,
    order_id INT NOT NULL,
    item_id INT NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES [Order](order_id),
    FOREIGN KEY (item_id) REFERENCES Item(item_id)
);

CREATE TABLE Supplier (
    supplier_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    name NVARCHAR(255) NOT NULL,
    contact_info NVARCHAR(MAX),
    FOREIGN KEY (company_id) REFERENCES Company(company_id)
);

CREATE TABLE PurchaseOrder (
    po_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    supplier_id INT NOT NULL,
    order_date DATETIME DEFAULT GETDATE(),
    status NVARCHAR(50) DEFAULT 'PENDING',
    total DECIMAL(18,2),
    FOREIGN KEY (company_id) REFERENCES Company(company_id),
    FOREIGN KEY (supplier_id) REFERENCES Supplier(supplier_id)
);

CREATE TABLE PurchaseOrderLine (
    po_line_id INT PRIMARY KEY IDENTITY,
    po_id INT NOT NULL,
    item_id INT NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (po_id) REFERENCES PurchaseOrder(po_id),
    FOREIGN KEY (item_id) REFERENCES Item(item_id)
);

-- Transfer Management
CREATE TABLE TransferOrder (
    transfer_id INT PRIMARY KEY IDENTITY,
    company_id INT NOT NULL,
    from_warehouse_id INT NOT NULL,
    to_warehouse_id INT NOT NULL,
    transfer_date DATETIME DEFAULT GETDATE(),
    status NVARCHAR(50) DEFAULT 'PENDING',
    FOREIGN KEY (company_id) REFERENCES Company(company_id),
    FOREIGN KEY (from_warehouse_id) REFERENCES Warehouse(warehouse_id),
    FOREIGN KEY (to_warehouse_id) REFERENCES Warehouse(warehouse_id)
);

CREATE TABLE TransferOrderLine (
    transfer_line_id INT PRIMARY KEY IDENTITY,
    transfer_id INT NOT NULL,
    item_id INT NOT NULL,
    quantity INT NOT NULL,
    from_pocket_id INT NOT NULL,
    to_pocket_id INT NOT NULL,
    FOREIGN KEY (transfer_id) REFERENCES TransferOrder(transfer_id),
    FOREIGN KEY (item_id) REFERENCES Item(item_id),
    FOREIGN KEY (from_pocket_id) REFERENCES Pocket(pocket_id),
    FOREIGN KEY (to_pocket_id) REFERENCES Pocket(pocket_id)
);
``
