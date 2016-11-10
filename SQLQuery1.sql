use master
go
create database FriendManagement
go
use FriendManagement
go

create table FriendInformation
(
Id int identity(1,1) primary key not null,
Name varchar(100) not null,
Type varchar(50) not null,
Phone varchar(100) not null,
Address varchar(500) not null,
Facebook varchar(100) not null,
Duration varchar(100) not null
)