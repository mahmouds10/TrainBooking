--Create the Database
create database TrainBooking;


--Use the Database
use TrainBooking;


--Create Person Table
create table Person (
user_ID int identity(1,1) primary key,
First_Name varchar(50)not null,
Last_Name varchar(50) not null,
email varchar(50) not null CHECK (email LIKE '%@%.%'),
pass varchar(50) not null cHECK (Pass LIKE '%[A-Z]%' AND pass LIKE '%[a-z]%' AND pass LIKE '%[0-9]%' AND pass LIKE '%[^a-zA-Z0-9]%'),
user_type varchar(50) not null CHECK (UPPER(user_type) IN ('CUSTOMER', 'ADMIN'))
)


--Creat train Table
create table train(
train_ID int not null identity(1,1) primary key,
train_name varchar (50) not null ,
departure_station varchar (50) not null,
arrival_station varchar (50) not null,
)


--Create Trip table
create table Trip (
trip_ID int primary key identity (1,1),
train_ID int not null foreign key REFERENCES  train(train_ID),
departure_station varchar (50) not null ,
departure_date date not null ,
departure_time time not null ,
arrival_station varchar (50) not null ,
arrival_date date not null ,
arrival_time time not null ,
max_capacity int not null ,
available_seats int not null ,
)
--Updates on Trip table 
alter table Trip 
add constraint  chk_seats CHECK (available_seats <= max_capacity) ; --"Add constraint"

alter table Trip
add available_rooms int not null ; --"Add attribute"

ALTER TABLE Trip
ADD CONSTRAINT departure_station_FK FOREIGN KEY (departure_station)
REFERENCES Station(station_name);

ALTER TABLE Trip
ADD CONSTRAINT arrival_station_FK FOREIGN KEY (arrival_station)
REFERENCES Station(station_name);

ALTER TABLE Trip
ADD CONSTRAINT check_departure_st CHECK (departure_station IN (SELECT station_name FROM Station));

ALTER TABLE Trip
ADD CONSTRAINT check_arrival_st CHECK (arrival_station IN (SELECT station_name FROM Station));

--Create Booking table 
create table Booking (
booking_ID int primary key identity(1,1) ,
trip_ID int not null foreign key REFERENCES  Trip(trip_ID),
user_ID int  not null foreign key REFERENCES  Person(user_ID),
)


--Create Station table
create table Station (
station_ID int unique identity(1,1),
station_name varchar (50) primary key ,
country varchar (50) not null
)


--Updates on Booking table
ALTER TABLE Booking drop COLUMN num_of_booked_seats;                                --Drop unnecessary column
ALTER TABLE Booking ADD booking_time DATETIME NOT NULL DEFAULT GETDATE();           --Add forgotten table
ALTER TABLE Booking ADD CONSTRAINT UC_Booking_Person_Trip UNIQUE (user_ID, trip_ID) --Add constraint


--Basic select statements
select * from Person;   --View all data in Person table
select * from train;    --View all data in Person table
select * from Trip;     --View all data in Person table
select * from Booking;  --View all data in Booking table
select * from Station;  --View all data in Station table


--Update Identity statements
DBCC CHECKIDENT('Person', RESEED, 1);  --Make user_ID = 1
DBCC CHECKIDENT('train', RESEED, 1);   --Make train_ID = 1
DBCC CHECKIDENT('Trip', RESEED, 1);    --Make trip_ID = 1
DBCC CHECKIDENT('Booking', RESEED, 1); --Make booking_ID =1


--------------------------Queries used in the C# code--------------------------

--Connection statement
Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True; 


--Login
SELECT * FROM Person 
WHERE email = '@email' AND pass = '@Pass' and user_type = '@user_type' ; 


--Rregister
INSERT INTO Person (First_Name, Last_Name, email , pass , user_type) 
VALUES ('@Value1', '@Value2', '@Value3' , '@Value4' , '@Value5'); 

------------------------------Admin Section------------------------------

--View trains and related trips 
SELECT t.*, COALESCE(tr.Trip_ID, null) AS trip_ID FROM train t 
LEFT JOIN Trip tr ON t.train_ID = tr.train_ID; 


--View all trips 
Select * from Trip; 


--Add new trai 
INSERT INTO train (train_name, departure_station, arrival_station) 
VALUES ('@train_name', '@departure_station', '@arrival_station') 


--Modify existing train 
update train 
set train_name = '@train_name' ,departure_station ='@ds' ,arrival_station = '@ars' where train_ID = '@ID'; 


--Delete existing train 
DELETE FROM train WHERE train_ID = '@id'; 


--Modify the Identity
SELECT COUNT(*) FROM train;
DBCC CHECKIDENT ('train', RESEED,"SELECT COUNT(*) FROM train;" ) 


-- Add new trip 
INSERT INTO Trip (train_ID, departure_station, departure_date,departure_time, arrival_station,arrival_date,arrival_time,max_capacity,available_seats) 
VALUES ('@train_ID', '@departure_station','@departure_date','@departure_time', '@arrival_station' , '@arrival_date','@arrival_time','@max_capacity' ,'@available_seats'); 


--Modify existing trip
update Trip set 
train_ID = '@ID' , departure_station = '@ds' , departure_Date = '@dd' , departure_time = '@dt' , arrival_station = '@ars' , arrival_date = '@ad' , arrival_time = '@at' , max_capacity = '@max' , available_seats = '@av' where trip_ID = '@TID';   


-- Delete existing trip 
DELETE FROM Trip WHERE trip_ID = '@id'; 


--Modify the Identity
DBCC CHECKIDENT ('Trip', RESEED, "SELECT COUNT(*) FROM Trip"); 

-------------------------------------------------------------------------


----------------------------Customer Section-----------------------------

--Get user_ID by knowing the email
SELECT user_ID FROM Person WHERE email = '@Email'; 


--View user data and booked trip
SELECT p.user_ID, p.First_Name, p.Last_Name, p.email, COALESCE(b.booking_ID, null) AS booking_ID, t.trip_ID, t.departure_station, t.arrival_station ,b.booking_time FROM Person p 
LEFT JOIN Booking b ON p.user_ID = b.user_ID 
LEFT JOIN Trip t ON b.trip_ID = t.trip_ID where p.user_ID = '@id' ; 


--View available trips , available seats for each and trip_ID to book anyone
select tr.trip_ID, tr.departure_station , tr.departure_date , tr.departure_time , tr.arrival_station , tr.arrival_date , tr.arrival_time , tr.available_seats 
from Trip tr; 


--Modify user data
update Person 
set First_Name = '@Fn' , Last_Name = '@Ls' , email = '@email' , pass = '@ps' where user_ID = '@id'; 

--Delete the profile

DELETE FROM Person WHERE user_ID = '@id'; 


--Book a Trip
insert into Booking(trip_ID , user_ID ,booking_time) values ('@tid' , '@uid' ,GETDATE()); 


--Decrement available_seats automatically
UPDATE Trip 
SET available_seats = (max_capacity - (SELECT COUNT(*) FROM Booking WHERE trip_ID = '@id')) WHERE trip_ID = '@tid'; 


--Unbook a trip
DELETE FROM Booking WHERE booking_ID = '@id'; 


--Modify the Identity
DBCC CHECKIDENT ('Booking', RESEED, "SELECT COUNT(*) FROM Booking"); 


--Increment the Identity
UPDATE Trip 
SET available_seats = (max_capacity - (SELECT COUNT(*) FROM Booking WHERE trip_ID = '@tid')) WHERE trip_ID = '@tid'; 

-------------------------------------------------------------------------