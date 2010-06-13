﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by BLToolkit template for T4.
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Runtime.Serialization;

using BLToolkit.Common;
using BLToolkit.Data;
using BLToolkit.Data.Linq;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace Templates
{
	public partial class DataModel : DbManager
	{
		public Table<AlphabeticalListOfProducts> AlphabeticalListOfProducts { get { return GetTable<AlphabeticalListOfProducts>(); } }
		public Table<Categories>                 Categories                 { get { return GetTable<Categories>();                 } }
		public Table<CategorySalesFor1997>       CategorySalesFor1997       { get { return GetTable<CategorySalesFor1997>();       } }
		public Table<CurrentProductList>         CurrentProductList         { get { return GetTable<CurrentProductList>();         } }
		public Table<CustomerAndSuppliersByCity> CustomerAndSuppliersByCity { get { return GetTable<CustomerAndSuppliersByCity>(); } }
		public Table<CustomerCustomerDemo>       CustomerCustomerDemo       { get { return GetTable<CustomerCustomerDemo>();       } }
		public Table<CustomerDemographics>       CustomerDemographics       { get { return GetTable<CustomerDemographics>();       } }
		public Table<Customers>                  Customers                  { get { return GetTable<Customers>();                  } }
		public Table<Employees>                  Employees                  { get { return GetTable<Employees>();                  } }
		public Table<EmployeeTerritories>        EmployeeTerritories        { get { return GetTable<EmployeeTerritories>();        } }
		public Table<Invoices>                   Invoices                   { get { return GetTable<Invoices>();                   } }
		public Table<OrderDetails>               OrderDetails               { get { return GetTable<OrderDetails>();               } }
		public Table<OrderDetailsExtended>       OrderDetailsExtended       { get { return GetTable<OrderDetailsExtended>();       } }
		public Table<OrderSubtotals>             OrderSubtotals             { get { return GetTable<OrderSubtotals>();             } }
		public Table<Orders>                     Orders                     { get { return GetTable<Orders>();                     } }
		public Table<OrdersQry>                  OrdersQry                  { get { return GetTable<OrdersQry>();                  } }
		public Table<ProductSalesFor1997>        ProductSalesFor1997        { get { return GetTable<ProductSalesFor1997>();        } }
		public Table<Products>                   Products                   { get { return GetTable<Products>();                   } }
		public Table<ProductsAboveAveragePrice>  ProductsAboveAveragePrice  { get { return GetTable<ProductsAboveAveragePrice>();  } }
		public Table<ProductsByCategory>         ProductsByCategory         { get { return GetTable<ProductsByCategory>();         } }
		public Table<QuarterlyOrders>            QuarterlyOrders            { get { return GetTable<QuarterlyOrders>();            } }
		public Table<Region>                     Region                     { get { return GetTable<Region>();                     } }
		public Table<SalesByCategory>            SalesByCategory            { get { return GetTable<SalesByCategory>();            } }
		public Table<SalesTotalsByAmount>        SalesTotalsByAmount        { get { return GetTable<SalesTotalsByAmount>();        } }
		public Table<Shippers>                   Shippers                   { get { return GetTable<Shippers>();                   } }
		public Table<SummaryOfSalesByQuarter>    SummaryOfSalesByQuarter    { get { return GetTable<SummaryOfSalesByQuarter>();    } }
		public Table<SummaryOfSalesByYear>       SummaryOfSalesByYear       { get { return GetTable<SummaryOfSalesByYear>();       } }
		public Table<Suppliers>                  Suppliers                  { get { return GetTable<Suppliers>();                  } }
		public Table<sysdiagrams>                sysdiagrams                { get { return GetTable<sysdiagrams>();                } }
		public Table<Territories>                Territories                { get { return GetTable<Territories>();                } }
	}

	[Serializable, DataContract]
	[TableName(Name="Alphabetical list of products")]
	public partial class AlphabeticalListOfProducts : EntityBase<AlphabeticalListOfProducts>
	{
		[          DataMember] public int      ProductID       { get; set; }
		[          DataMember] public string   ProductName     { get; set; }
		[Nullable, DataMember] public int?     SupplierID      { get; set; }
		[Nullable, DataMember] public int?     CategoryID      { get; set; }
		[Nullable, DataMember] public string   QuantityPerUnit { get; set; }
		[Nullable, DataMember] public decimal? UnitPrice       { get; set; }
		[Nullable, DataMember] public short?   UnitsInStock    { get; set; }
		[Nullable, DataMember] public short?   UnitsOnOrder    { get; set; }
		[Nullable, DataMember] public short?   ReorderLevel    { get; set; }
		[          DataMember] public bool     Discontinued    { get; set; }
		[          DataMember] public string   CategoryName    { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Categories")]
	public partial class Categories : EntityBase<Categories>
	{
		[Identity, PrimaryKey(1), DataMember] public int    CategoryID   { get; set; }
		[                         DataMember] public string CategoryName { get; set; }
		[Nullable,                DataMember] public string Description  { get; set; }
		[Nullable,                DataMember] public byte[] Picture      { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Category Sales for 1997")]
	public partial class CategorySalesFor1997 : EntityBase<CategorySalesFor1997>
	{
		[          DataMember] public string   CategoryName  { get; set; }
		[Nullable, DataMember] public decimal? CategorySales { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Current Product List")]
	public partial class CurrentProductList : EntityBase<CurrentProductList>
	{
		[Identity, DataMember] public int    ProductID   { get; set; }
		[          DataMember] public string ProductName { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Customer and Suppliers by City")]
	public partial class CustomerAndSuppliersByCity : EntityBase<CustomerAndSuppliersByCity>
	{
		[Nullable, DataMember] public string City         { get; set; }
		[          DataMember] public string CompanyName  { get; set; }
		[Nullable, DataMember] public string ContactName  { get; set; }
		[          DataMember] public string Relationship { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="CustomerCustomerDemo")]
	public partial class CustomerCustomerDemo : EntityBase<CustomerCustomerDemo>
	{
		[PrimaryKey(1), DataMember] public string CustomerID     { get; set; }
		[PrimaryKey(2), DataMember] public string CustomerTypeID { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="CustomerDemographics")]
	public partial class CustomerDemographics : EntityBase<CustomerDemographics>
	{
		[          PrimaryKey(1), DataMember] public string CustomerTypeID { get; set; }
		[Nullable,                DataMember] public string CustomerDesc   { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Customers")]
	public partial class Customers : EntityBase<Customers>
	{
		[          PrimaryKey(1), DataMember] public string CustomerID   { get; set; }
		[                         DataMember] public string CompanyName  { get; set; }
		[Nullable,                DataMember] public string ContactName  { get; set; }
		[Nullable,                DataMember] public string ContactTitle { get; set; }
		[Nullable,                DataMember] public string Address      { get; set; }
		[Nullable,                DataMember] public string City         { get; set; }
		[Nullable,                DataMember] public string Region       { get; set; }
		[Nullable,                DataMember] public string PostalCode   { get; set; }
		[Nullable,                DataMember] public string Country      { get; set; }
		[Nullable,                DataMember] public string Phone        { get; set; }
		[Nullable,                DataMember] public string Fax          { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Employees")]
	public partial class Employees : EntityBase<Employees>
	{
		[Identity, PrimaryKey(1), DataMember] public int       EmployeeID      { get; set; }
		[                         DataMember] public string    LastName        { get; set; }
		[                         DataMember] public string    FirstName       { get; set; }
		[Nullable,                DataMember] public string    Title           { get; set; }
		[Nullable,                DataMember] public string    TitleOfCourtesy { get; set; }
		[Nullable,                DataMember] public DateTime? BirthDate       { get; set; }
		[Nullable,                DataMember] public DateTime? HireDate        { get; set; }
		[Nullable,                DataMember] public string    Address         { get; set; }
		[Nullable,                DataMember] public string    City            { get; set; }
		[Nullable,                DataMember] public string    Region          { get; set; }
		[Nullable,                DataMember] public string    PostalCode      { get; set; }
		[Nullable,                DataMember] public string    Country         { get; set; }
		[Nullable,                DataMember] public string    HomePhone       { get; set; }
		[Nullable,                DataMember] public string    Extension       { get; set; }
		[Nullable,                DataMember] public byte[]    Photo           { get; set; }
		[Nullable,                DataMember] public string    Notes           { get; set; }
		[Nullable,                DataMember] public int?      ReportsTo       { get; set; }
		[Nullable,                DataMember] public string    PhotoPath       { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="EmployeeTerritories")]
	public partial class EmployeeTerritories : EntityBase<EmployeeTerritories>
	{
		[PrimaryKey(1), DataMember] public int    EmployeeID  { get; set; }
		[PrimaryKey(2), DataMember] public string TerritoryID { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Invoices")]
	public partial class Invoices : EntityBase<Invoices>
	{
		[Nullable, DataMember] public string    ShipName       { get; set; }
		[Nullable, DataMember] public string    ShipAddress    { get; set; }
		[Nullable, DataMember] public string    ShipCity       { get; set; }
		[Nullable, DataMember] public string    ShipRegion     { get; set; }
		[Nullable, DataMember] public string    ShipPostalCode { get; set; }
		[Nullable, DataMember] public string    ShipCountry    { get; set; }
		[Nullable, DataMember] public string    CustomerID     { get; set; }
		[          DataMember] public string    CustomerName   { get; set; }
		[Nullable, DataMember] public string    Address        { get; set; }
		[Nullable, DataMember] public string    City           { get; set; }
		[Nullable, DataMember] public string    Region         { get; set; }
		[Nullable, DataMember] public string    PostalCode     { get; set; }
		[Nullable, DataMember] public string    Country        { get; set; }
		[          DataMember] public string    Salesperson    { get; set; }
		[          DataMember] public int       OrderID        { get; set; }
		[Nullable, DataMember] public DateTime? OrderDate      { get; set; }
		[Nullable, DataMember] public DateTime? RequiredDate   { get; set; }
		[Nullable, DataMember] public DateTime? ShippedDate    { get; set; }
		[          DataMember] public string    ShipperName    { get; set; }
		[          DataMember] public int       ProductID      { get; set; }
		[          DataMember] public string    ProductName    { get; set; }
		[          DataMember] public decimal   UnitPrice      { get; set; }
		[          DataMember] public short     Quantity       { get; set; }
		[          DataMember] public float     Discount       { get; set; }
		[Nullable, DataMember] public decimal?  ExtendedPrice  { get; set; }
		[Nullable, DataMember] public decimal?  Freight        { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Order Details")]
	public partial class OrderDetails : EntityBase<OrderDetails>
	{
		[PrimaryKey(1), DataMember] public int     OrderID   { get; set; }
		[PrimaryKey(2), DataMember] public int     ProductID { get; set; }
		[               DataMember] public decimal UnitPrice { get; set; }
		[               DataMember] public short   Quantity  { get; set; }
		[               DataMember] public float   Discount  { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Order Details Extended")]
	public partial class OrderDetailsExtended : EntityBase<OrderDetailsExtended>
	{
		[          DataMember] public int      OrderID       { get; set; }
		[          DataMember] public int      ProductID     { get; set; }
		[          DataMember] public string   ProductName   { get; set; }
		[          DataMember] public decimal  UnitPrice     { get; set; }
		[          DataMember] public short    Quantity      { get; set; }
		[          DataMember] public float    Discount      { get; set; }
		[Nullable, DataMember] public decimal? ExtendedPrice { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Order Subtotals")]
	public partial class OrderSubtotals : EntityBase<OrderSubtotals>
	{
		[          DataMember] public int      OrderID  { get; set; }
		[Nullable, DataMember] public decimal? Subtotal { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Orders")]
	public partial class Orders : EntityBase<Orders>
	{
		[Identity, PrimaryKey(1), DataMember] public int       OrderID        { get; set; }
		[Nullable,                DataMember] public string    CustomerID     { get; set; }
		[Nullable,                DataMember] public int?      EmployeeID     { get; set; }
		[Nullable,                DataMember] public DateTime? OrderDate      { get; set; }
		[Nullable,                DataMember] public DateTime? RequiredDate   { get; set; }
		[Nullable,                DataMember] public DateTime? ShippedDate    { get; set; }
		[Nullable,                DataMember] public int?      ShipVia        { get; set; }
		[Nullable,                DataMember] public decimal?  Freight        { get; set; }
		[Nullable,                DataMember] public string    ShipName       { get; set; }
		[Nullable,                DataMember] public string    ShipAddress    { get; set; }
		[Nullable,                DataMember] public string    ShipCity       { get; set; }
		[Nullable,                DataMember] public string    ShipRegion     { get; set; }
		[Nullable,                DataMember] public string    ShipPostalCode { get; set; }
		[Nullable,                DataMember] public string    ShipCountry    { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Orders Qry")]
	public partial class OrdersQry : EntityBase<OrdersQry>
	{
		[          DataMember] public int       OrderID        { get; set; }
		[Nullable, DataMember] public string    CustomerID     { get; set; }
		[Nullable, DataMember] public int?      EmployeeID     { get; set; }
		[Nullable, DataMember] public DateTime? OrderDate      { get; set; }
		[Nullable, DataMember] public DateTime? RequiredDate   { get; set; }
		[Nullable, DataMember] public DateTime? ShippedDate    { get; set; }
		[Nullable, DataMember] public int?      ShipVia        { get; set; }
		[Nullable, DataMember] public decimal?  Freight        { get; set; }
		[Nullable, DataMember] public string    ShipName       { get; set; }
		[Nullable, DataMember] public string    ShipAddress    { get; set; }
		[Nullable, DataMember] public string    ShipCity       { get; set; }
		[Nullable, DataMember] public string    ShipRegion     { get; set; }
		[Nullable, DataMember] public string    ShipPostalCode { get; set; }
		[Nullable, DataMember] public string    ShipCountry    { get; set; }
		[          DataMember] public string    CompanyName    { get; set; }
		[Nullable, DataMember] public string    Address        { get; set; }
		[Nullable, DataMember] public string    City           { get; set; }
		[Nullable, DataMember] public string    Region         { get; set; }
		[Nullable, DataMember] public string    PostalCode     { get; set; }
		[Nullable, DataMember] public string    Country        { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Product Sales for 1997")]
	public partial class ProductSalesFor1997 : EntityBase<ProductSalesFor1997>
	{
		[          DataMember] public string   CategoryName { get; set; }
		[          DataMember] public string   ProductName  { get; set; }
		[Nullable, DataMember] public decimal? ProductSales { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Products")]
	public partial class Products : EntityBase<Products>
	{
		[Identity, PrimaryKey(1), DataMember] public int      ProductID       { get; set; }
		[                         DataMember] public string   ProductName     { get; set; }
		[Nullable,                DataMember] public int?     SupplierID      { get; set; }
		[Nullable,                DataMember] public int?     CategoryID      { get; set; }
		[Nullable,                DataMember] public string   QuantityPerUnit { get; set; }
		[Nullable,                DataMember] public decimal? UnitPrice       { get; set; }
		[Nullable,                DataMember] public short?   UnitsInStock    { get; set; }
		[Nullable,                DataMember] public short?   UnitsOnOrder    { get; set; }
		[Nullable,                DataMember] public short?   ReorderLevel    { get; set; }
		[                         DataMember] public bool     Discontinued    { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Products Above Average Price")]
	public partial class ProductsAboveAveragePrice : EntityBase<ProductsAboveAveragePrice>
	{
		[          DataMember] public string   ProductName { get; set; }
		[Nullable, DataMember] public decimal? UnitPrice   { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Products by Category")]
	public partial class ProductsByCategory : EntityBase<ProductsByCategory>
	{
		[          DataMember] public string CategoryName    { get; set; }
		[          DataMember] public string ProductName     { get; set; }
		[Nullable, DataMember] public string QuantityPerUnit { get; set; }
		[Nullable, DataMember] public short? UnitsInStock    { get; set; }
		[          DataMember] public bool   Discontinued    { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Quarterly Orders")]
	public partial class QuarterlyOrders : EntityBase<QuarterlyOrders>
	{
		[Nullable, DataMember] public string CustomerID  { get; set; }
		[Nullable, DataMember] public string CompanyName { get; set; }
		[Nullable, DataMember] public string City        { get; set; }
		[Nullable, DataMember] public string Country     { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Region")]
	public partial class Region : EntityBase<Region>
	{
		[MapField("RegionID"), PrimaryKey(1), DataMember] public int    ID                { get; set; }
		[                                     DataMember] public string RegionDescription { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Sales by Category")]
	public partial class SalesByCategory : EntityBase<SalesByCategory>
	{
		[          DataMember] public int      CategoryID   { get; set; }
		[          DataMember] public string   CategoryName { get; set; }
		[          DataMember] public string   ProductName  { get; set; }
		[Nullable, DataMember] public decimal? ProductSales { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Sales Totals by Amount")]
	public partial class SalesTotalsByAmount : EntityBase<SalesTotalsByAmount>
	{
		[Nullable, DataMember] public decimal?  SaleAmount  { get; set; }
		[          DataMember] public int       OrderID     { get; set; }
		[          DataMember] public string    CompanyName { get; set; }
		[Nullable, DataMember] public DateTime? ShippedDate { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Shippers")]
	public partial class Shippers : EntityBase<Shippers>
	{
		[Identity, PrimaryKey(1), DataMember] public int    ShipperID   { get; set; }
		[                         DataMember] public string CompanyName { get; set; }
		[Nullable,                DataMember] public string Phone       { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Summary of Sales by Quarter")]
	public partial class SummaryOfSalesByQuarter : EntityBase<SummaryOfSalesByQuarter>
	{
		[Nullable, DataMember] public DateTime? ShippedDate { get; set; }
		[          DataMember] public int       OrderID     { get; set; }
		[Nullable, DataMember] public decimal?  Subtotal    { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Summary of Sales by Year")]
	public partial class SummaryOfSalesByYear : EntityBase<SummaryOfSalesByYear>
	{
		[Nullable, DataMember] public DateTime? ShippedDate { get; set; }
		[          DataMember] public int       OrderID     { get; set; }
		[Nullable, DataMember] public decimal?  Subtotal    { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Suppliers")]
	public partial class Suppliers : EntityBase<Suppliers>
	{
		[Identity, PrimaryKey(1), DataMember] public int    SupplierID   { get; set; }
		[                         DataMember] public string CompanyName  { get; set; }
		[Nullable,                DataMember] public string ContactName  { get; set; }
		[Nullable,                DataMember] public string ContactTitle { get; set; }
		[Nullable,                DataMember] public string Address      { get; set; }
		[Nullable,                DataMember] public string City         { get; set; }
		[Nullable,                DataMember] public string Region       { get; set; }
		[Nullable,                DataMember] public string PostalCode   { get; set; }
		[Nullable,                DataMember] public string Country      { get; set; }
		[Nullable,                DataMember] public string Phone        { get; set; }
		[Nullable,                DataMember] public string Fax          { get; set; }
		[Nullable,                DataMember] public string HomePage     { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="sysdiagrams")]
	public partial class sysdiagrams : EntityBase<sysdiagrams>
	{
		[                         DataMember] public string name         { get; set; }
		[                         DataMember] public int    principal_id { get; set; }
		[Identity, PrimaryKey(1), DataMember] public int    diagram_id   { get; set; }
		[Nullable,                DataMember] public int?   version      { get; set; }
		[Nullable,                DataMember] public byte[] definition   { get; set; }
	}

	[Serializable, DataContract]
	[TableName(Name="Territories")]
	public partial class Territories : EntityBase<Territories>
	{
		[PrimaryKey(1), DataMember] public string TerritoryID          { get; set; }
		[               DataMember] public string TerritoryDescription { get; set; }
		[               DataMember] public int    RegionID             { get; set; }
	}
}
