Вопрос №2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT p.name, 
	   c.name
FROM dbo.products p
LEFT JOIN dbo.product_categories pc
	ON p.id = pc.product_id
LEFT JOIN dbo.categories c 
	ON pc.category_id = c.id


 Результат работы запроса: 
 https://github.com/Ren4co/FigureCalculator/blob/master/result.PNG




CREATE DATABASE SHOP

USE SHOP;

CREATE TABLE products
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	"name" NVARCHAR(30) NOT NULL
)

CREATE TABLE categories
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	"name" NVARCHAR(30) NOT NULL
)

CREATE TABLE product_categories
(
	product_id INT REFERENCES products (id) NOT NULL,
	category_id INT REFERENCES categories (id) NOT NULL
)


INSERT INTO products (name) 
VALUES 
('Диван'), 
('Кровать'), 
('Апельсины'), 
('Яблоки'), 
('Видеокарта')

INSERT INTO categories (name) 
VALUES 
('Все для дома'), 
('Мебель'), 
('Фрукты')

INSERT INTO product_categories (product_id, category_id) 
VALUES 
(1, 1), 
(1, 2), 
(2, 1), 
(2, 2), 
(3, 3), 
(4, 3)
