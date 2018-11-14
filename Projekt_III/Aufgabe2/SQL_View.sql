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
