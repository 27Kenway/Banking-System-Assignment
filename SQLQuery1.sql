--Assignment 3
--TASK 1
create Database HMBank

create table Customers(
customers_id int primary key,
first_name varchar(20),
last_name varchar(20),
DOB Date,
email varchar(20),
phone_number int,
address varchar(50))

create table Accounts(
account_id int primary key,
customer_id int,
account_type varchar(20),
balance decimal(20,2)
foreign key(customer_id) references Customers(customers_id) )

create table Transactions(
transaction_id int primary key,
account_id int,
transaction_type varchar(20),
amount decimal(20,2),
transaction_date date
foreign key (account_id) references Accounts(account_id))

--Task 2
--Ques  1 Insert at least 10 sample record
Insert into Customers(customers_id,first_name,last_name,DOB,email,phone_number,address) values
(1, 'John', 'Doe', '1990-01-15', 'john@email.com', '1234', 'delhi'),
(2, 'Jane', 'Smith', '1985-05-22', 'jane@email.com', '9876', 'bangalore'),
(3, 'Alice', 'Johnson', '1988-03-10', 'alice@email.com', '5551', 'bangalore'),
(4, 'Bob', 'Williams', '1995-07-25', 'bob@email.com', '1122', 'chennai'),
(5, 'Eva', 'Miller', '1980-12-05', 'eva@email.com', '4445', 'mumbai'),
(6, 'Michael', 'Davis', '1975-09-18', 'michael@email.com', '7778', 'chennai'),
(7, 'Sophia', 'Brown', '1992-06-15', 'sophia@email.com', '9998', 'delhi'),
(8, 'Daniel', 'Moore', '1983-04-30', 'daniel@email.com', '1284', 'pune'),
(9, 'Olivia', 'White', '1998-01-22', 'olivia@email.com', '9826', 'chennai'),
(10, 'Charlie', 'Hall', '1972-11-08', 'charlie@email.com', '1112', 'pune')

Insert into Accounts(account_id,customer_id,account_type,balance) values
(101, 1, 'savings', 5000),
(102, 1, 'current', 1500),
(103, 2, 'savings', 7000),
(104, 3, 'savings', 0),
(105, 4, 'current', 2000),
(106, 5, 'savings', 6000),
(107, 6, 'current', 800),
(108, 7, 'savings', 9000),
(109, 8, 'current', 1500),
(110, 9, 'zero_balance', 4500),
(111, 10, 'current', 700)

Insert into Transactions(transaction_id,account_id,transaction_type, amount,transaction_date) values
(1001, 101, 'deposit', 1000, '2024-01-12'),
(1002, 102, 'withdrawal', 500, '2024-01-13'),
(1003, 103, 'transfer', 2000, '2024-01-14'),
(1004, 104, 'deposit', 500, '2024-01-15'),
(1005, 105, 'withdrawal', 300, '2024-01-16'),
(1006, 106, 'transfer', 1000, '2024-01-17'),
(1007, 107, 'deposit', 200, '2024-01-18'),
(1008, 108, 'withdrawal', 1000, '2024-01-19'),
(1009, 109, 'transfer', 700, '2024-01-20'),
(1010, 110, 'deposit', 800, '2024-01-21'),
(1011, 111, 'withdrawal', 400, '2024-01-22')


--Ques 2.1 Write a SQL query to retrieve the name, account type and email of all customers.

Select concat(first_name,' ',last_name) as full_name,account_type,email 
from
Customers
join Accounts on Customers.customers_id = Accounts.customer_id

--Ques 2.2 Write a SQL query to list all transaction corresponding customer.
Select first_name, transaction_id,Transactions.account_id,transaction_type, amount,transaction_date 
from Transactions
join Accounts on Transactions.account_id = Accounts.account_id
join Customers on Accounts.customer_id = Customers.customers_id;

--Ques 2.3 Write a SQL query to increase the balance of a specific account by a certain amount.
update Accounts
set balance = balance + 500
where account_id = 105
select * from Accounts

--Ques 2.4 Write a SQL query to Combine first and last names of customers as a full_name.
Select CONCAT(first_name,' ',last_name) as full_name 
from Customers

--Ques 2.5 Write a SQL query to remove accounts with a balance of zero where the account type is savings.

DELETE FROM Accounts
WHERE balance = 0 AND account_type = 'savings'

