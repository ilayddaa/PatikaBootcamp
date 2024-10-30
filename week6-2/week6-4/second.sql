--1)
SELECT city,country FROM city
LEFT JOIN country ON city.country_id = country.country_id; --city ve country tablolarını birleştiriyoruz.

--2)
SELECT payment_id, first_name, last_name FROM payment
RIGHT JOIN customer ON payment.customer_id = customer.customer_id; --payment ve customer tablolarını birleştiriyoruz.

--3)
SELECT rental_id, first_name, last_name FROM rental 
FULL JOIN customer ON rental.customer_id = customer.customer_id; --rental ve customer tablolarını birleştiriyoruz.