--1)
SELECT ROUND(AVG(rental_rate),3) FROM film; -- film tablosundaki rental_rate sütunundaki değerlerin ortalamasını verir.

--2)
SELECT COUNT(*) FROM film
WHERE title ILIKE 'C%'; -- title'ı C olan filmleri verir.

--3)
SELECT MAX(length) FROM film
WHERE rental_rate = 0.99; -- rental_rate'i 0.99 olan filmler arasından en uzun filmi verir.

--4)
SELECT COUNT(DISTINCT(replacement_cost)) FROM film 
WHERE length > 150; -- length'i 150'den büyük olan filmlerin replacement_cost sütunundaki farklı değer sayısını verir.