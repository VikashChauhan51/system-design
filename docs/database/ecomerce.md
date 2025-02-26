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

Table UserThirdPartyAuth  {
  Id varchar [primary key]
  UserId varchar
  Provider varchar // 'google', 'facebook', etc
  ProviderUserId varchar
  AccessToken varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table UserSessions {
  Id varchar [primary key]
  UserId varchar
  SessionToken varchar
  ExpiresAt timestamp
  DeviceInfo varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table PaymentMethods {
  Id varchar [primary key]
  Name varchar // 'Credit Card', 'UPI', 'Net Banking', etc
  Description varchar
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table ShippingMethods {
  Id varchar [primary key]
  Name varchar
  Description varchar
  Cost decimal
  EstimatedDays integer
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Taxes {
  Id varchar [primary key]
  Country varchar
  State varchar
  TaxRate decimal
  TaxType varchar // 'GST', 'VAT', etc
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table PromotionRedemptions {
  Id varchar [primary key]
  PromotionId varchar
  UserId varchar
  OrderId varchar
  RedeemedAt timestamp
}

Table Returns {
  Id varchar [primary key]
  OrderId varchar
  UserId varchar
  Reason varchar
  Status varchar // 'requested', 'approved', etc
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Notifications {
  Id varchar [primary key]
  UserId varchar
  Type varchar // 'order', 'promotion', etc
  Content varchar
  IsRead boolean
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Users {
  Id varchar [primary key]
  UserName varchar [unique]
  FullName varchar
  Email varchar [unique]
  PasswordHash varchar // nullable for 3rd party auth
  Phone varchar [unique]
  IsEmailVerified boolean
  IsPhoneVerified boolean
  LastLogin timestamp
  DateOfBirth date
  ProfileImageUrl varchar
  GenderId varchar
  CreatedAt timestamp
  UpdatedAt timestamp
  DeletedAt timestamp // soft delete
}

Table Products {
  Id varchar [primary key]
  Name varchar
  Slug varchar [unique] // SEO-friendly URL
  Description varchar
  Code varchar
  CategoryId varchar
  BrandId varchar
  IsActive boolean
  IsDigital boolean // for digital products
  AvgRating decimal
  TotalSales integer
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Variants {
  Id varchar [primary key]
  ProductId varchar
  Sku varchar [unique]
  Barcode varchar [unique]
  Quantity integer
  Price decimal
  SalePrice decimal
  Weight decimal
  Dimensions varchar // '10x5x3'
  IsActive boolean
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Orders {
  Id varchar [primary key]
  UserId varchar
  OrderNumber varchar [unique]
  StatusId varchar
  Subtotal decimal
  TaxTotal decimal
  ShippingCost decimal
  Total decimal
  PaymentMethodId varchar
  ShippingMethodId varchar
  TrackingNumber varchar
  EstimatedDeliveryDate timestamp
  ActualDeliveryDate timestamp
  OrderDate timestamp
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Addresses {
  Id varchar [primary key]
  UserId varchar
  ContactName varchar
  Line1 varchar
  Line2 varchar
  Country varchar
  State varchar
  City varchar
  PinCode varchar
  Landmark varchar
  Phone varchar
  IsDefault boolean
  AddressType varchar // 'shipping', 'billing'
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Promotions {
  Id varchar [primary key]
  Code varchar [unique]
  Description varchar
  DiscountType varchar // 'percentage', 'fixed'
  DiscountValue decimal
  MaxDiscountAmount decimal
  MinOrderAmount decimal
  StartDate timestamp
  EndDate timestamp
  MaxUses integer
  UserMaxUses integer
  ApplicableTo varchar // 'all', 'category', 'product'
  ApplicableIds varchar[] // array of product/category IDs
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Categories {
  Id varchar [primary key]
  Name varchar
  Slug varchar [unique]
  ParentCategoryId varchar
  Description varchar
  ImageUrl varchar
  DisplayOrder integer
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table CartItems {
  Id varchar [primary key]
  CartId varchar
  VariantId varchar
  Quantity integer
  Price decimal
  PriceEffective decimal // price after discounts
  AppliedPromotions varchar[] // array of promotion IDs
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Payments {
  Id varchar [primary key]
  OrderId varchar
  PaymentMethodId varchar
  TransactionId varchar
  GatewayResponse json // raw payment gateway response
  Status varchar
  Amount decimal
  CurrencyCode varchar
  CaptureDate timestamp
  RefundAmount decimal
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table Reviews {
  Id varchar [primary key]
  UserId varchar
  ProductId varchar // review can be at product level
  VariantId varchar // or specific variant
  Rating integer
  Title varchar
  Comment varchar
  IsVerifiedPurchase boolean
  Upvotes integer
  Downvotes integer
  CreatedAt timestamp
  UpdatedAt timestamp
}

Table AuditLog {
  Id varchar [primary key]
  Action varchar(6) // 'CREATE', 'UPDATE', 'DELETE'
  TableName varchar
  RecordId varchar
  ActorUserId varchar // who performed the action
  UserSessionId varchar // from UserSessions table
  OldData jsonb // previous state
  NewData jsonb // new state
  ClientIp varchar
  UserAgent varchar
  CreatedAt timestamp
}

Table UsersHistory {
  Id varchar [primary key]
  ValidFrom timestamp
  ValidTo timestamp
  UserId varchar // reference to original user
  UserName varchar
  FullName varchar
  Email varchar
  // ... all other fields from Users table
  UpdatedBy varchar // who made the change
  RevisionReason varchar // optional change reason
}

Table ProductsHistory {
  Id varchar [primary key]
  ValidFrom timestamp
  ValidTo timestamp
  ProductId varchar // reference to original product
  Name varchar
  Description varchar
  // ... all other fields from Products table
  UpdatedBy varchar
  RevisionReason varchar
}

Table PriceHistory {
  Id varchar [primary key]
  VariantId varchar
  OldPrice decimal
  NewPrice decimal
  ChangeReason varchar // 'promotion', 'market', etc
  EffectiveFrom timestamp
  EffectiveTo timestamp
  UpdatedBy varchar
  CreatedAt timestamp
}

Table InventoryHistory {
  Id varchar [primary key]
  VariantId varchar
  OldQuantity integer
  NewQuantity integer
  AdjustmentType varchar // 'restock', 'sale', 'return'
  ReferenceId varchar // order_id/return_id/etc
  UpdatedBy varchar
  CreatedAt timestamp
}

Table OrderStatusHistory {
  Id varchar [primary key]
  OrderId varchar
  OldStatus varchar
  NewStatus varchar
  ChangedBy varchar // user_id or 'system'
  ChangeReason varchar
  CreatedAt timestamp
}

Table PromotionHistory {
  Id varchar [primary key]
  PromotionId varchar
  FieldName varchar // which field changed
  OldValue varchar
  NewValue varchar
  UpdatedBy varchar
  CreatedAt timestamp
}

```
