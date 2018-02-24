use DB09TMS101_1718
create table mera_customer_11
(cid int identity(1,1) primary key,
cname varchar(20),
 gender varchar(20),
 birth date,
 contact bigint,
  city varchar(20)
  )
 insert into mera_customer_11 values( 'Anu' ,'F', '01-15-1988', 8015557674, 'Trivandrum');
 insert into mera_customer_11 values('Beno',' F', '02-01-1985', 8015557675 ,'Chennai');
 insert into mera_customer_11 values('Snehasis', 'M', '04-21-1970',8015557676, 'Delhi');
 insert into mera_customer_11 values('Ajay', 'M', '09-14-1989', 8015557677,'Kolkata');

 select * from mera_customer_11

 create table Account_ka_table
 (cid int foreign key references mera_customer_11(cid),
 aid int identity(1000,1),
 amount float,
 asd date,
 account_type varchar(20),
 astatus varchar(20),
 );
 create proc Account_ka_procedure
 @cid int,@am float, @asd date,@aty Varchar(20), @ast varchar(20),@aid int out
 as
 begin
 insert into Account_ka_table values(@cid,@am,@asd,@aty,@ast);
 set @aid = @@IDENTITY
 end;

 create proc viewing_ka_stored_procedure1
 as 
 begin
 select * from  mera_customer_11
 end;
 create proc cust_by_id1
 @id int
 as 
 begin
 select * from mera_customer_11 where cid =@id
 end;
 create proc acc_ka_view
 as
 begin
 select * from Account_ka_table
 end;
