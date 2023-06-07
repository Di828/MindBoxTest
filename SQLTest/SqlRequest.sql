SELECT product.name AS product, category.name AS category FROM products
LEFT JOIN product_category USING (product_id)
LEFT JOIN category USING (category_id)
