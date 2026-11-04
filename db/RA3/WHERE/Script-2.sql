-- 1
select product_id,product_name,unit_price 
from products 
where unit_price>30;

-- 2
select product_name,unit_price 
from products 
where unit_price between 10 and 20;

-- 3
select customer_id, company_name 
from customers 
where company_name like 'A%';

-- 4
select order_id, order_date, shipped_date 
from orders 
where shipped_date is null;

-- 5
select customer_id, company_name, country 
from customers 
where country = 'Germany';

-- 6
select customer_id, company_name, country 
from customers 
where country <> 'France';

-- 7
select product_name, unit_price 
from products 
where unit_price >= 50;

-- 8
select product_id, product_name, units_in_stock 
from products 
where units_in_stock < 10;

-- 9
select order_id, freight 
from orders 
where freight <= 20;

-- 10
select product_name, units_in_stock, reorder_level 
from products 
where units_in_stock < reorder_level;

-- 11
select order_id, product_id, quantity 
from order_details 
where quantity between 10 and 20;

-- 12
select customer_id, company_name, country 
from customers 
where country in ('Spain','France','Portugal');

-- 13
select product_id, product_name, category_id 
from products 
where category_id in (1,3,5);

-- 14
select product_id, product_name 
from products 
where product_name like 'Chef%';

-- 15
select product_id, product_name 
from products 
where product_name like '%ch%';

-- 16
select customer_id, company_name 
from customers 
where company_name like '%Ltd.';

-- 17
select customer_id, company_name 
from customers 
where customer_id like 'A____';

-- 18
select customer_id, company_name, fax 
from customers 
where fax is null;

-- 19
select order_id, order_date, shipped_date 
from orders 
where shipped_date is not null;

-- 20
select product_id, product_name, unit_price, units_in_stock 
from products 
where (unit_price <= 25) and (units_in_stock > 0);

-- 21
select customer_id, company_name, city, country 
from customers 
where city = 'London' or city = 'Berlin';

-- 22
select customer_id, company_name, country, region 
from customers 
where (country = 'France' and region is null) 
or (country = 'Germany' and region is null);

select customer_id, company_name, country, region 
from customers where country in ('France','Germany') 
and region is null;

-- 23
select product_name, units_in_stock, reorder_level, units_on_order 
from products 
where units_in_stock < reorder_level and units_on_order = 0;

-- 24
SELECT customer_id, company_name, fax 
FROM customers 
WHERE fax is null;

SELECT customer_id, company_name, fax 
FROM customers 
WHERE fax is not null;

-- 25
SELECT customer_id, company_name, country, fax
FROM customers
WHERE (country = 'France' AND fax IS NULL)
   OR (country = 'Germany' AND fax IS null);

-- 1. Primer agrupa els ands
-- 2. Si, passarien el filtre tots els clients de frança

-- 26
select product_id, product_name, unit_price * units_in_stock 
as "valor_estoc" from prodcuts where 















