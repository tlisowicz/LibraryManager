# Overwiev
This project was made to get to know how to implement ORM mapping in C# using Entity Framework and how to use microservices using WCF. 
In the application exist 3 types of users: admin, loggged user, guest. 
* Guest can browse library's offer and create an account.
* User can browse, borrow, return a book and take a look at his borrowing history.
* admin can browse, add, edit, delete books and also sees which user has borrowed a book.

In this project there are 2 microservices:
* first is resposible for filtering list of books
* second is resposible for logging user in.
