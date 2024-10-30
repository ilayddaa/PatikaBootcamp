--1)
SELECT city, country FROM city --city ve country tablolarını seçiyoruz.
INNER JOIN country ON city.country_id = country.country_id; --ınner join ile city ve country tablolarını birleştiriyoruz.

--2)
SELECT payment_id, first_name, last_name FROM payment
INNER JOIN customer ON payment.customer_id = customer.customer_id; --payment ve customer tablolarını birleştiriyoruz.

--3)
SELECT rental_id, first_name, last_name FROM rental
INNER JOIN customer ON rental.customer_id = customer.customer_id; --rental ve customer tablolarını birleştiriyoruz.

--SELECT rental_id, first_name, last_name FROM customer
--INNER JOIN rental ON customer.customer_id = rental.customer_id; --üstteki ile aynı işlemi yapar.