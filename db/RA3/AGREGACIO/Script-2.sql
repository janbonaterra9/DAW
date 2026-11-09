-- 1
select count(*)
from customers;

-- 2
select count(*)
from customers
where city = 'London';

-- 3
select count(*)
from customers
where city like '%p%';

-- 4
select count(*)
from orders
where shipped_date is not null;

-- 5 
select count(distinct unit_price)
from products;