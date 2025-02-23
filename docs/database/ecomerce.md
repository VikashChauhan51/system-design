

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
  Description varchar
 CreatedAt timestamp
  UpdatedAt timestamp
}

Table SubCategories {
  Id varchar [primary key]
  Name varchar
  Description varchar
  CategoryId varchar
    CreatedAt timestamp
  UpdatedAt timestamp
}


Table Products {
  Id varchar [primary key]
  Name varchar
  Description varchar
  Code varchar
  SubCategoryId varchar
  BrandId varchar
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
  SupplierId varchar
    CreatedAt timestamp
  UpdatedAt timestamp
}

Table VariantOptions {
  Id varchar [primary key]
  VariantId varchar
  Name varchar
  Value varchar
    CreatedAt timestamp
  UpdatedAt timestamp
}


Table VariantMedias {
  Id varchar [primary key]
  VariantId varchar
  MediaId varchar
  Name varchar
  Alt varchar
  Description varchar
   CreatedAt timestamp
  UpdatedAt timestamp

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

Table Wishlist  {
  Id varchar [primary key]
  UserId varchar
  VariantId varchar
   CreatedAt timestamp
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
  OrderNumber varchar
  Status varchar
  Total decimal
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

Table Medias  {
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

Table ReviewMedias   {
  Id varchar [primary key]
  ReviewId varchar
  MediaId varchar
  AttachmentId varchar
   CreatedAt timestamp
  UpdatedAt timestamp
}
```
