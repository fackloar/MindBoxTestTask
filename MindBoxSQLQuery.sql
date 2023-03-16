SELECT 
  p.ProductName, 
  COALESCE(c.CategoryName, 'Uncategorized') AS CategoryName 
FROM 
  Products p
  LEFT JOIN Categories c ON p.CategoryID = c.CategoryID
ORDER BY 
  p.ProductName;