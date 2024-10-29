--1)
SELECT rating FROM film
GROUP BY rating; -- film tablosundaki rating sütunundaki farklı değerleri verir.

--2)
SELECT replacement_cost, COUNT(*) FROM film
GROUP BY replacement_cost
HAVING COUNT(*) > 50; -- 50'den fazla filmi olan replacement_cost değerlerini verir.

--3)
SELECT store_id, COUNT(*) FROM customer
GROUP BY store_id; -- Store_id'ye göre müşteri sayısını verir.

--4)
SELECT country_id FROM city 
GROUP BY country_id -- gruplayarak country_id'ye göre sıralar.
ORDER BY country_id DESC -- büyükten küçüğe sıralar.
LIMIT 1; -- en büyük country_id'yi verir.