# OnlineBookStore
## 1.INTRODUCTION
Online Book Store is a desktop application where books, music and magazines are ordered by customers.
Customers can access product information. For book such as book name, ISBN number, the author, the publisher, the page number, total price. For magazine such as magazine name, the issue, the type of the magazine, total price. For musicCD such as the name of the singer, the type of the music, total price.
When registering to the application, the customer enters a unique user name, name, password, address and a valid email address, and can change her/his password on the settings panel if she/he wishes. 
After the customer has registered to the application, he/she can add or remove products from his/her cart. He/she can make installments with credit card or pay cash. He/she can choose the shipping company to deliver.
The invoice is sent to the user mail in PDF format, After the payment is made, the invoice is automatically opened on the screen by the pdf reader.
The customer can view his/her past orders.
Customer information, product information, customers’ past orders, products in the cart are kept in the database (sql).
Passwords are saved to the database in encrypted form for customer security.
There is only one admin in the application. (U:admin / P:admin)
Admin can add, delete, update books, magazines and musicCDs also list product information from the settings panel in the application.
Customer can't access the product change interface that admin can access. 
## 2.DESIGN
### 2.1 Login Screen && Sign Up
![login](https://user-images.githubusercontent.com/53192718/86367321-7736b380-bc84-11ea-9144-977db4673c0b.png)
If the person who using the application does not have an account, she/he is directed to the registration screen via the create account link label to create an account. Admin can’t access the users’ password. Passwords are kept encrypted form in database after user registration. If customer has an account, if username and password that entered the textboxes matches customer’s information on database(sql) he/she logged in.
![sign_up](https://user-images.githubusercontent.com/53192718/86367417-97667280-bc84-11ea-96f0-e5719f21db4d.png)

