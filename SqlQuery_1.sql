﻿DECLARE @FromDate DATETIME = DATEADD(DAY, -50, GETDATE())
DECLARE @ToDate   DATETIME = DATEADD(DAY, +50, GETDATE())

DECLARE @Seconds INT = DATEDIFF(SECOND, @FromDate, @ToDate)
DECLARE @Random INT = ROUND(((@Seconds-1) * RAND()), 0)
DECLARE @Milliseconds INT = ROUND((999 * RAND()), 0)

insert into DayEvents Values (10, DATEADD(MILLISECOND, @Milliseconds, DATEADD(SECOND, @Random, @FromDate)), 1, 1, 1, 1);

insert into DayEvents Values ('12345678901', 'zdarzenie', DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0), DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0));

SELECT @@VERSION

create table DayEvents
(
	eventID				INTEGER                       not null,
	eventDate			DATE                          not null,
	startHour   		INTEGER                       not null, 
	startMinute			INTEGER     				  not null,
	endHour				INTEGER      				  not null,
	endMinute			INTEGER						  not null,
	constraint PK_DayEvent primary key (eventID)
);

create table DayEvents
(
	eventID				INTEGER                       not null,
	eventDescription	TEXT						  not null,
	startTime			DATETIME                      not null,
	endTime	    		DATETIME                      not null,
	constraint PK_DayEvent primary key (eventID)
);

create table Users
(
	username			char(32)					not null,
	constraint PK_User primary key (username)
);

create table DayEvents
(
	username			char(32)					not null,
	eventDescription	char(32)					not null,
	startTime			DATETIME					not null,
	endTime	    		DATETIME					not null,
	constraint PK_DayEvent primary key (username, eventDescription, startTime, endTime)
);

alter table DayEvents
   add constraint FK_DayEventForUser foreign key (username)
      references Users (username);


select * from DayEvents;

select * from Users;

delete from DayEvents;

delete from Users;

drop table DayEvents;

drop table Users;

DELETE FROM DayEvents
WHERE 
username = 'postasze' AND
eventDescription = 'POBO' AND
startTime = CAST('2017-11-23 12:15:01.000' AS DATETIME) AND 
endTime = CAST('2017-11-23 14:00:01.000' AS DATETIME);

--startTime = DATETIMEFROMPARTS ( 2017, 11, 23, 12, 15, 1, 0 )  AND
--endTime = DATETIMEFROMPARTS ( 2017, 11, 23, 14, 0, 1, 0 ) ;

--startTime = CAST(CAST(2017 AS varchar) + '-' + CAST(11 AS varchar) + '-' + CAST(23 AS varchar) 
--+ ' ' + CAST(12 AS varchar) + '-' + CAST(15 AS varchar) + '-' + CAST(1 AS varchar) AS DATETIME) AND 
--endTime = CAST(CAST(2017 AS varchar) + '-' + CAST(11 AS varchar) + '-' + CAST(23 AS varchar) 
--+ ' ' + CAST(14 AS varchar) + '-' + CAST(0 AS varchar) + '-' + CAST(1 AS varchar) AS DATETIME);
