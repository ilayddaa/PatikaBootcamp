--1)
SELECT * FROM film -- film tablosundaki tüm sütunları ve satırları alır.
WHERE title LIKE '%n' -- title sütununda n harfi geçen filmleri alır.
ORDER BY length DESC
LIMIT 5;

--2)
SELECT * FROM film -- film tablosundaki tüm sütunları ve satırları alır.
WHERE title LIKE '%n' 
ORDER BY length ASC 
OFFSET 5 -- ilk 5 satırı atlar.
LIMIT 5; -- 6. satırdan itibaren 5 satır alır.

--3)
SELECT last_name FROM customer 
WHERE store_id = 1 -- store_id'si 1 olan müşterilerin soyadlarını alır.
ORDER BY last_name DESC --
LIMIT 4; -- sondan 4. müşterinin soyadını verir.


