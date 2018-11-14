GO
create database EVENTUS
--Tabellenkonfiguration
GO
use EVENTUS
GO
create table Veranstaltungen_Auftraggeber(	
	vaa_auftraggeber_ID int PRIMARY KEY,
	vaa_auftraggeber_name varchar(50) not null)
	
create table Veranstaltungen_Ort_Standort (	
	vos_standort_ID int PRIMARY KEY,
	vos_standort_name varchar(100)UNIQUE not null)

create table Veranstaltungen_Ort (	
	vo_ort_ID int PRIMARY KEY,
	vo_standort_ID int FOREIGN KEY REFERENCES Veranstaltungen_Ort_Standort,
	vo_ort_name varchar(100),
	vo_ort_info	varchar(100))

create table Veranstaltungen_Daten (
	vd_veranst_ID int PRIMARY KEY,
	vd_veranst_name varchar (100) NOT NULL,
	vd_veranst_info varchar(50),
	vd_veranst_von date NOT NULL,
	vd_veranst_bis date,
	vd_veranst_ort_ID int FOREIGN KEY REFERENCES Veranstaltungen_Ort,
	vd_veranst_auftraggeber int FOREIGN KEY REFERENCES Veranstaltungen_Auftraggeber)
					
create table Veranstaltungen_Showact_Kategorie (
	vsk_kategorie_ID int PRIMARY KEY,
	vsk_kategorie_name varchar(50) not null)										
															
create table Veranstaltungen_Showacts ( 
	vs_showact_ID int PRIMARY KEY,
	vs_titel varchar(8),
	vs_vorname varchar(50),
	vs_name varchar(100),
	vs_firma varchar(100),
	vs_kategorie_ID int FOREIGN KEY REFERENCES Veranstaltungen_Showact_Kategorie)
									
create table Veranstaltungen_Daten_Showacts (	
	vds_veranst_ID int FOREIGN KEY REFERENCES Veranstaltungen_Daten,
	vds_showact_ID int FOREIGN KEY REFERENCES Veranstaltungen_Showacts)

create table Veranstaltungen_Einnahmen_Kategorie (	
	vek_kategorie_ID int PRIMARY KEY,
	vek_kategorie_name varchar(50) UNIQUE not null)

create table Veranstaltungen_Einnahmen (
	ve_einnahmen_ID int FOREIGN KEY REFERENCES Veranstaltungen_Einnahmen_Kategorie,
	ve_veranst_ID int FOREIGN KEY REFERENCES Veranstaltungen_Daten,
	ve_einnahmen_hoehe money) 

create table Veranstaltungen_Ausgaben_Kategorien (	
	vak_ausgaben_ID int PRIMARY KEY,
	vak_ausgaben_name varchar(50) not null)

create table Veranstaltungen_Ausgaben (	
	va_ausgaben_ID int FOREIGN KEY REFERENCES Veranstaltungen_Ausgaben_Kategorien,
	va_veranst_ID int FOREIGN KEY REFERENCES Veranstaltungen_Daten,
	va_ausgaben_betrag money )

create table Veranstaltungen_Sponsoren_namen (	
	vsn_sponsoren_ID int PRIMARY KEY,
	vsn_sponsoren_name varchar(100) UNIQUE not null)

create table Veranstaltungen_Sponsoren (
	vsp_sponsoren_ID int FOREIGN KEY REFERENCES Veranstaltungen_Sponsoren_namen,
	vsp_veranst_ID int FOREIGN KEY REFERENCES Veranstaltungen_Daten,
	vsp_sponsoren_betrag money DEFAULT(0))


--Block2: Lieferanten und Dienstleister

create table Lieferanten_Dienstleister_Daten (	
	lfdd_lieferanten_ID int PRIMARY KEY,
	lfdd_lieferanten_name varchar(100) not null,
	lfdd_lieferanten_straße varchar(50) not null,
	lfdd_lieferanten_hsnr varchar(10) not null,
	lfdd_lieferanten_plz varchar(5),
	lfdd_lieferanten_ort int FOREIGN KEY REFERENCES Veranstaltungen_Ort_Standort,
	lfdd_lieferanten_bereich int FOREIGN KEY REFERENCES Veranstaltungen_Ausgaben_Kategorien)

create table Lieferanten_Veranstaltungen (	
	lv_lieferanten_ID int FOREIGN KEY REFERENCES Lieferanten_Dienstleister_Daten,
	lv_veranst_ID int FOREIGN KEY REFERENCES Veranstaltungen_Daten)


--Block3: Gäste und Aussteller

