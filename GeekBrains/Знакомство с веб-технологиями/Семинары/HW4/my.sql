CREATE TABLE Members (
  id int NOT NULL PRIMARY KEY,   
  name varchar(255) NOT NULL,
  age int NOT NULL,
  address varchar(255) NOT NULL
);  

INSERT INTO Members VALUES (01, 'Caria', 29, 'Moskau');
INSERT INTO Members VALUES (02, 'Dave', 30, 'SPb');
INSERT INTO Members VALUES (03, 'Ava', 35, 'Florida');
INSERT INTO Members VALUES (04, 'Sam', 25, 'Moskau');
INSERT INTO Members VALUES (05, 'John', 20, 'Moskau');

SELECT * FROM MEMBERS WHERE  age >= 18 and age <= 30 and address = 'Moskau';