--Ques 2.6  Write a SQL query to Find customers living in a specific city. Select  * from Customers 
 where address = 'delhi'

 --Ques 2.7 Write a SQL query to Get the account balance for a specific account
 Select balance from Accounts 
 where account_id = 105

 --Ques 2.8  Write a SQL query to List all current accounts with a balance greater than $1,000.
 Select * from Accounts 
 where account_type = 'current' and balance>1000

 --Ques 2.9 Write a SQL query to Retrieve all transactions for a specific account.
 Select * from Transactions 
 where account_id = 101

 --Ques 2.10 Write a SQL query to Calculate the interest accrued on savings accounts based on a given interest rate.
 -- We have assume interest rate as 10%
 SELECT (balance*0.1) as interest_accrued from Accounts 
 WHERE account_type = 'savings'

 --Ques 2.11 Write a SQL query to Identify accounts where the balance is less than a specified overdraft limit.
 -- Lets take overdraft limit = 2000
 SELECT * FROM Accounts WHERE balance< 2000
 --Ques 2.12 Write a SQL query to Find customers not living in a specific city.
 SELECT * fROM Customers 
 WHERE address <> 'chennai'


 --TASK 3  Aggregate functions, Having, Order By, GroupBy and Joins:

 --Ques 1 Write a SQL query to Find the average account balance for all customers. 
 SELECT c.customers_id, c.first_name, avg(balance) AS Avg_Balance FROM Customers as c
 JOIN Accounts a ON c.customers_id = a.customer_id
 GROUP BY c.customers_id, c.first_name

 --Ques 2 Write a SQL query to Retrieve the top 10 highest account balances.
 Select top 10 balance from Accounts ORDER BY balance desc

 --Ques 3 Write a SQL query to Calculate Total Deposits for All Customers in specific date.
 SELECT 
SUM(CASE WHEN transaction_type = 'deposit' THEN amount 
END) as TotalDeposits
FROM Transactions
where transaction_date between '2024-01-12' and '2024-01-18' 

 --Ques 4 Write a SQL query to Find the Oldest and Newest Customers.
 --Newest Customers
SELECT top 1 CONCAT(first_name,' ',last_name) as CustomerName,DOB FROM Customers order by DOB desc
--Oldest Customers
SELECT top 1 CONCAT(first_name,' ',last_name) as CustomerName,DOB FROM Customers order by DOB 


 --Ques 5  Write a SQL query to Retrieve transaction details along with the account type.
 SELECT T.transaction_id,T.account_id,T.transaction_type, T.amount,T.transaction_date ,A.account_type 
 FROM Transactions as T 
 JOIN Accounts A on T.account_id = A.account_id

 --Ques 6 Write a SQL query to Get a list of customers along with their account details. SELECT CONCAT(first_name,' ',last_name) as CustomerName, A.account_id,A.customer_id,A.account_type,A.balance FROM Accounts as A JOIN Customers C on C.customers_id = A.customer_id 
 --Ques 7 Write a SQL query to Retrieve transaction details along with customer information for a specific account.
SELECT customers_id,CONCAT(first_name,' ',last_name) as CustomerName,DOB,email,phone_number,address,T.transaction_id,T.account_id,T.transaction_type, T.amount,T.transaction_date 
From Transactions T
JOIN Accounts A on  T.account_id= A.account_id
JOIN Customers C on A.customer_id = C.customers_id
WHERE A.account_id = 108--Ques 8 Write a SQL query to Identify customers who have more than one account.
SELECT first_name, COUNT(A.account_id) AS num_accounts
FROM Customers C
JOIN Accounts A ON C.customers_id = A.customer_id
GROUP BY C.customers_id,first_name
HAVING COUNT(A.account_id)>1

--Ques 9  Write a SQL query to Calculate the difference in transaction amounts between deposits and withdrawals
SELECT 
SUM(CASE WHEN transaction_type = 'deposit' THEN amount 
WHEN transaction_type = 'withdrawal' THEN -amount END) as DifferenceTransaction
FROM Transactions


--Ques 10  Write a SQL query to Calculate the average daily balance(Transaction) for each account over a specified period.
SELECT A.account_id, AVG(T.amount) as AveragedailyTransaction FROM Accounts A
JOIN Transactions T ON A.account_id = T.account_id
WHERE T.transaction_date BETWEEN '2024-01-12' AND '2024-01-20'
GROUP BY A.account_id

