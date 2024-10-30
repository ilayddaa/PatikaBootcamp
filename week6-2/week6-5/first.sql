--1) 
SELECT COUNT(length) FROM film
WHERE length > --film tablosundaki length sütunundaki değerlerin ortalamasından büyük olanları seçiyoruz.
(
    SELECT AVG(length) FROM film 
);

--2) rental_rate sütunundaki en yüksek değere sahip olanları seçiyoruz.
SELECT COUNT(rental_rate) FROM film 
WHERE rental_rate =  
(
SELECT MAX(rental_rate) FROM film
);

--3) rental_rate ve replacement_cost sütunundaki en düşük değere sahip olanları seçiyoruz.
SELECT title FROM film
WHERE rental_rate = 
(
    SELECT MIN(rental_rate) FROM film 
) 
AND replacement_cost =
(
    SELECT MIN(replacement_cost) FROM film
);

--4)
SELECT customer_id,COUNT(*) FROM payment
GROUP BY customer_id
ORDER BY COUNT(customer_id) DESC;