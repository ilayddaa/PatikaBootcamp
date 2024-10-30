--1) birleşenleri bulmak için UNION kullanılır.
(
SELECT first_name FROM actor
)
UNION
(
    SELECT first_name FROM customer
)

--2) kesişenleri bulmak için INTERSECT kullanılır.
(
    SELECT first_name FROM actor
)
INTERSECT
(
    SELECT first_name FROM customer
)

--3) actor de bulunup customer da bulunmayanları bulmak için EXCEPT kullanılır.
(
    SELECT first_name FROM actor
)
EXCEPT
(
    SELECT first_name FROM customer
)

--4) UNION ALL kullanarak birleşenleri bulmak için
(
    SELECT first_name FROM actor
)
UNION ALL
(
    SELECT first_name FROM customer
)