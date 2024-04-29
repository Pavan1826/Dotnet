use Practice

create table emp
(
	Eid int primary key identity(1,1),
	Ename varchar(20),
	City varchar(20),
	Address1 varchar(20)
);

--add emp
create procedure sp_addemp
(
	@name varchar(20),
	@City varchar(20),
	@Address1 varchar(20)
)
as
begin
	insert into emp values(@name,@City,@Address1)
End

--update emp
create procedure sp_updateemp
(
	@id int,
	@name varchar(20),
	@City varchar(20),
	@Address1 varchar(20)
)
as
begin
	update emp set Ename= @name,City = @City,Address1 = @Address1
	where eid = @id
End

--delete emp
create procedure sp_deleteemp
(
	@id int
)
as
begin
	delete from emp 
	where eid = @id
End

--viewdetail
create procedure sp_viewdetail
as
begin
	select * from emp
end