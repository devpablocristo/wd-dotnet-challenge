# Welcome to the WeDevelop .NET challenge 🚀

## Create a REST API for a bookstore

### Create a web service for the bookstore inventory

#### Requirements

##### You can use the existing project to complete requirements or start a new from scratch

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
        }
    ]
    ```

Happy Coding!
