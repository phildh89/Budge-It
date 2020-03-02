# Budge-It

# Concept Description
This application is created to make budgeting easier!
Budgeting can be a difficult and daunting task and many people don't know where to start. From paying off debt to starting a savings account, this application can assist users manage their financial life and have a better understanding on where their hard earned money is being allocated.

# Table of Content
1. [User Stories](https://github.com/phildh89/Budge-It#user-stories)
2. [Use-Case](https://github.com/phildh89/Budge-It#use-case)
3. [UML Diagram](https://github.com/phildh89/Budge-It#uml-diagram)
4. [Scenario](https://github.com/phildh89/Budge-It#scenario)
5. [Entity Relationship Diagram](https://github.com/phildh89/Budge-It#entity-relationship-diagram)
6. [Wire-Frame (Draft)](https://github.com/phildh89/Budge-It#wire-frames-draft)
7. [Requirements](https://github.com/phildh89/Budge-It#requirements)

#### Lets start off with the basics
Users will be able to input or pull data from their checking account(s) and organize their statement usage. This will be the most used feature of the application where the user will be presented stats that will show where their money is being used.

For example - The user will be able to label their transactions Groceries, Bills, Restaurants, etc followed by how much the transact was.  This will create a table and chart displaying the planned and actual allocated amount you want to set for a category each month.
#### More advanced features
After the user inputs their information, the application will be able to assist the user on the best course of action on eliminating their debt. From credit cards to loans, suggests will be given to the user on what account to pay off first to avoid the largest amount of interest. Timelines and calculators will also be included. 

# User Stories
*	As a college student, I want to pay off my debt so that I pay the least amount of interest possible given my current income and lifestyle.<br/>
*	As a parent, I want to allocate money for savings so that I have a retirement fund and college fund for my kids.<br/>
*	As a student, I want to know where my money is being spent so that I can learn how to manage my finances.<br/>


# Use-Case
*	The User enters user information <br/>
*	The User enters Checking account transaction<br/>
*	The User enters Loans/Credit card transaction<br/>
*	The User enters Savings account transaction<br/>
*	The System stores transaction input<br/>
*	The System outputs numeric results of transactions<br/>
*	The System outputs chart representation of transactions<br/>
*	The System outputs calculations on debt interest<br/>

# UML Diagram
![UML](assets/Budge-it%20UML.png)

# Scenario
<p>
  Given when the user account has been created and transactions have been populated, when the user loads the home screen then statistics and charts will show a summary of the user’s financial standings. There will be options to look at savings and debt paying recommendations.
  </p>

# Entity Relationship Diagram

![ERD](assets/Budge-it%20ERD.png)

# Wire-frames (DRAFT)

![Wire-Frame](assets/Budge-it_Framework.PNG)

# Requirements

### `1.0 Account Registration`
The system shall allow users to register for accounts. The registration feature will be located on the home view. The user will enter personal information such as First Name, Last Name, Email, Date of Birth, Username and Password.

### `1.1	Log-In Function`
The system shall allow user will enter username and password to request the database to verify username and password match.

### `1.2	Bank Account Data`
The system shall allow user to log into bank API to pull data and push into system database. This will populate the transaction information needed for summary view page.

##### `1.2.1 User input transactions`
The system shall allow user to edit or input addition transaction information into specified account to increase readability for the user.

### `1.3	Transaction Summary`
The system shall return data from the database based on the users filter to return total usage of accounts. The view will be numeric and visual via charts

### `1.4	Interest Calculator`
The system shall all user to enter desired amount to put into savings accounts or amount to pay off debt from credit cards or loans. The system will return data based on transactions from database and APR/interest based on the account. The view will return payment or savings plans based on user input.

