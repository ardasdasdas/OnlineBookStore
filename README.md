# OnlineBookStore

### 1 - [INTRODUCTION](https://github.com/ardasdasdas/OnlineBookStore/blob/master/README.md#1-introduction)
### 2 - [DESIGN](https://github.com/ardasdasdas/OnlineBookStore/blob/master/README.md#2-design)
### 3 - [DATABASE](https://github.com/ardasdasdas/OnlineBookStore/blob/master/README.md#3-databse)
### 4 - [UML](https://github.com/ardasdasdas/OnlineBookStore/blob/master/README.md#4-uml)
### 5 - [THE WORKS OF TEAM MEMBERS](https://github.com/ardasdasdas/OnlineBookStore/blob/master/README.md#5-the-works-of-team-members)

## 1. INTRODUCTION
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
## 2. DESIGN
### 2.1 Login Screen && Sign Up
![login](https://user-images.githubusercontent.com/53192718/86367562-c67ce400-bc84-11ea-9d69-106a6af89437.png)

If the person who using the application does not have an account, she/he is directed to the registration screen via the create account link label to create an account. Admin can’t access the users’ password. Passwords are kept encrypted form in database after user registration. If customer has an account, if username and password that entered the textboxes matches customer’s information on database(sql) he/she logged in.

![sign_up](https://user-images.githubusercontent.com/53192718/86367622-de546800-bc84-11ea-83a6-c4f28da0f96f.png)

### 2.2 Dashboard Screen
MainWindow’s load function load the products from database and customer see randomly products on dashboard, under the title “Editor’s choices”. Header has an animated text for welcome, it says good morning, good evening, good night depending on time.

![dashboard](https://user-images.githubusercontent.com/53192718/86367821-1c518c00-bc85-11ea-801b-e90fe18290d9.png)

### 2.3 Books Screen
![books screen](https://user-images.githubusercontent.com/53192718/86368086-73576100-bc85-11ea-803f-3b058d8d5402.png)

### 2.4 Music CDs Screen
When the customer clicks the Play icon which resides on the musicCD panels, a sample song is played for him/her.

![MusicCd's screen](https://user-images.githubusercontent.com/53192718/86368118-7fdbb980-bc85-11ea-9f91-3b12b9d46ec6.png)

### 2.5 Magazines Screen
![magazines screen](https://user-images.githubusercontent.com/53192718/86368308-b4e80c00-bc85-11ea-8aa3-273ae344d2a5.png)

### 2.6 My Orders Screen
Customer can see his/her order history on this screen with details.

![2 5 My Orders Screen](https://user-images.githubusercontent.com/53192718/86368441-d77a2500-bc85-11ea-8aca-77626c4bd5d3.png)

### 2.7 My Cart Screen
This screen for customer’s shopping cart. User can see and do actions all products on his/her cart on that screen.

![2 5 My Orders Screen](https://user-images.githubusercontent.com/53192718/86368633-1019fe80-bc86-11ea-9d25-78687a7c9e10.png)

### 2.8 Payment Screen
Personal information section automaticlly filled from database without phone number. When customer select and fill all the necessary sections, he/she can see total payment on the screen with taxes and shipping fee. When its done, the invoice appear on the screen and it will send to customer’s mail address on pdf form rapidly.

![2 7 Payment Screen](https://user-images.githubusercontent.com/53192718/86368798-43f52400-bc86-11ea-9b5e-f33e14372736.png)


### 2.9 Mail Example
![2 8 Mail Example](https://user-images.githubusercontent.com/53192718/86368893-6be48780-bc86-11ea-9d6e-f7ea42a8cf68.png)

### 2.10 Invoice Example
![2 9 Invoice Example](https://user-images.githubusercontent.com/53192718/86369071-a0f0da00-bc86-11ea-86a3-280103e57756.png)

### 2.11 Admin Screen for Books
Admin can add, list, delete and update all the products on this panels. Also, admin can see all the customers on customer list.

![2 10 Admin Screen for Books](https://user-images.githubusercontent.com/53192718/86369348-fa590900-bc86-11ea-8896-912db1614066.png)

### 2.12 Admin Screen for Music CDs
![2 12 Admin Screen for MusicCDs](https://user-images.githubusercontent.com/53192718/86369458-24123000-bc87-11ea-8f75-d61d57b94f4f.png)

### 2.13 Admin Screen for Magazines
![Admin Screen for Magazines](https://user-images.githubusercontent.com/53192718/86369496-33917900-bc87-11ea-98b2-b6952b14b268.png)

### 2.14 Admin Screen to see Customer List
![Admin Screen for see Customer List](https://user-images.githubusercontent.com/53192718/86369569-502db100-bc87-11ea-988c-c2b493d70ec2.png)

### 2.15 Settings Screen for Customers
If loginned user is not an admin, settings panel looking like this. Customers can change their informations with password confirmation.

![2 14 Settings Screen for Customers](https://user-images.githubusercontent.com/53192718/86369653-6b98bc00-bc87-11ea-87ed-b1bbfaf4517e.png)

## 3. Databse 
The data were kept in the online MsSQL database. For this, an online database has been created in Microsoft Azure account. All users who have access to the database have access, that is, the program can be run without the need for extra installation, but still the database creation script has been added under version control. 
A database table named Tbl Customer has been created to hold user data. For the products, 3 separate database tables named Tbl_Book, Tbl_Magazine and Tbl_Music have been created. For past orders, the Tbl_Bill and Tbl_BillProduct table have been created. The tables in the database and their relations are as follows. Database connection of the project added DbConnection class.

![database](https://user-images.githubusercontent.com/53192718/86369780-9256f280-bc87-11ea-9292-eb1e633184df.png)

You can set our database on your computer from [here](https://github.com/ardasdasdas/OnlineBookStore/tree/master/DatabaseCreationScript).
After creating you have to get your SQL connection string, after that you have to enter 28th column in [DbConnection.cs](https://github.com/ardasdasdas/OnlineBookStore/blob/master/OnlineBookStore/OnlineBookStore/DbConnection.cs) class.

## 4. UML
![UML](https://user-images.githubusercontent.com/53192718/86370686-b5ce6d00-bc88-11ea-809f-95d734edb2ac.png)

## Patterns That We Used
Since we wanted to ensure that only one object from our customer class was created in the application we will do, we applied **Singleton Design Pattern**. This customer object, which we will create in our application with **Singleton Design Pattern**, will prevent the creation of a second customer object thanks to Singleton Pattern.
While creating a User Control according to the added product in our project, we used **Factory Design Pattern** so that the user does not change the code in every choice. Added product's type determines User Control's type.
Also we could use **Proxy Design Pattern**, but we had no time.

## 5. THE WORKS OF TEAM MEMBERS
![THE WORKS OF TEAM MEMBERS](https://user-images.githubusercontent.com/53192718/86371125-368d6900-bc89-11ea-8f31-8fd04466d18a.png)

### [Muzaffer Arda Uslu](https://github.com/ardasdasdas)
### [Eda Çam](https://github.com/edacaam)
### [Onur Akkepenek](https://github.com/OnurAkkepenekk)



