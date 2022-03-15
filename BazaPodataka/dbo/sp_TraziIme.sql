CREATE PROCEDURE [dbo].[sp_TraziIme]
	@Ime varchar(50)

AS
	select *
	from dbo.[Ucenici]
	where Ime=@Ime;
Return 0