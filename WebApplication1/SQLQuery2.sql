use Practice

create table p1
(
	ename varchar(20),
	age int
);

select * from p1

create table p2
(
	ename varchar(20),
	email varchar(20),
	mobile int
);

select * from p2


alter procedure spp2
@name varchar(20),
@email varchar(20),
@mobile int,
@action varchar(20)
as
begin
if @action = 'insert'
	insert into p2 (ename,email,mobile)
		values(@name,@email,@mobile)
if @action = 'update'
	update p2
		set
		email = @email,
		mobile = @mobile
		where ename = @name
if @action = 'delete'
	delete from p2
	where ename = @name
end