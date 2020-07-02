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


