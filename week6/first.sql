--1. 
SELECT description, title FROM film; -- film tablosunda bulunan title ve description sütunlarını sırasıyla getiriniz.

--2. 
SELECT * FROM film WHERE length > 60 AND length < 75; -- film tablosunda bulunan ve uzunluğu 60 ile 75 arasında olan filmleri sıralayınız.

--3. 
SELECT * FROM film
WHERE rental_rate = 0.99 AND replacement_cost = 12.99 OR replacement_cost = 28.99; -- film tablosunda bulunan ve fiyatı 0.99 a eşit olan ya da replacement_cost 12.99 ya da 28.99 olan filmleri sıralayınız.

--4.
SELECT last_name FROM customer WHERE first_name = 'Mary'; -- customer tablosunda bulunan first_name 'Mary' olan müşterinin last_name 'ını sıralayınız.

--5.
SELECT * FROM film
WHERE length < 50 AND NOT (rental_rate = 2.99 OR rental_rate = 4.99); -- film tablosunda bulunan uzunluğu 50den küçüj olan ve rental_rate i 2.99 ya da 4.99 olmayan filmleri sıraladık.