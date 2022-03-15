CREATE PROCEDURE [dbo].[UnosUc]
	@Ime varchar(50),
	@Prezime varchar(50)
AS
begin
	insert into dbo.[Ucenici] (Ime, Prezime)
	values (@Ime, @Prezime)
end
RETURN 0
