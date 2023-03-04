SELECT 
  CONCAT(c.FirstName, ' ', c.LastName) AS FullName,
  c.Age,
  o.OrderID,
  o.DateCreated,
  o.MethodOfPurchase AS PurchaseMethod,
  od.ProductNumber,
  od.ProductOrigin
FROM 
  Customer c
  JOIN Orders o ON c.PersonID = o.PersonID
  JOIN OrderDetails od ON o.OrderID = od.OrderID
WHERE 
  od.ProductID = '1112222333';