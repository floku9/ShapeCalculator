SELECT Products.name as productName, Category.name as category FROM Products 
LEFT JOIN Category ON Products.id = Category.productId
Order by productName