--1)
SELECT country FROM country
WHERE country LIKE 'A%a'; -- A ile başlayıp a ile biten ülkeleri seçer.

--2)
SELECT country FROM country
WHERE country LIKE '_____%n'; -- 6 harfli ve n ile biten ülkeleri seçer.

--3)
SELECT title FROM film
WHERE title ILIKE '%t%t%t%t%' --title içinde 4 t harfi olan filmleri seçer.

--4)
SELECT * FROM film
WHERE title LIKE 'C%' AND length>90 AND rental_rate=2.99; -- C ile başlayan, uzunluğu 90 dakikadan fazla ve kiralama ücreti 2.99 olan filmleri seçer.