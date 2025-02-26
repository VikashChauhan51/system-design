

```pgsql

Table Genders {
  Id varchar [primary key]
  Name varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Brands {
  Id varchar [primary key]
  Name varchar
  Description varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}


Table Categories {
  Id varchar [primary key]
  Name varchar
  ParentCategoryId varchar
  Description varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}


Table Products {
  Id varchar [primary key]
  Name varchar
  Description varchar
  Code varchar
  CategoryId varchar
  BrandId varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Options {
  Id varchar [primary key]
  ProductId varchar
  Name varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Variants {
  Id varchar [primary key]
  ProductId varchar
  Description varchar
  Quantity integer
  Price decimal
  SalePrice decimal
  Sku varchar
  Barcode varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table VariantOptions {
  Id varchar [primary key]
  VariantId varchar
  OptionId varchar
  Value varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}


Table VariantMedia {
  Id varchar [primary key]
  VariantId varchar
  MediaTypeId varchar
  Name varchar
  Alt varchar
  Description varchar
  CreatedAt timestamp
  UpdatedAt timestamp

}

Table VariantSuppliers{
  VariantId varchar [primary key]
  SupplierId varchar [primary key]
}

Table Suppliers {
  Id varchar [primary key]
  Code varchar
  Name varchar
  Description varchar
  Email varchar
  Website varchar
  Phone varchar
  AlterPhone varchar
  BillingAddressLine1 varchar
  BillingAddressLine2 varchar
  BillingCountry varchar
  BillingState varchar
  BillingCity varchar
  BillingPinCode varchar
  BillingLandMark varchar
  ShippingAddressLine1 varchar
  ShippingAddressLine2 varchar
  ShippingCountry varchar
  ShippingState varchar
  ShippingCity varchar
  ShippingPinCode varchar
  ShippingLandMark varchar
  CreatedAt timestamp
  UpdatedAt timestamp

}

Table Users {
  Id varchar [primary key]
  UserName varchar
  FullName varchar
  Email varchar
  PasswordHash varchar
  GenderId varchar
  AlterEmail varchar
  Phone varchar
  AlterPhone varchar
  CreatedAt timestamp
  UpdatedAt timestamp

}

Table Addresses {
  Id varchar [primary key]
  UserId varchar
  Line1 varchar
  Line2 varchar
  Country varchar
  State varchar
  City varchar
  PinCode varchar
  Landmark varchar
  Email varchar
  Phone varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Wishlists  {
  Id varchar [primary key]
  UserId varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table WishlistItems  {
  Id varchar [primary key]
  WishlistId varchar
  VariantId varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Cart  {
  Id varchar [primary key]
  UserId varchar
  Total decimal
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table CartItems  {
  Id varchar [primary key]
  CartId varchar
  VariantId varchar
  Quantity integer
  Price decimal
   CreatedAt timestamp
  UpdatedAt timestamp
}

Table Orders  {
  Id varchar [primary key]
  UserId varchar
  UserName varchar
  OrderNumber varchar
  Status varchar
  Total decimal
  PaymentMode varchar
  ShippingAddressLine1 varchar
  ShippingAddressLine2 varchar
  ShippingCountry varchar
  ShippingState varchar
  ShippingCity varchar
  ShippingPinCode varchar
  ShippingLandMark varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Status  {
  Id varchar [primary key]
  Name varchar
}

Table MediaType  {
  Id varchar [primary key]
  Name varchar
}


Table OrderItems  {
  Id varchar [primary key]
  OrderId varchar
  VariantId varchar
  LineNumber varchar
  Quantity integer
  Price decimal
  Status varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Reviews  {
  Id varchar [primary key]
  UserId varchar
  VariantId varchar
  Rating decimal
  Comment varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table ReviewMedia   {
  Id varchar [primary key]
  ReviewId varchar
  MediaTypeId varchar
  AttachmentId varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Inventory   {
  Id varchar [primary key]
  VariantId varchar
  Quantity integer
  Price decimal
  SalePrice decimal
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Promotions   {
  Id varchar [primary key]
  COde varchar,
  Description varchar
  ProductId varchar
  DiscountPercentage decimal
  DefaultDiscount decimal
  StartDate timestamp
  EndDate timestamp
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Payments   {
  Id varchar [primary key]
  OrderId varchar,
  TransactionId varchar
  PaymentMethod varchar
  Status varchar
  Date timestamp
  Amount decimal
  CurrencyCode varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

```
