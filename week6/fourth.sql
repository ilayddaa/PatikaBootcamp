--1)
SELECT DISTINCT replacement_cost FROM film; -- film tablosundaki replacement_cost sütunundaki farklı değer sayısını verir.

--2)
SELECT COUNT (DISTINCT  replacement_cost) FROM film; -- film tablosundaki replacement_cost sütunundaki farklı değer sayısını verir. 

--3)
SELECT COUNT(title) FROM film
WHERE title LIKE 'T%' AND rating = 'G' ; -- T ile başlayan ve rating'i G olan filmlerin sayısını verir.

--4)
SELECT COUNT(country) FROM country
WHERE country LIKE '_____'; -- 5 harfli ülkelerin sayısını verir.

--5)
SELECT COUNT(city) FROM city
WHERE city ILIKE '%r'; -- r harfi ile biten şehirlerin sayısını verir.