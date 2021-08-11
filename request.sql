SELECT Products.name as Name, Category.name as Category FROM Products 
LEFT JOIN Category ON Products.id = Category.productId
Order by Name