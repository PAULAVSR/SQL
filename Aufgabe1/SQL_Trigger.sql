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
