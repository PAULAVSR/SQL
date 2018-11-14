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
use Projekt_III
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