# Ice Cream Sales Report - Dot Net Developer Assessment

## Project Overview
This project is a .NET Core Console Application developed to analyze ice cream parlor sales data.

The application reads raw sales data and generates multiple reports using basic data structures such as Lists and Dictionaries.

## Features Implemented

### 1. Total Sales
Calculates the overall sales amount of the store.

### 2. Month-wise Sales Totals
Generates sales totals grouped by month.

### 3. Most Popular Item Per Month
Finds the item with highest quantity sold for each month.

Also calculates:
- Minimum orders
- Maximum orders
- Average orders

### 4. Highest Revenue Generating Item
Identifies item contributing maximum revenue for each month.

### 5. Month-to-Month Growth
Calculates growth percentage for each item month over month.

Formula:
Growth % = ((Current Month - Previous Month) / Previous Month) * 100

### 6. Data Validation
Detects invalid records where:
- UnitPrice * Quantity != TotalPrice
- Quantity < 1
- UnitPrice < 0
- TotalPrice < 0
- Invalid Date format

## Tech Stack
- C#
- .NET Core Console Application

## Restrictions Followed
- No SQL/NoSQL used
- No LINQ used
- No Pandas or external libraries
- Used only Lists, Dictionaries, loops, conditions

## Folder Structure
IceCreamSalesReport/
│
├── Program.cs
├── Models/
│   └── SaleRecord.cs
├── Services/
│   └── ReportService.cs
└── README.md

## How to Run
1. Open project in Visual Studio
2. Build solution
3. Run application

## Author
Madhu Smita Mishra