create table Gaeste_Aussteller_Daten (	
	gad_gaeste_ID int PRIMARY KEY,
	gad_gaeste_vname varchar(50),
	gad_gaeste_nname varchar(100) not null,
	gad_gaeste_str varchar(100),
	gad_gaeste_hsnr varchar(10),
	gad_gaeste_plz varchar(5) CHECK(gad_gaeste_plz like '[0-9][0-9][0-9][0-9][0-9]' Or gad_gaeste_plz like ''),
	gad_gaeste_ort_ID int FOREIGN KEY REFERENCES Veranstaltungen_Ort_Standort ,
	gad_gaeste_email varchar(50)  CHECK(gad_gaeste_email LIKE '%__@%_.__' Or gad_gaeste_email LIKE '%__@%_.___' Or gad_gaeste_email LIKE '%__@%_.____' Or gad_gaeste_email like '' ), --'^[A-Z,a-z]*[0-9]*][.]*[@][A-Z,a-z]{1,*}[-]{0,*}[.]{0,*}[.][a-z){0,3}$'
	gad_gaeste_telnr varchar(15)  CHECK(gad_gaeste_telnr LIKE '[0-9][0-9][0-9][0-9][0-9]/[0-9][0-9][0-9][0-9][0-9][0-9]' OR gad_gaeste_telnr LIKE '[0-9][0-9][0-9][0-9]/[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR gad_gaeste_telnr like ''  ),
	gad_gaeste_vip varchar(4) CHECK(gad_gaeste_vip LIKE 'Ja' OR gad_gaeste_vip LIKE 'NEIN'))

create table Gaeste_Aussteller_Veranstaltungen (	
	gav_gaeste_ID int FOREIGN KEY REFERENCES Gaeste_Aussteller_Daten,
	gav_veranst_ID int FOREIGN KEY REFERENCES Veranstaltungen_Daten)

		
--Block 4: Mitarbeiter

create table Mitarbeiter_Positionen (	
	map_position_ID int PRIMARY KEY,
	map_position_name varchar(50) not null)

create table Mitarbeiter_Daten (
	mad_mitarbeiter_ID int PRIMARY KEY,
	mad_mitarbeiter_vname varchar(30)not null,
	mad_mitarbeiter_nname varchar(30)not null,
	mad_position_ID int FOREIGN KEY REFERENCES Mitarbeiter_Positionen,
	mad_mitarbeiter_stunden varchar (15) not null,
	mad_mitarbeiter_von date not null,
	mad_mitarbeiter_bis date,
	mad_mitarbeiter_jahresgehalt money,
	mad_mitarbeiter_monatsgehalt money)

create table Mitarbeiter_Veranstaltungen (	
	mav_veranst_ID int FOREIGN KEY REFERENCES Veranstaltungen_Daten,
	mav_mitarbeiter_ID int FOREIGN KEY REFERENCES Mitarbeiter_Daten)

GO
GO
--Trigger für DB
use EVENTUS;

--** 
--Import-Trigger -> Datumseinstellung, Viewaktualisierung
Go
CREATE TRIGGER Veranstaltung_Daten_zuk_Datum on dbo.Veranstaltungen_Daten
INSTEAD OF INSERT,UPDATE, DELETE
AS

SET NOCOUNT ON
	Declare @vorgang char(1)

	If (Select Count(*) from deleted) = 0
		Set @vorgang = 'I'
	Else
		If (Select COUNT(*) from inserted) = 0
		Set @vorgang = 'D'
		Else
		Set @vorgang = 'U'

If @vorgang = 'I'
Begin
	Declare @vd_veranst_ID int , @vd_veranst_name varchar(100) , @vd_veranst_info varchar(50),@vd_veranst_von date,@vd_veranst_bis date,@vd_veranst_ort_ID int, @vd_veranst_auftraggeber int


	Declare Import_Cursor_Datum Cursor For
	Select i.vd_veranst_ID, i.vd_veranst_name, i.vd_veranst_info,i.vd_veranst_von, i.vd_veranst_bis,i.vd_veranst_ort_ID ,i.vd_veranst_auftraggeber FROM inserted i

		Open Import_Cursor_Datum
			Fetch next from Import_Cursor_Datum into @vd_veranst_ID, @vd_veranst_name, @vd_veranst_info,@vd_veranst_von, @vd_veranst_bis,@vd_veranst_ort_ID, @vd_veranst_auftraggeber
			While @@FETCH_STATUS = 0
			BEGIN
				If(@vd_veranst_bis = '1900-01-01')
					BEGIN
						INSERT INTO Veranstaltungen_Daten (vd_veranst_ID,vd_veranst_name,vd_veranst_info,vd_veranst_von,vd_veranst_bis,vd_veranst_ort_ID,vd_veranst_auftraggeber)
						VALUES (@vd_veranst_ID, @vd_veranst_name, @vd_veranst_info,@vd_veranst_von, @vd_veranst_von,@vd_veranst_ort_ID,@vd_veranst_auftraggeber)
					END
				ELSE
					BEGIN
						INSERT INTO Veranstaltungen_Daten (vd_veranst_ID,vd_veranst_name,vd_veranst_info,vd_veranst_von,vd_veranst_bis,vd_veranst_ort_ID,vd_veranst_auftraggeber)
						VALUES (@vd_veranst_ID, @vd_veranst_name, @vd_veranst_info,@vd_veranst_von, @vd_veranst_bis,@vd_veranst_ort_ID,@vd_veranst_auftraggeber)
					END
						
			Fetch next from Import_Cursor_Datum into @vd_veranst_ID, @vd_veranst_name, @vd_veranst_info,@vd_veranst_von, @vd_veranst_bis,@vd_veranst_ort_ID,@vd_veranst_auftraggeber
			END
		Close Import_Cursor_Datum
	Deallocate Import_Cursor_Datum
	EXECUTE sp_refreshview N'nächste_Veranstaltung'
	
End

If  @vorgang = 'D' --or @vorgang = 'U'
Begin
	Declare Export_Cursor_Datum Cursor For
	Select d.vd_veranst_ID FROM deleted d

		Open Export_Cursor_Datum
			Fetch next from Export_Cursor_Datum into @vd_veranst_ID
			While @@FETCH_STATUS = 0
			BEGIN
				Delete from Veranstaltungen_Daten
						where vd_veranst_ID = @vd_veranst_ID
						
			Fetch next from Export_Cursor_Datum into @vd_veranst_ID
			END
		Close Export_Cursor_Datum
	Deallocate Export_Cursor_Datum
	EXECUTE sp_refreshview N'nächste_Veranstaltung'
End	

If @vorgang = 'U'
	Begin
	Declare Update_Cursor_Datum Cursor For
	Select d.vd_veranst_ID FROM deleted d

		Open Update_Cursor_Datum
			Fetch next from Update_Cursor_Datum into @vd_veranst_ID
			While @@FETCH_STATUS = 0
			BEGIN
				Delete from Veranstaltungen_Daten
						where vd_veranst_ID = @vd_veranst_ID
						
			Fetch next from Update_Cursor_Datum into @vd_veranst_ID
			END
		Close Update_Cursor_Datum
	Deallocate Update_Cursor_Datum
	
	Declare Import_Cursor_Datum Cursor For
	Select i.vd_veranst_ID, i.vd_veranst_name, i.vd_veranst_info,i.vd_veranst_von, i.vd_veranst_bis,i.vd_veranst_ort_ID ,i.vd_veranst_auftraggeber FROM inserted i

		Open Import_Cursor_Datum
			Fetch next from Import_Cursor_Datum into @vd_veranst_ID, @vd_veranst_name, @vd_veranst_info,@vd_veranst_von, @vd_veranst_bis,@vd_veranst_ort_ID, @vd_veranst_auftraggeber
			While @@FETCH_STATUS = 0
			BEGIN
				If(@vd_veranst_bis = '1900-01-01')
					BEGIN
						INSERT INTO Veranstaltungen_Daten (vd_veranst_ID,vd_veranst_name,vd_veranst_info,vd_veranst_von,vd_veranst_bis,vd_veranst_ort_ID,vd_veranst_auftraggeber)
						VALUES (@vd_veranst_ID, @vd_veranst_name, @vd_veranst_info,@vd_veranst_von, @vd_veranst_von,@vd_veranst_ort_ID,@vd_veranst_auftraggeber)
					END
				ELSE
					BEGIN
						INSERT INTO Veranstaltungen_Daten (vd_veranst_ID,vd_veranst_name,vd_veranst_info,vd_veranst_von,vd_veranst_bis,vd_veranst_ort_ID,vd_veranst_auftraggeber)
						VALUES (@vd_veranst_ID, @vd_veranst_name, @vd_veranst_info,@vd_veranst_von, @vd_veranst_bis,@vd_veranst_ort_ID,@vd_veranst_auftraggeber)
					END
						
			Fetch next from Import_Cursor_Datum into @vd_veranst_ID, @vd_veranst_name, @vd_veranst_info,@vd_veranst_von, @vd_veranst_bis,@vd_veranst_ort_ID,@vd_veranst_auftraggeber
			END
		Close Import_Cursor_Datum
	Deallocate Import_Cursor_Datum
	EXECUTE sp_refreshview N'nächste_Veranstaltung'
	
	END;
--###



--Trigger für Einnahmenaktualisierung View
--**
Go
Create Trigger Einnahmenaktualisiserung on dbo.Veranstaltungen_Einnahmen
After Insert,Update,Delete
As
Begin
Execute sp_refreshview N'Einnahmen'
End;
--###

--Trigger für Ausgabenaktualisierung View
--**
Go
Create Trigger Ausgabenaktualisierung on dbo.Veranstaltungen_Ausgaben
After Insert,Update,Delete
As
Begin
EXECUTE sp_refreshview N'Ausgaben'
End;

--###

--Besucheranzahl-> Viewaktualisierung & Import
--**
Go
CREATE TRIGGER Gäste_View_Aktualisiserung ON dbo.Gaeste_Aussteller_Veranstaltungen
After INSERT,Update,Delete
AS
BEGIN
EXECUTE sp_refreshview N'Besucheranzahl'											
END;
--##

--**
Go
CREATE TRIGGER Veranstaltungen_Sponsoren_insert on dbo.Veranstaltungen_Sponsoren
INSTEAD OF INSERT,UPDATE, DELETE
AS

SET NOCOUNT ON
	Declare @vorgang char(1)

	If (Select Count(*) from deleted) = 0
		Set @vorgang = 'I'
	Else
		If (Select COUNT(*) from inserted) = 0
		Set @vorgang = 'D'
		Else
		Set @vorgang = 'U'

If @vorgang = 'I'
Begin
	If EXISTS (Select count(ve_veranst_ID) from Veranstaltungen_Einnahmen having count(ve_veranst_ID)= null)
		   Rollback transaction
	Set NOCOUNT on;

	If Not Exists (Select * from Veranstaltungen_Einnahmen)
	Begin
		RAISERROR('Befüllen Sie erst die Tabelle Veranstaltungen_Einnahmen mit Werten',11,1)
		Rollback transaction
	END
	 	
	ELSE Declare @vsp_sponsoren_betrag money, @einnahmenkategorie int,@vsp_veranst_ID int,@vsp_sponsoren_ID int

			Declare Import_Cursor Cursor For
			Select i.vsp_sponsoren_ID,i.vsp_veranst_ID, i.vsp_sponsoren_betrag from inserted i

			Open Import_Cursor
			Fetch next from Import_Cursor into @vsp_sponsoren_ID,@vsp_veranst_ID, @vsp_sponsoren_betrag
			While @@FETCH_STATUS = 0
			BEGIN
			INSERT INTO Veranstaltungen_Sponsoren (vsp_sponsoren_ID,vsp_veranst_ID,vsp_sponsoren_betrag)
			VALUES (@vsp_sponsoren_ID,@vsp_veranst_ID,@vsp_sponsoren_betrag)
			
			
			IF	(@vsp_sponsoren_betrag > 0)
				Begin
					Begin
					SET @einnahmenkategorie = 400003
						If (Exists(Select ve_einnahmen_hoehe from Veranstaltungen_Einnahmen where ve_einnahmen_ID = @einnahmenkategorie and ve_veranst_ID = @vsp_veranst_ID))
							Begin
							Update Veranstaltungen_Einnahmen
							Set ve_einnahmen_hoehe = ve_einnahmen_hoehe + @vsp_sponsoren_betrag
							where ve_einnahmen_ID = @einnahmenkategorie and ve_veranst_ID = @vsp_veranst_ID
							End
						Else
							Begin
							INSERT INTO Veranstaltungen_Einnahmen(ve_einnahmen_ID,ve_veranst_ID,ve_einnahmen_hoehe)
							VALUES (@einnahmenkategorie,@vsp_veranst_ID,@vsp_sponsoren_betrag)
							End
						
					END
				End

			Fetch next from Import_Cursor into @vsp_sponsoren_ID,@vsp_veranst_ID,@vsp_sponsoren_betrag
			End
			Close Import_Cursor
			Deallocate Import_Cursor
EXECUTE sp_refreshview N'Sponsoringvolumentabelle'	
End

If @vorgang = 'D'
Begin
			Declare Delete_Cursor Cursor For
			Select d.vsp_sponsoren_ID, d.vsp_veranst_ID, d.vsp_sponsoren_betrag from deleted d

			Open Delete_Cursor
			Fetch next from Delete_Cursor into @vsp_sponsoren_ID,@vsp_veranst_ID, @vsp_sponsoren_betrag
			While @@FETCH_STATUS = 0
			BEGIN
			Delete from Veranstaltungen_Sponsoren 
			where vsp_sponsoren_ID = @vsp_sponsoren_ID

					SET @einnahmenkategorie = 400003

					IF ( Exists(Select @vsp_veranst_ID from deleted where @vsp_veranst_ID in (Select ve_veranst_ID from Veranstaltungen_Einnahmen )))
					Begin
					Declare @volumen int
						
						Set @volumen = (Select ve_einnahmen_hoehe from Veranstaltungen_Einnahmen where  ve_einnahmen_ID = @einnahmenkategorie and ve_veranst_ID = @vsp_veranst_ID)

						If @volumen = @vsp_sponsoren_betrag
							Begin
							Delete from Veranstaltungen_Einnahmen
							where ve_veranst_ID = @vsp_veranst_ID and ve_einnahmen_ID = @einnahmenkategorie and ve_einnahmen_hoehe = @vsp_sponsoren_betrag
							End
						Else
							Begin
							Update Veranstaltungen_Einnahmen
							Set ve_einnahmen_hoehe = @volumen - @vsp_sponsoren_betrag
							where ve_veranst_ID = @vsp_veranst_ID and ve_einnahmen_ID = @einnahmenkategorie
							END

					End
					Fetch next from Delete_Cursor into @vsp_sponsoren_ID,@vsp_veranst_ID, @vsp_sponsoren_betrag
			End
			Close Delete_Cursor
			Deallocate Delete_Cursor
					
EXECUTE sp_refreshview N'Sponsoringvolumentabelle'	
End

If @vorgang = 'U'
Begin
			Declare Update_Cursor Cursor For
			Select i.vsp_sponsoren_ID, i.vsp_veranst_ID, i.vsp_sponsoren_betrag from inserted i

			Open Update_Cursor
			Fetch next from Update_Cursor into @vsp_sponsoren_ID,@vsp_veranst_ID, @vsp_sponsoren_betrag
			While @@FETCH_STATUS = 0
			BEGIN
			Declare @summe int
			Set @summe = (Select Sum(vsp_sponsoren_betrag) from Veranstaltungen_Sponsoren where vsp_sponsoren_ID <> @vsp_sponsoren_ID and vsp_veranst_ID = @vsp_veranst_ID)
			Update Veranstaltungen_Sponsoren 
			Set vsp_sponsoren_ID =  @vsp_sponsoren_ID , vsp_veranst_ID = @vsp_veranst_ID , vsp_sponsoren_betrag = @vsp_sponsoren_betrag
			where vsp_sponsoren_ID = @vsp_sponsoren_ID and vsp_veranst_ID = vsp_veranst_ID
			
			IF	(@vsp_sponsoren_betrag >= 0)
				Begin
					Begin
					SET @einnahmenkategorie = 400003
						If (Exists(Select ve_einnahmen_hoehe from Veranstaltungen_Einnahmen where ve_einnahmen_ID = @einnahmenkategorie and ve_veranst_ID = @vsp_veranst_ID))
							Begin
							If (@summe >0)
								Begin
								Update Veranstaltungen_Einnahmen
								Set ve_einnahmen_hoehe = @summe + @vsp_sponsoren_betrag
								where ve_einnahmen_ID = @einnahmenkategorie and ve_veranst_ID = @vsp_veranst_ID
								End
							Else
								Begin
								Update Veranstaltungen_Einnahmen
								Set ve_einnahmen_hoehe = @vsp_sponsoren_betrag
								where ve_einnahmen_ID = @einnahmenkategorie and ve_veranst_ID = @vsp_veranst_ID
								End
							End
						Else
							Begin
							INSERT INTO Veranstaltungen_Einnahmen(ve_einnahmen_ID,ve_veranst_ID,ve_einnahmen_hoehe)
							VALUES (@einnahmenkategorie,@vsp_veranst_ID,@vsp_sponsoren_betrag)
							End
						
					END
				End
			Fetch next from Update_Cursor into @vsp_sponsoren_ID,@vsp_veranst_ID,@vsp_sponsoren_betrag
			End
			Close Update_Cursor
			Deallocate Update_Cursor

EXECUTE sp_refreshview N'Sponsoringvolumentabelle'

End;
--View-Definition
GO
use EVENTUS
GO
CREATE VIEW Sponsoringvolumentabelle
AS
Select vsn_sponsoren_name AS Sponsor, SUM(vsp_sponsoren_betrag) AS Sponsoringvolumen
FROM Veranstaltungen_Sponsoren INNER JOIN Veranstaltungen_Sponsoren_namen ON vsp_sponsoren_ID = vsn_sponsoren_ID
GROUP BY vsn_sponsoren_name
GO
CREATE VIEW nächste_Veranstaltung
AS
SELECT vd_veranst_ID as Veranstaltungsnummer, vd_veranst_von as Veranstaltungsbeginn
FROM Veranstaltungen_Daten
Where vd_veranst_von > GETDATE()
GO
CREATE VIEW Besucheranzahl
AS
SELECT COUNT(gav_gaeste_ID) AS Besucheranzahl,gav_veranst_ID
FROM Gaeste_Aussteller_Veranstaltungen
GROUP BY gav_veranst_ID
GO
CREATE VIEW Einnahmen
AS
SELECT vd_veranst_auftraggeber AS Auftraggeber_E, SUM(ve_einnahmen_hoehe)AS Summe_E
FROM Veranstaltungen_Daten,Veranstaltungen_Einnahmen
WHERE ve_veranst_ID = vd_veranst_ID
GROUP BY vd_veranst_auftraggeber
GO
CREATE VIEW Ausgaben
As
SELECT SUM(va_ausgaben_betrag) AS Summe,vd_veranst_auftraggeber AS Auftraggeber
FROM Veranstaltungen_Ausgaben,Veranstaltungen_Daten
WHERE va_veranst_ID = vd_veranst_ID
GROUP BY vd_veranst_auftraggeber
GO
--Upload:
use EVENTUS
INSERT INTO Veranstaltungen_Auftraggeber (vaa_auftraggeber_ID,vaa_auftraggeber_name)
VALUES	(900001,	'Deutsche Haiku-Gesellschaft e. V.'),
		(900002,	'Verband der Automobilzulieferer'),
		(900003,	'Deutscher Zahnärzte Verband e.V.'),
		(900004,	'Tierschutzverein Jena '),
		(900005,	'Industrie- und Handelskammer Erfurt'),
		(900006,	'Jenaer Nahverkehrsgesellschaft mbH'),
		(900007,	'Stadt Weimar'),
		(900008,	'Kulturstiftung Sachsen-Anhalt'),
		(900009,	'VDAT'),
		(900010,	'Alte Oper Erfurt')
INSERT INTO Veranstaltungen_Ort_Standort (vos_standort_ID,vos_standort_name)
VALUES	(150001,	'Weimar'),
		(150002,	'Erfurt'),
		(150003,	'Jena'),
		(150004,	'Sangerhausen'),
		(150005,	'Naumburg'),
		(150006,	'Arnstadt-Alkersleben'),
		(150007,	'Dresden'),
		(150008,	'Dornburg'),
		(150009,	'Gebesee'),
		(150010,	'Kranichfeld'),
		(150011,	'Isserstedt'),
		(150012,	'Berlin'),
		(150013,	'Gerstungen'),
		(150014,	'Chemnitz'),
		(150015,	'Heilbad Heiligenstadt / Landkreis Eichsfeld'),
		(150016,	'Gera'),
		(150017,	'Stadtilm'),
		(150018,	'Köln'),
		(150019,	'Attendorn'),
		(150020,	'Zorge/Südharz'),
		(150021,	'Kölleda'),
		(150022,	'Eisenach'),
		(150023,	'Geisa'),
		(150024,	'Buchenau'),
		(150025,	'Schmölln'),
		(150026,	'Oppurg'),
		(150027,	'Viernau'),
		(150028,	'Düsseldorf'),
		(150029,	'Crock'),
		(150030,	'Zella-Mehlis'),
		(150031,	'Hörselberg-Hainich'),
		(150032,	'Gotha')

INSERT INTO Veranstaltungen_Ort (vo_ort_ID,vo_standort_ID,vo_ort_name,vo_ort_info)
VALUES	(250001,	150001,	'Anna-Amalia-Bibliothek',	''),
		(250002,	150002,	'Messe',	''),
		(250003,	150003,	'Friedrich-Schiller-Universität',	'Campus-Gebäude'),
		(250004,	150003,	'Best Western Hotel',	''),
		(250005,	150002,	'Innenstadt',	''),
		(250006,	150003,	'Volkshaus',	''),
		(250007,	150001,	'Kinderland Bummi e.V.',	''),
		(250008,	150004,	'Mammuthalle',	''),
		(250009,	150005,	'Marien-Magdalen Kirche',	''),
		(250010,	150001,	'',	''),
		(250011,	150002,	'Alte Oper',	''),
		(250012,	150006, 'Flugplatz','')
				
INSERT INTO Veranstaltungen_Daten (vd_veranst_ID,vd_veranst_name,vd_veranst_info,vd_veranst_von,vd_veranst_bis, vd_veranst_ort_ID, vd_veranst_auftraggeber)
Values		(1,	'22. Haiku-Symposium',	'',	'2014-03-22','',250001,		900001),
			(2,	'23. Haiku-Symposium',	'',	'2015-03-04','',250001		,900001),
			(3,	'6. AutomobilzuliefererTage',	'',	'2013-01-14',	'2013-01-15', 250002,	900002),
			(4,	'7. AutomobilzuliefererTage',	'',	'2014-01-23',	'2014-01-24',250002 ,	900002),
			(5,	'8. AutomobilzuliefererTage',	'',	'2015-01-09',	'2015-01-10',250002 ,	900002),
			(6,	'9. AutomobilzuliefererTage',	'',	'2014-03-04',	'2016-03-05',250002 ,900002	),
			(7,	'Dental 2014',	'Tagung mitteldeutscher Zahnärzte ',	'2014-09-27',	'2014-09-27',250003,	900003),
			(8,	'Dental 2016',	'',	'2014-09-19',	'2016-09-20', 250003 ,900003	),
			(9,	'Ein Herz für Tiere',	'Gala',	'2014-02-14','',250004 ,		900004),
			(10,	'Firmenlauf 2015',	'',	'2015-09-25','',250005 ,		900005),
			(11,	'Firmenlauf 2016',	'',	'2016-09-30','',250005,		900005),
			(12,	'JeNAH Jubiläum',	'Festbankett',	'2016-04-01','', 250006,		900006),
			(13,	'JeNAH Jubiläum',	'Marktplatzfest',	'2016-04-01','',250006,		900006),
			(14,	'Kinderzirkus Weimar',	'',	'2015-06-01','', 250007,		900007),
			(15,	'Klassik für jedermann ',	'Konzertabend',	'2015-05-08','', 250008,		900008),
			(16,	'Krimiabend ',	'',	'2016-03-20','', 250009,		900008),
			(17,	'Museumsnacht Weimar ',	'',	'2015-06-10','', 250010,		900007),
			(18,	'Museumsnacht Weimar ',	'',	'2016-06-05','', 250010,		900007),
			(19,	'Speeddays',	'',	'2016-10-01','', 250012,		900009),
			(20,	'Winterball',	'',	'2015-02-18','', 250011,		900010)


INSERT INTO Veranstaltungen_Showact_Kategorie (vsk_kategorie_ID,vsk_kategorie_name)
VALUES	(100001,	'Auftaktredner'),
		(100002,	'Moderation'),
		(100003,	'Trommlergruppe'),
		(100004,	'Band'),
		(100005,	'Chor'),
		(100006,	'Abba-Coverband'),
		(100007,	'Showtanzgruppe'),
		(100008,	'Feuershow'),
		(100009,	'Oberbürgermeister Jena'),
		(100010,	'Kaninchendompteur'),
		(100011,	'Trapez'),
		(100012,	'Krimiautorin'),
		(100013,	'Krimiautor'),
		(100014,	'Kriminalhauptkomissar'),
		(100015,	'Klangkunst'),
		(100016,	'Jazzkombo'),
		(100017,	'Poetry Slam'),
		(100018,	'Sprecher'),
		(100019,	'Klassik'),
		(100020,	'DJ'),
		(100021,	'Orchester'),
		(100022,	'Streichquartett'),
		(100023,	'Jazzorchester')


INSERT INTO Veranstaltungen_Showacts (vs_showact_ID,vs_titel,vs_vorname,vs_name,vs_firma,vs_kategorie_ID)
VALUES	(50001,	'',	'Ralf',	'Ruprecht',	'Volkswagen AG',	100001),
		(50002,	'',	'',	'Pianissimo',	'',	100022),
		(50003,	'',	'Matthias',	'Jürgens',	'BMW Group München',	100001),
		(50004,	'',	'',	'Jazzorchester Mannheim',	'',	100023),
		(50005,	'Prof.',	'Georg',	'Rimmel',	'',	100001),
		(50006,	'',	'Ronald',	'Treller',	'',	100002),
		(50007,	'',	'Rene',	'Lindner',	'',	100002),
		(50008,	'',	'',	'Akuwaba',	'',	100003),
		(50009,	'',	'',	'Voice "n" Fun',	'',	100004),
		(50010,	'',	'',	'Augustiner Vicalkreis',	'',	100005),
		(50011,	'',	'Tim',	'Tölke',	'',	100002),
		(50012,	'',	'Albrecht',	'Schröter',	'',	100009),
		(50013,	'',	'',	'Abba99',	'',	100006),
		(50014,	'',	'',	'Diamonds',	'',	100007),
		(50015,	'',	'Nathalie',	'Reimann',	'',	100008),
		(50016,	'',	'Peter',	'Jacobi',	'',	100010),
		(50017,	'',	'Familie',	'Altmann',	'',	100011),
		(50018,	'',	'',	'MDR Orchester',	'',	100021),
		(50019,	'',	'Anna-Maria',	'Schenkel',	'',	100012),
		(50020,	'',	'Martin',	'Meisner',	'',	100013),
		(50021,	'',	'Peter',	'Decker',	'',	100014),
		(50022,	'',	'Erwin',	'Roth',	'',	100015),
		(50023,	'',	'',	'Blue Moon',	'',	100016),
		(50024,	'',	'Bas',	'Böttcher',	'',	100017),
		(50025,	'',	'',	'FolklOHR',	'',	100004),
		(50026,	'',	'Ben',	'Becker',	'',	100018),
		(50027,	'',	'',	'Amsterdam Klezmer',	'',	100004),
		(50028,	'',	'',	'StreichZart',	'',	100019),
		(50029,	'',	'Dieter',	'Zucker',	'',	100002),
		(50030,	'',	'Voker',	'Ziemann',	'',	100020)

INSERT INTO Veranstaltungen_Daten_Showacts (vds_veranst_ID,vds_showact_ID)
VALUES	(4,	50001),
		(4,	50002),
		(5,	50003),
		(5,	50004),
		(7,	50005),
		(7,	50006),
		(10,	50007),
		(10,	50008),
		(11,	50007),
		(11,	50009),
		(11,	50010),
		(12,	50011),
		(12,	50012),
		(12,	50002),
		(13,	50011),
		(13,	50012),
		(13,	50013),
		(13,	50014),
		(14,	50015),
		(14,	50016),
		(14,	50017),
		(15,	50018),
		(16,	50019),
		(16,	50020),
		(16,	50021),
		(17,	50022),
		(17,	50023),
		(17,	50024),
		(17,	50025),
		(18,	50022),
		(18,	50026),
		(18,	50027),
		(18,	50028),
		(19,	50029),
		(19,	50030)

INSERT INTO Veranstaltungen_Einnahmen_Kategorie (vek_kategorie_ID,vek_kategorie_name)
VALUES	(400001,	'Aussteller'),
		(400002,	'Eintrittsgelder'),
		(400003,	'Sponsoren'),
		(400004,	'Mitgliedsbeiträge'),
		(400005,	'Startgelder'),
		(400006,	'Rennlizenzen')


INSERT INTO Veranstaltungen_Einnahmen (ve_einnahmen_ID,ve_veranst_ID,ve_einnahmen_hoehe)
VALUES	(400001,	3,	7500),
		(400002,	3,	3200),
		(400003,	3,	4000),
		(400001,	4,	7500),
		(400002,	4,	3200),
		(400003,	4,	2500),
		(400001,	5,	7800),
		(400002,	5,	3250),
		(400003,	5,	3000),
		(400004,	7,	4300),
		(400003,	7,	800),
		(400003,	10,	3000),
		(400005,	10,	1800),
		(400003,	11,	3700),
		(400005,	11,	2000),
		(400003,	12,	1000),
		(400003,	13,	2000),
		(400002,	14,	300),
		(400003,	14,	2000),
		(400002,	15,	1500),
		(400003,	15,	200),
		(400002,	17,	5200),
		(400003,	17,	3000),
		(400002,	18,	5000),
		(400003,	18,	3500),
		(400002,	19,	5000),
		(400003,	19,	13000),
		(400006,	19,	2500)


INSERT INTO Veranstaltungen_Ausgaben_Kategorien (vak_ausgaben_ID,vak_ausgaben_name)
VALUES	(500001,	'Catering'),
		(500002,	'Räumlichkeiten'),
		(500003,	'Messebau'),
		(500004,	'Redner'),
		(500005,	'Showact'),
		(500006,	'Streckenposten'),
		(500007,	'Preisgelder'),
		(500008,	'Miete'),
		(500009,	'Dinner'),
		(500010,	'Verpflegungsgutscheine'),
		(500011,	'Werbung'),
		(500012,	'Sicherheitsdienstleistung'),
		(500013,	'Sonstige'),
		(500014,	'Personalvermittlung'),
		(500015,	'Veranstaltungstechnik'),
		(500016,	'Castingagentur')

INSERT INTO Veranstaltungen_Ausgaben (va_ausgaben_ID,va_veranst_ID,va_ausgaben_betrag)
VALUES	(500001,	1,	2835),
		(500001,	2,	3000),
		(500001,	3,	2000),
		(500002,	3,	4500),
		(500003,	3,	5000),
		(500001,	4,	4000),
		(500002,	4,	4700),
		(500003,	4,	6000),
		(500001,	5,	4000),
		(500002,	5,	4700),
		(500003,	5,	7000),
		(500001,	7,	2000),
		(500002,	7,	2500),
		(500004,	7,	500),
		(500005,	10,	1000),
		(500006,	10,	2800),
		(500007,	10,	1000),
		(500005,	11,	2600),
		(500006,	11,	2000),
		(500007,	11,	1000),
		(500008,	12,	1750),
		(500009,	12,	3000),
		(500005,	13,	5000),
		(500010,	13,	3000),
		(500005,	14,	2000),
		(500011,	14,	500),
		(500005,	15,	2000),
		(500005,	17,	4000),
		(500011,	17,	2500),
		(500005,	18,	4600),
		(500011,	18,	3000),
		(500008,	19,	9400),
		(500012,	19,	4000),
		(500007,	19,	5000)


INSERT INTO Veranstaltungen_Sponsoren_namen (vsn_sponsoren_ID,vsn_sponsoren_name)
VALUES	(750001,	'Bertelsmann-Stiftung'),
		(750002,	'Deutsche-Industriebank'),
		(750003,	'demedis dental depot GmbH'),
		(750004,	'Intersport'),
		(750005,	'Statdwerke Erfurt'),
		(750006,	'Siemens'),
		(750007,	'Alstom Transport Deutschland'),
		(750008,	'Sparkasse Jena-Saale-Holzland'),
		(750009,	'Sparkasse Weimar'),
		(750010,	'Stadtwerke Weimar'),
		(750011,	'Creativ Lederwaren-Manufaktur'),
		(750012,	'Rieger Tuning'),
		(750013,	'Thüringer Allgemeine'),
		(750014,	'Oettinger Brauerei GmbH')


INSERT INTO Veranstaltungen_Sponsoren (vsp_sponsoren_ID,vsp_veranst_ID,vsp_sponsoren_betrag)
VALUES	(750001,	1,	1800),
		(750002,	2,	1800),
		(750002,	3,	4000),
		(750002,	4,	2500),
		(750002,	5,	3000),
		(750003,	7,	800),
		(750004,	10,	3000),
		(750004,	11,	2200),
		(750005,	11,	500),
		(750006,	11,	1000),
		(750007,	12,	1000),
		(750007,	13,	1000),
		(750008,	13,	1000),
		(750009,	14,	1500),
		(750010,	14,	500),
		(750011,15,	200),
		(750009,	17,	2000),
		(750001,	17,	1000),
		(750009,	18,	2500),
		(750001,	18,	1000),
		(750007,	19,	10000),
		(750012,	19,	3000),
		(750013,	20,	''),
		(750014,	20,	''),
		(750001,	20,	1800)

		--Upload:

INSERT INTO Lieferanten_Dienstleister_Daten (lfdd_lieferanten_ID,lfdd_lieferanten_name,lfdd_lieferanten_straße,lfdd_lieferanten_hsnr,lfdd_lieferanten_plz,lfdd_lieferanten_ort,lfdd_lieferanten_bereich)
VALUES	(1000001,	'Bacura',	'Hasenwende',	'6',	'99089',	150002,	500012),
		(1000002,	'BlauMond GmbH',	'Theresienstr.',	'29',	'01097',	150007,	500014),
		(1000003,	'Cafe Lobenstein ',	'Damaschkestr.',	'18',	'99096',	150002,	500001),
		(1000004,	'CCS - Catering Consulting und Service GmbH',	'Alfred-Hess-Str.',	'32a',	'99094',	150002,	500001),
		(1000005,	'Gottschlings Speise-Manufaktur',	'Bahnhofsstr.',	'27',	'',null,	500001),
		(1000006,	'Kreativ-Etage ',	'Goetheplatz',	'9b',	'99423',	150001,	500011),
		(1000007,	'LIVE ',	'Scheunenweg',	'1',	'99189',	150009,	500015),
		(1000008,	'MB Messeconcept ',	'Am Bahnhof',	'5',	'99448',	150010,	500003),
		(1000009,	'Mill Messebau und Montageservice GmbH',	'Markt',	'2',	'07778',	150008,	500003),
		(1000010,	'Partyservice Gourmet',	'Albrechtstr.',	'24',	'99092',	150002,	500001),
		(1000011,	'starboxx ',	'Kopenhagener Str.',	'71',	'10437',	150012,	500016),
		(1000012,	'Thüringer Hüpfburgverleih und Promotionservice',	'Heinrich-Credner Str.',	'12',	'99087',	150002,	500005),
		(1000013,	'Webdesign AW',	'Washingtonstr.',	'19a',	'99423',	150001,	500011),
		(1000014,	'Werbedruck Staub GmbH',	'Iderhoffstr.',	'12',	'99085',	150002,	500011),
		(1000015,	'World of Taste',	'Hauptstr.',	'34',	'07751',	150011,	500001)



INSERT INTO Lieferanten_Veranstaltungen (lv_lieferanten_ID,lv_veranst_ID)
VALUES	(1000001,	19),
		(1000004,	5),
		(1000004,	4),
		(1000004,	8),
		(1000005,	15),
		(1000006,	17),
		(1000007,	13),
		(1000008,	5),
		(1000008,	4),
		(1000008,	3),
		(1000010,	3),
		(1000012,	13),
		(1000013,	18),
		(1000014,	14),
		(1000015,	12),
		(1000015,	13)


--Upload:

INSERT INTO Gaeste_Aussteller_Daten (gad_gaeste_ID,gad_gaeste_vname,gad_gaeste_nname,gad_gaeste_str,gad_gaeste_hsnr,gad_gaeste_plz,gad_gaeste_ort_ID,gad_gaeste_email,gad_gaeste_telnr,gad_gaeste_vip)
VALUES	(2000001,	'',	'ae group ag',	'Am Kreuzweg',	'',	'99834',	150013,	'',	'',	'Nein'),
(2000002,	'',	'AGA Zerspanungstechnik Gera GmbH',	'Hermsdorf',	'31A',	'',	150016,	'',	'',	'Nein'),
(2000003,	'Andrea und Frank',	'Bühler',	'',	'',	'',	null,	'andrea.frank@web.de',	'',	'Nein'),
(2000004,	'Andrea',	'Grün',	'',	'',	'',	null,	'a.grün@lol.de',	'',	'Nein'),
(2000005,	'Andreas',	'Mahder',	'',	'',	'',	null,	'andreas.mahder@jenah.de',	'',	'Nein'),
(2000006,	'Andreas und Angelika',	'Ambrus',	'',	'',	'',	null,	'ambrus@lol.de',	'',	'Nein'),
(2000007,	'',	'ARC Solutions GmbH',	'Annaberger Straße',	'73',	'09111',	150014,	'',	'',	'Nein'),
(2000008,	'Astrid und Jürgen',	'Artelt',	'',	'',	'',	null,	'ja.artelt@lol.de',	'',	'Nein'),
(2000009,	'Astrid',	'Meyer',	'',	'',	'',	null,	'',	'03641/956709',	'Nein'),
(2000010,	'Christian',	'Tauscher',	'',	'',	'',	null,	'chris-tauscher@gmx.net',	'',	'Nein'),
(2000011,	'Christine und Martin ',	'Lieberknecht',	'Regierungsstraße',	'73',	'99084',	150002,	'',	'',	'Ja'),
(2000012,	'Daniel ',	'Gachstatter',	'',	'',	'',	null,	'd.gachstatter@yahoo.com',	'',	'Nein'),
(2000013,	'Dieter',	'Althaus',	'',	'',	'37308',	150015,	'',	'',	'Ja'),
(2000014,	'',	'Eichsfelder Schraubenwerk GmbH',	'Rengelröder Weg',	'13',	'37308',	150015,	'',	'',	'Nein'),
(2000015,	'Eva ',	'Padberg',	'',	'',	'',	null,	'alexandra.leis@performanceplus.de',	'',	'Ja'),
(2000016,	'Gabriele',	'Röthemeyer',	'',	'',	'',	null,	'g.röthemeyer@lol.de',	'',	'Nein'),
(2000017,	'',	'GEWES - Gelenkwellenwerk Stadtilm GmbH',	'Weimarische Straße ',	'56',	'99326',	150017,	'',	'',	'Nein'),
(2000018,	'Heike ',	'Drechsler',	'Lichtstraße',	'49',	'50825',	150018,	'info@neblung.net',	'',	'Ja'),
(2000019,	'Iris-Uta',	'Preiss',	'',	'',	'',	null,	'iris.preis@jenah.de',	'',	'Nein'),
(2000020,	'Julia',	'Schiemann',	'',	'',	'',	null,	'frau-schielmann@web.de',	'',	'Nein'),
(2000021,	'Jürgen',	'Merkle',	'',	'',	'',	null,	'jürgen.merkle@jenah.de',	'',	'Nein'),
(2000022,	'Kati ',	'Wilhelm',	'',	'',	'',	null,	'kati@kati-wilhelm.de ',	'',	'Ja'),
(2000023,	'',	'KIRCHHOFF Automotive Deutschland GmbH',	'Am Eckenbach',	'10-14',	'57439',	150019,	'',	'',	'Nein'),
(2000024,	'Kurt',	'Goldfuss',	'',	'',	'',	null,	'goldmarie@web.de',	'',	'Nein'),
(2000025,	'Marcel',	'Dickenbrock',	'',	'',	'',	null,	'guppi63@aol.com',	'',	'Nein'),
(2000026,	'Marleen',	'Kinzer',	'Am Planetarium',	'9',	'07743',	150003,	'',	'',	'Nein'),
(2000027,	'Matthias',	'Spang',	'',	'',	'',	null,	'matze.spang@yahoo.com',	'',	'Nein'),
(2000028,	'',	'Maximator GmbH',	'Walkenrieder Str.',	'15',	'37449',	150020,	'info@maximator.de',	'',	'Nein'),
(2000029,	'',	'MDC Power GmbH',	'Rudolf-Caracciola-Strasse ',	'1',	'99625',	150021,	'',	'',	'Nein'),
(2000030,	'',	'MITEC Automotive AG',	'Rennbahn',	'25',	'99817',	150022,	'',	'',	'Nein'),
(2000031,	'',	'Möller Messtechnik',	'Rasdorfer Straße',	'22',	'36419',	150023,	'',	'',	'Nein'),
(2000032,	'',	'MSC Europe GmbH',	'Solvay-Straße ',	'2',	'99826',	150024,	'',	'',	'Nein'),
(2000033,	'',	'Neumayer Schmölln GmbH',	'Zum Wasserturm',	'79',	'04626',	150025,	'',	'',	'Nein'),
(2000034,	'Nico ',	'Beyerle',	'',	'',	'',	null,	'beyerle@net.com',	'',	'Nein'),
(2000035,	'',	'OSK-Kiefer GmbH - Oberflächen & Strahltechnik',	'An dem unteren Kreuzstück ',	'10',	'07381',	150026,	'',	'',	'Nein'),
(2000036,	'',	'PAATZ Viernau GmbH',	'Hergeser Weg',	'1',	'',	150027,	'',	'',	'Nein'),
(2000037,	'',	'Penske Logistics Europe B.V.',	'Prinzenallee',	'7',	'40549',	150028,	'',	'',	'Nein'),
(2000038,	'Peter',	'Robitzsch',	'Stauffenbergstraße',	'47',	'07747',	150003,	'',	'',	'Nein'),
(2000039,	'Peter',	'Wagner',	'',	'',	'',	null,	'petewagner@wagnershome.com',	'',	'Nein'),
(2000040,	'',	'Polycomb GmbH',	'Klaus-Äpfelbach-Str.',	'5',	'98673',	150029,	'',	'',	'Nein'),
(2000041,	'',	'PORTEC GmbH',	'Am Köhlersgehäu',	'32',	'98544',	150030,	'',	'',	'Nein'),
(2000042,	'',	'Promera Jena Feinschneid- und Umformtechnik GmbH',	'Löbstedter Straße',	'85',	'07749',	150003,	'',	'',	'Nein'),
(2000043,	'Ralf',	'Dickenbrock',	'',	'',	'',	null,	'RalfderDicke@aol.de',	'',	'Nein'),
(2000044,	'Robert',	'Engel',	'',	'',	'',	null,	'engel76@web.de',	'',	'Nein'),
(2000045,	'Rolf',	'Seebich',	'',	'',	'',	null,	'',	'03641/956711',	'Nein'),
(2000046,	'Ronny',	'Makowsky',	'',	'',	'',	null,	'',	'03641/773861',	'Nein'),
(2000047,	'Steffen',	'Springer',	'',	'',	'',	null,	'springer87@lol.de',	'',	'Nein'),
(2000048,	'Tanino',	'Bellanca',	'',	'',	'',	null,	'belltanino@net.com',	'',	'Nein'),
(2000049,	'',	'TESONA GmbH & Co. KG',	'Am Künkelhof',	'4',	'99820',	150031,	'',	'',	'Nein'),
(2000050,	'',	'Thüringer Fahrsicherheitszentrum OHG',	'Am Ofenstein',	'',	'99817',	150022,	'',	'',	'Nein'),
(2000051,	'Torsten',	'Koch',	'',	'',	'',	null,	'',	'03641/753711',	'Nein'),
(2000052,	'Ulrich',	'Ostarhild',	'',	'',	'',	null,	'ostarhild@alstom.de',	'',	'Nein'),
(2000053,	'Uschi',	'Freynick',	'',	'',	'',	null,	'uschi-freynick@lol.de',	'',	'Nein'),
(2000054,	'Uwe',	'Luckscheiter',	'',	'',	'',	null,	'luckscheiter@alstom.de',	'',	'Nein'),
(2000055,	'Volker',	'Hildner',	'',	'',	'',	null,	'volker.hildner@web.de',	'',	'Nein'),
(2000056,	'',	'WISAG Produktionsservice GmbH',	'Harijesstr.',	'2',	'99867',	150032,	'',	'',	'Nein'),
(2000057,	'Wolfgang',	'Schmidt-Dahlberg',	'',	'',	'',	null,	'schmidt.dahlberg@gmx.net',	'',	'Nein')


INSERT INTO Gaeste_Aussteller_Veranstaltungen (gav_gaeste_ID,gav_veranst_ID)
VALUES	(2000001,	4),
		(2000002,	5),
		(2000002,	4),
		(2000002,	3),
		(2000003,	12),
		(2000004,	12),
		(2000005,	12),
		(2000006,	12),
		(2000007,	3),
		(2000008,	12),
		(2000009,	12),
		(2000010,	12),
		(2000011,	20),
		(2000012,	12),
		(2000013,	20),
		(2000014,	5),
		(2000014,	3),
		(2000015,	20),
		(2000016,	12),
		(2000017,	4),
		(2000017,	6),
		(2000018,	12),
		(2000019,	12),
		(2000020,	12),
		(2000021,	12),
		(2000022,	12),
		(2000023,	5),
		(2000023,	4),
		(2000024,	12),
		(2000025,	12),
		(2000026,	12),
		(2000027,	12),
		(2000028,	5),
		(2000028,	4),
		(2000028,	3),
		(2000029,	4),
		(2000029,	6),
		(2000030,	5),
		(2000031,	5),
		(2000031,	4),
		(2000031,	3),
		(2000032,	4),
		(2000032,	3),
		(2000032,	6),
		(2000033,	4),
		(2000034,	12),
		(2000035,	5),
		(2000035,	4),
		(2000035,	3),
		(2000036,	3),
		(2000037,	3),
		(2000038,	12),
		(2000039,	12),
		(2000040,	4),
		(2000040,	3),
		(2000041,	5),
		(2000042,	4),
		(2000043,	12),
		(2000044,	12),
		(2000045,	12),
		(2000046,	12),
		(2000047,	12),
		(2000048,	12),
		(2000049,	3),
		(2000049,	6),
		(2000050,	5),
		(2000050,	5),
		(2000051,	12),
		(2000052,	12),
		(2000053,	12),
		(2000054,	12),
		(2000055,	12),
		(2000056,	3),
		(2000057,	12)

--Upload:

INSERT INTO Mitarbeiter_Positionen (map_position_ID,map_position_name)
VALUES	(3100001,	'Projektleitung'),
		(3100002,	'Werksstudent'),
		(3100003,	'Assistenz der Geschäftsführung'),
		(3100004,	'Geschäftsführung' ),
		(3100005,	'Akquise')

INSERT INTO Mitarbeiter_Daten (mad_mitarbeiter_ID,mad_mitarbeiter_vname,mad_mitarbeiter_nname,mad_position_ID,mad_mitarbeiter_stunden,mad_mitarbeiter_von,mad_mitarbeiter_bis,mad_mitarbeiter_jahresgehalt,mad_mitarbeiter_monatsgehalt)
VALUES	(3000001,	'Daniela',	'Hoffmann',	3100001,	'20h',	'2011-01-01','2020-12-31',	23100,	''),
		(3000002,	'Danilo',	'Hoffmann',	3100002,	'10h',	'2010-03-15',	'2010-09-30',	'',	400),
		(3000003,	'Gustav ',	'Richter',	3100002,	'10h',	'2011-10-01','2020-12-31',		'',	400),
		(3000004,	'Janina',	'Hagenreiter',	3100003,	'24h',	'2010-04-01',	'2010-12-31',	15400,	''),
		(3000005,	'Mareike',	'Adam',	3100001,	'20h',	'2011-01-01',	'2020-12-31',	23200,	''),
		(3000006,	'Nadine',	'Reimer',	3100002,	'15h',	'2010-10-01','2020-12-31',		'',	400),
		(3000007,	'Paula',	'Schmidt',	3100004,	'40h',	'2010-01-01',	'2020-12-31',	40800,	''),
		(3000008,	'Peggy',	'Richter',	3100003,	'20h',	'2011-01-01',	'2020-12-31',	12800,	''),
		(3000009,	'Volker',	'Reinhart',	3100005,	'freie Mitarbeit',	'2010-01-01','2020-12-31',		'',	'')

INSERT INTO Mitarbeiter_Veranstaltungen (mav_veranst_ID,mav_mitarbeiter_ID)
VALUES	(1,	3000005),
		(2,	3000005),
		(3,	3000001),
		(3,	3000003),
		(4,	3000001),
		(4,	3000006),
		(5,	3000001),
		(5,	3000005),
		(5,	3000006),
		(7,	3000007),
		(9,	3000005),
		(10,3000001),
		(10,3000003),
		(11,3000001),
		(12,3000001),
		(13,3000007),
		(14,3000005),
		(15,3000007),
		(16,3000007),
		(17,3000007),
		(18,3000007),
		(19,3000005),
		(20,3000001),
		(20,3000006)
use EVENTUS
--user add

CREATE LOGIN EVDH01 WITH PASSWORD = 'EVDH01';
CREATE LOGIN EVDH02 WITH PASSWORD = 'EVDH02';
CREATE LOGIN EVGR03 WITH PASSWORD = 'EVGR03';
CREATE LOGIN EVJH04 WITH PASSWORD = 'EVJH04';
CREATE LOGIN EVMA05 WITH PASSWORD = 'EVMA05';
CREATE LOGIN EVNR06 WITH PASSWORD = 'EVNR06';
CREATE LOGIN EVPS07 WITH PASSWORD = 'EVPS07';
CREATE LOGIN EVPR08 WITH PASSWORD = 'EVPR08';
CREATE LOGIN EVVR09 WITH PASSWORD = 'EVVR09';
USE EVENTUS;
GO
CREATE USER Daniela_Hoffmann FOR LOGIN EVDH01;
CREATE USER Danilo_Hoffmann FOR LOGIN EVDH02;
CREATE USER Gustav_Richter FOR LOGIN EVGR03;
CREATE USER Janina_Hagenreiter FOR LOGIN EVJH04;
CREATE USER Mareike_Adam FOR LOGIN EVMA05;
CREATE USER Nadine_Reimer FOR LOGIN EVNR06;
CREATE USER Paula_Schmidt FOR LOGIN EVPS07;
CREATE USER Peggy_Richter FOR LOGIN EVPR08;
CREATE USER Volker_Reinhart FOR LOGIN EVVR09;
GO
EXEC sp_addsrvrolemember @loginame = N'EVVR09', @rolename = N'sysadmin'
GO


--Rechte für einzelne Tabellen vergeben
use EVENTUS
CREATE ROLE Projektleitung
Go
ALTER ROLE Projektleitung ADD MEMBER Daniela_Hoffmann
ALTER ROLE Projektleitung ADD MEMBER Mareike_Adam
GO
CREATE ROLE Assistenz 
ALTER ROLE Assistenz ADD MEMBER Janina_Hagenreiter
ALTER ROLE Assistenz ADD MEMBER Peggy_Richter
GO
CREATE ROLE Geschäftsführung
ALTER ROLE Geschäftsführung ADD MEMBER Paula_Schmidt
GO
CREATE ROLE Werkstudenten 
ALTER ROLE Werkstudenten ADD MEMBER Danilo_Hoffmann
ALTER ROLE Werkstudenten ADD MEMBER Gustav_Richter
ALTER ROLE Werkstudenten ADD MEMBER Nadine_Reimer
--Veranstaltungen Auftraggeber
GRANT UPDATE ON [dbo].[Veranstaltungen_Auftraggeber] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Veranstaltungen_Auftraggeber TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Veranstaltungen_Auftraggeber TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Veranstaltungen_Auftraggeber TO Projektleitung,Assistenz,Geschäftsführung

--Veranstaltungen Daten
GRANT UPDATE ON [dbo].[Veranstaltungen_Daten] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Veranstaltungen_Daten TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Veranstaltungen_Daten TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Veranstaltungen_Daten TO Projektleitung,Assistenz,Geschäftsführung

--Veranstaltungen_Showact_Kategorie
GRANT UPDATE ON [dbo].[Veranstaltungen_Showact_Kategorie] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Veranstaltungen_Showact_Kategorie TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Veranstaltungen_Showact_Kategorie TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Veranstaltungen_Showact_Kategorie TO Projektleitung,Assistenz,Geschäftsführung
--Veranstaltungen_Showacts
GRANT UPDATE ON [dbo].[Veranstaltungen_Showacts] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Veranstaltungen_Showacts TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Veranstaltungen_Showacts TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Veranstaltungen_Showacts TO Projektleitung,Assistenz,Geschäftsführung
--Veranstaltungen_Daten_Showacts
GRANT UPDATE ON [dbo].[Veranstaltungen_Daten_Showacts] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Veranstaltungen_Daten_Showacts TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Veranstaltungen_Daten_Showacts TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Veranstaltungen_Daten_Showacts TO Projektleitung,Assistenz,Geschäftsführung
--Veranstaltungen_Ort_Standort
GRANT UPDATE ON [dbo].[Veranstaltungen_Ort_Standort] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Veranstaltungen_Ort_Standort TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Veranstaltungen_Ort_Standort TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Veranstaltungen_Ort_Standort TO Projektleitung,Assistenz,Geschäftsführung
--Veranstaltungen_Ort
GRANT UPDATE ON [dbo].[Veranstaltungen_Ort] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Veranstaltungen_Ort TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Veranstaltungen_Ort TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Veranstaltungen_Ort TO Projektleitung,Assistenz,Geschäftsführung
--Veranstaltungen_Einnahmen_Kategorie
GRANT UPDATE ON [dbo].[Veranstaltungen_Einnahmen_Kategorie] TO Assistenz
GRANT SELECT ON dbo.Veranstaltungen_Einnahmen_Kategorie TO Assistenz,Geschäftsführung,Projektleitung
GRANT INSERT ON dbo.Veranstaltungen_Einnahmen_Kategorie TO Assistenz
GRANT DELETE ON dbo.Veranstaltungen_Einnahmen_Kategorie TO Assistenz
--Veranstaltungen_Einnahmen
GRANT UPDATE ON [dbo].[Veranstaltungen_Einnahmen] TO Assistenz
GRANT SELECT ON dbo.Veranstaltungen_Einnahmen TO Assistenz,Geschäftsführung,Projektleitung
GRANT INSERT ON dbo.Veranstaltungen_Einnahmen TO Assistenz
GRANT DELETE ON dbo.Veranstaltungen_Einnahmen TO Assistenz
--Veranstaltungen_Ausgaben_Kategorien
GRANT UPDATE ON [dbo].[Veranstaltungen_Ausgaben_Kategorien] TO Assistenz
GRANT SELECT ON dbo.Veranstaltungen_Ausgaben_Kategorien TO Assistenz,Geschäftsführung,Projektleitung
GRANT INSERT ON dbo.Veranstaltungen_Ausgaben_Kategorien TO Assistenz
GRANT DELETE ON dbo.Veranstaltungen_Ausgaben_Kategorien TO Assistenz
--Veranstaltungen_Ausgaben
GRANT UPDATE ON [dbo].[Veranstaltungen_Ausgaben] TO Assistenz
GRANT SELECT ON dbo.Veranstaltungen_Ausgaben TO Assistenz,Geschäftsführung,Projektleitung
GRANT INSERT ON dbo.Veranstaltungen_Ausgaben TO Assistenz
GRANT DELETE ON dbo.Veranstaltungen_Ausgaben TO Assistenz
--Veranstaltungen_Sponsoren_namen
GRANT UPDATE ON [dbo].[Veranstaltungen_Sponsoren_namen] TO Assistenz
GRANT SELECT ON dbo.Veranstaltungen_Sponsoren_namen TO Assistenz,Geschäftsführung,Projektleitung,Werkstudenten
GRANT INSERT ON dbo.Veranstaltungen_Sponsoren_namen TO Assistenz
GRANT DELETE ON dbo.Veranstaltungen_Sponsoren_namen TO Assistenz
--Veranstaltungen_Sponsoren
GRANT UPDATE ON [dbo].[Veranstaltungen_Sponsoren] TO Assistenz
GRANT SELECT ON dbo.Veranstaltungen_Sponsoren TO Assistenz,Geschäftsführung,Projektleitung
GRANT INSERT ON dbo.Veranstaltungen_Sponsoren TO Assistenz
GRANT DELETE ON dbo.Veranstaltungen_Sponsoren TO Assistenz
--Lieferanten_Dienstleister_Daten
GRANT UPDATE ON [dbo].[Lieferanten_Dienstleister_Daten] TO Assistenz
GRANT SELECT ON dbo.Lieferanten_Dienstleister_Daten TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Lieferanten_Dienstleister_Daten TO Assistenz
GRANT DELETE ON dbo.Lieferanten_Dienstleister_Daten TO Assistenz
--Lieferanten_Veranstaltungen
GRANT UPDATE ON [dbo].[Lieferanten_Veranstaltungen] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Lieferanten_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Lieferanten_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Lieferanten_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung
--Gaeste_Aussteller_Daten
GRANT UPDATE ON [dbo].[Gaeste_Aussteller_Daten] TO Assistenz
GRANT SELECT ON dbo.Gaeste_Aussteller_Daten TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Gaeste_Aussteller_Daten TO Assistenz
GRANT DELETE ON dbo.Gaeste_Aussteller_Daten TO Assistenz
--Gaeste_Aussteller_Veranstaltungen
GRANT UPDATE ON [dbo].[Gaeste_Aussteller_Veranstaltungen] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Gaeste_Aussteller_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung,Werkstudenten
GRANT INSERT ON dbo.Gaeste_Aussteller_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Gaeste_Aussteller_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung
--Mitarbeiter_Positionen
GRANT UPDATE ON [dbo].[Mitarbeiter_Positionen] TO Assistenz
GRANT SELECT ON dbo.Mitarbeiter_Positionen TO Assistenz,Geschäftsführung
GRANT INSERT ON dbo.Mitarbeiter_Positionen TO Assistenz
GRANT DELETE ON dbo.Mitarbeiter_Positionen TO Assistenz
--Mitarbeiter_Daten
GRANT UPDATE ON [dbo].[Mitarbeiter_Daten] TO Assistenz
GRANT SELECT ON dbo.Mitarbeiter_Daten TO Assistenz,Geschäftsführung
GRANT INSERT ON dbo.Mitarbeiter_Daten TO Assistenz
GRANT DELETE ON dbo.Mitarbeiter_Daten TO Assistenz
--Mitarbeiter_Veranstaltungen
GRANT UPDATE ON [dbo].[Mitarbeiter_Veranstaltungen] TO Projektleitung,Assistenz,Geschäftsführung
GRANT SELECT ON dbo.Mitarbeiter_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung
GRANT INSERT ON dbo.Mitarbeiter_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung
GRANT DELETE ON dbo.Mitarbeiter_Veranstaltungen TO Projektleitung,Assistenz,Geschäftsführung