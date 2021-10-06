# Employee Monthly Payslip

Employee Monthly Payslip is a console application that given employee annual salary details outputs a monthly pay slip.

Attributes of he employee are:
- name
- annual salary

Attributes of the monthly payslip are:

- name
- gross monthly income  = annual salary / 12(months)
- monthly income tax    = (annual tax rate provided below)/ 12 (months)
- net monthly income    = gross monthly income -income tax

The following annual tax rates apply:
 
Taxable income              Tax on this income

$0 - $20,000                 $0
$20,001 - $40,000            10c for each $1 over $20,000
$40,001 - $80,000            20c for each $1 over $80,000
$80,001 - 180,000            30c for each $1 over $180,000
$180,000 and over            40c for each $1 over $180,000

For example, for an employee with an annual salary of 60,000.

- gross monthly income = 60,000 / 12
  = 5000

- monthly income tax
  = ((20,000*0) + (40,000-20,000)* 0.1 + (60,000 - 40,000)* 0.2 ) / 12
  = ( 0 + 2000 + 4000 ) / 12
  = 500

- net monthly income
  = 5,000 - 500
  = 4,500

Here is the example console input

GenerateMonthlyPayslip "Mary Song" 6000

And example output:

Monthly Payslip for: "Mary Song"
Gross Monthly income: $5000
Monthly Income Tax: $500
Net Monthly Income: $4500

This application is developed in c#.net using Visual Studio 2019.

## Requirements

The Project Requires .net 4.5 or higher.

## Compatible IDEs

Tested on:

- Visual Studio 2017
- Visual Studio 2019

## Useful Commands

## Build the project

- Unzip the archive in you C drive.
- On Developer's Command Prompt go to EmployeeMonthlyPayslip solutions folder
- Run the command - msbuild

## Run the project

- On the Developer's Command Prompt Change path to EmployeeMonthlyPayslip/bin/release
- Run the command - EmployeeMonthyPayslip.exe  GenerateMonthlyPayslip "EmployeeName" AnnualSalary
- For more information see usage below.

## Run the tests

- On the Developer's Command Prompt Change path to EmployeeMonthlyPayslip.Tests/bin/release
- Run the command - VSTest.Console.exe EmployeeMonthlyPaySlip.Tests.dll

## Usage


    EmployeeMonthyPayslip.exe  GenerateMonthlyPayslip "EmployeeName" AnnualSalary

For example - EmployeeMonthyPayslip.exe GenerateMonthlyPayslip "Test" 60000

Where 
    EmployeeName      : Please provide Employee Name
    AnnualSalary      : Please provide Employee's Annual Salary

Example Output: 

Monthly Payslip for: "Test"
Gross Monthly Income: $5000
Monthly Income Tax: $500
Net Monthly Income: $4500

## Development Insights

## Design Features, Assumptions and Trade-offs 

- This application has been divided in n-tier architecture in order to address the seperation of concerns design principle and to achieve clean, understandable and maintainable code base.
- The application's Presentation layer is responsible for Getting the user input, Validating the input and Printing the output on the Console.
- The application's Business layer is responsible for the Domain logic.
- The solution uses looose coupling and utilizes OOPs principles of encapsulation and inheritance using interfaces. This makes code easily extendable.
- ISalaryComponentsCalculator interface is responsible for doing all the expected salary calculations when implemented.
- The core functionality has been covered using unit tests.
- The source code is well-tested and covered all aspects of varied inputs and does have Exception handling in place to cater for different scenarios.


## Author

- Nidhi Solanki