-- Ques 11 Calculate the total balance for each account type
SELECT Sum(balance) as Total_Balance , account_type 
FROM Accounts
GROUP BY account_type

--Ques 12 Identify accounts with the highest number of transactions order by descending order
SELECT A.account_id,A.customer_id,A.account_type,A.balance, T.amount
FROM Accounts A
JOIN Transactions T ON A.account_id = T.account_id
ORDER BY T.amount Desc
   
--Ques 13  List customers with high aggregate account balances, along with their account types.
-- to ask
SELECT C.customers_id,CONCAT(C.first_name,' ',C.last_name) as CustomerName, Sum(A.balance) as Aggregate_balance 
FROM Customers C
JOIN Accounts A ON C.customers_id =A.customer_id
GROUP BY C.customers_id,CONCAT(first_name,' ',last_name)
HAVING SUM(A.balance)>AVG(A.balance)

--Ques 14 Identify and list duplicate transactions based on transaction amount, date, and account.
SELECT t1.transaction_id,t1.account_id,t1.amount, t1.transaction_date 
FROM Transactions t1
JOIN Transactions t2 ON t1.amount = t2.amount AND
t1.transaction_date = t2.transaction_date AND
t1.account_id = t1.account_id AND
t1.transaction_id!=t2.transaction_id
ORDER BY t1.amount ,t1.transaction_date,t1.account_id

--Tasks 4: Subquery and its type
--Oues 1 Retrieve the customer(s) with the highest account balance.

SELECT customers_id,CONCAT(first_name, ' ', last_name) AS customer_name 
FROM Customers
WHERE customers_id IN (
SELECT customer_id
FROM Accounts 
WHERE balance = (SELECT MAX(balance) FROM Accounts)
    )

--Ques 2 Calculate the average account balance for customers who have more than one account.
 
 SELECT customers_id , CONCAT(first_name, ' ', last_name) AS customer_name,
 (SELECT AVG(balance) FROM Accounts WHERE customer_id = C.customers_id) as Averageaccountbalance
 FROM Customers C
 WHERE customers_id IN
 (SELECT  customer_id FROM Accounts
 GROUP BY customer_id
 HAVING Count(*)>1)

 --Ques 3 Retrieve accounts with transactions whose amounts exceed the average transaction amount.
 SELECT account_id from Accounts 
 WHERE account_id IN(
 SELECT t.account_id FROM Transactions t
 WHERE t.amount>(SELECT AVG(amount) from Transactions t)
 )

 --Ques 4 Identify customers who have no recorded transactions.
 SELECT customers_id ,CONCAT(first_name, ' ', last_name) AS customer_name
 FROM Customers C WHERE NOT EXISTS(
 SELECT * from Accounts A
 WHERE C.customers_id= A.customer_id 
 AND EXISTS (SELECT * from Transactions T WHERE T.account_id = A.account_id))


 --Ques 5 Calculate the total balance of accounts with no recorded transactions. SELECT Sum(balance) AS Totalbalance from Accounts A
 WHERE NOT EXISTS (SELECT * FROM Transactions t
 WHERE t.account_id = A.account_id) 
 
 --Ques 6 Retrieve transactions for accounts with the lowest balance. SELECT transaction_id, amount FROM Transactions T WHERE T.account_id IN (
 SELECT account_id from Accounts Where balance IN ( SELECT MIN(balance) FROM Accounts))
 
 --Ques 7 Identify customers who have accounts of multiple types.
SELECT * FROM Customers c WHERE c.customers_id in 
(SELECT a.customer_id from Accounts a 
GROUP BY a.customer_id 
having count(a.account_type)>1)
  

--Ques 8 Calculate the percentage of each account type out of the total number of accounts.
 SELECT account_type , COUNT(account_type)*100/(SELECT COUNT(*) FROM Accounts)AS Percentage
 FROM Accounts
 GROUP BY account_type

 --Ques 9 Retrieve all transactions for a customer with a given customer_id. SELECT transaction_id,amount,transaction_type , transaction_date 
 from Transactions T 
 WHERE T.account_id IN(
 SELECT account_id from Accounts WHERE customer_id = 10 )

 --Ques 10 Calculate the total balance for each account type, including a subquery within the SELECT clause.
 SELECT  account_type ,(SELECT SUM(balance)  
 FROM Accounts A2 
 WHERE A1.account_type = A2.account_type)AS Totalbalance
 FROM Accounts A1 
 GROUP BY account_type


 



