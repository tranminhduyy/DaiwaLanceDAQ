use DAQ

delete from DAILY
declare @dateb datetime
set @dateb = getdate()
declare @start date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-0, @dateb-1)
declare @end date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-0, @dateb-1)


insert into DAILY
select * from VARIABLE_DAQ where DATE_TIME between @start and @end;
select * from DAILY
