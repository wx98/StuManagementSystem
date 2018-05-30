create database SIMS
on
(
	name = SIMS,
	filename ="../SIMS/DataBase/sims.mdf", 
	size = 5,
	maxsize = 10
)
log on
(
	name=SIMS_log,
	filename ="../SIMS/DataBase/sims_log.ldf",
	size = 5,
	filegrowth = 10%,
	maxsize = 10
)
use SIMS
GO
--close SIMS --关闭数据库
--drop database SIMS -- 删除数据库
create table t_admin
(
	ID int identity,
	UNaem varchar(10) null,
	Pass varchar(20) null,
	constrainr pk_admin primary key (ID)
)
GO
create table t_department
(
	ID int not null,
	Name Varchar(30) not null,
	Direc varchar(10) not null,
	Note varchar(100) not null,
	constraint pk_department primary key (ID)
)
GO

create table t_major
(
	ID int not null,
	Name Varchar(30) not null,
	depart varchar(20) not null,
	Note varchar(100) not null,
	constraint pk_major primary key(ID),
	constraint pk_depart foreign key (major) references t_major(ID)
)
GO

create table t_student
(
	UNo  int not null,
	Name varchar(8) not null,
	Sex char (2) check(Sex in ('男','女')) not null,
	Birth varchar (10) not null,
	ID char (18) not null,
	Origo varchar (10) not null,
	Addr varchar (50),
	Tel varchar (13),
	IYear varchar (10) not null,
	class int not null,
	Note varchar (100),
	constraint pk_student primary key (UNo),
	constraint fk_stu_class foreign key (class)  references t_class (ID)
)
GO

create view vi_department_info(编号,名称,院长,备注)as
select d.ID,d.Name,d.Direc,d.Note
from t_department as d
GO

create view vi_major_info(编号,名称,院长,备注)as 
select m.ID,m.Name,d.Nam,d.Note 
from t_major as m, t_deparment as d 
where  m.depart =  dID
GO

create view vi_class_info(编号,班级名称,辅导员,专业名称,学院名称) as
select c.ID,c.Name,c.Couns,m.Name,d.Name
from t_class as c,t_major as m,t_department as d 
where c.major = m.ID and m.depart = d.ID
GO

create view vi_Stu_Info(学号,姓名,性别,出生日期)

