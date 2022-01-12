# Welcome to the WeDevelop .NET challenge 🚀

## Create a REST API for a bookstore

### Create a web service for the bookstore inventory

#### Requirements

##### Use the existing project to complete requirements

1. AddBooks: Add n copies of a n books.
2. ListBooks: List all books.

### Details

1. Inventory’s structure:
    * 1.1 Book’s title.
    * 1.2 Book’s stock (number of book copies in inventory of this specific book).
2. Book titles are unique:
    * 2.1 If n books have the same title, you must consider them as the same book.
    * 2.2 If n books have different titles, you must consider them as different books.
3. Your app must be able to handle this code to add the books to the bookstore.

    ``` json
    [ 
        {
            "title": "Fundation",
            "stock": 1
        },
        {
            "title": "The Lord of the Rings",
            "stock": 5
        },
        {
            "title": "1984",
            "stock": 2
        },
        {
            "title": "1984",
            "stock": 10
        }
    ]
    ```

#### ***Extra: Only try this if you have finished all the previous tasks***

1. Create a unit test.

#### You have 30 minutes to finish

Happy Coding!
