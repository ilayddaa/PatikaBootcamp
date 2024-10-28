-- 1)
SELECT * FROM film 
WHERE replacement_cost BETWEEN 12.99 AND 16.99; -- film tablosunda bulunan replacement_cost sütunu 12.99 ve 16.99 arasında olan filmleri sıralayınız.

-- 2) 
SELECT first_name, last_name FROM actor
WHERE first_name IN ('Penelope', 'Nick', 'Ed'); --- actor tablosunda bulunan first_name 'Penelope' 'Nick' 'Ed' olan kişilerin first_name ve last_name sütunlarını sıralayınız.

--3)
SELECT * FROM film
WHERE rental_rate IN (-0.99, 2.99, 4,99) AND replacement_cost IN (12.99, 15.99, 28.99); -- film tablosunda bulunan rental_rate 'i 0.99 ya da 2.99 ya da 4.99 olan filmleri sıralayınız.

