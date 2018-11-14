use Projekt_III

--Query1: Alle vergangenen Events
SELECT vd_veranst_name AS Veranstaltung, vd_veranst_von AS Anfangstermin, vd_veranst_bis AS Endtermin
FROM Veranstaltungen_Daten
WHERE GETDATE() > Veranstaltungen_Daten.vd_veranst_von And GETDATE() > Veranstaltungen_Daten.vd_veranst_bis

--Query2: Alle Sponsoren die mehr als 2* gespendet haben
SELECT vsn_sponsoren_name as Sponsor, Count(vsp_sponsoren_ID) as #Spenden
FROM Veranstaltungen_Sponsoren_namen INNER JOIN Veranstaltungen_Sponsoren on vsn_sponsoren_ID = vsp_sponsoren_ID
GROUP BY vsn_sponsoren_name,vsp_sponsoren_ID
HAVING Count(vsp_sponsoren_ID) >2

--Query3: Alle MA die Vollzeit sind
SELECT mad_mitarbeiter_ID AS Personalnummer, mad_mitarbeiter_vname AS Vorname, mad_mitarbeiter_nname AS Nachname
FROM Mitarbeiter_Daten
WHERE mad_mitarbeiter_stunden LIKE '[0-9][0-9]h' AND mad_mitarbeiter_stunden > '39h'

--Query4: Sponsor mit höchstem Sponsoringvolumen
--CREATE VIEW Sponsoringvolumentabelle
--AS
--Select vsn_sponsoren_name AS Sponsor, SUM(vsp_sponsoren_betrag) AS Sponsoringvolumen
--FROM Veranstaltungen_Sponsoren INNER JOIN Veranstaltungen_Sponsoren_namen ON vsp_sponsoren_ID = vsn_sponsoren_ID
--GROUP BY vsn_sponsoren_name

--Query4: Sponsor mit höchstem Sponsoringvolumen
SELECT Sponsor, MAX(Sponsoringvolumen) AS Sponsoringvolumen
FROM Sponsoringvolumentabelle
WHERE Sponsoringvolumen = (SELECT MAX(Sponsoringvolumen) FROM Sponsoringvolumentabelle)
GROUP BY Sponsor

--Query5: # Showacts pro Veranstaltung
SELECT vd_veranst_ID AS Veranstaltungsnummer,vd_veranst_name AS Veranstaltung, COUNT(vds_showact_ID) AS #Showacts
FROM Veranstaltungen_Daten_Showacts INNER JOIN Veranstaltungen_Daten  ON vds_veranst_ID = vd_veranst_ID
GROUP BY vd_veranst_name, vd_veranst_ID 
ORDER BY COUNT(vds_showact_ID) ASC

---Query6: Liste Reservierungen für nächstes Event
--CREATE VIEW nächste_Veranstaltung
--AS
--SELECT vd_veranst_ID as Veranstaltungsnummer, vd_veranst_von as Veranstaltungsbeginn
--FROM Veranstaltungen_Daten
--Where vd_veranst_von > GETDATE()

	---Query6: Liste Reservierungen für nächstes Event
	SELECT gav_gaeste_ID AS Gästenummer , gad_gaeste_vname AS Vorname,gad_gaeste_nname AS Name,vd_veranst_von AS Veranstaltungsbeginn, vd_veranst_bis AS Veranstaltungsende,vd_veranst_name AS Veranstaltungsname
	FROM (Gaeste_Aussteller_Veranstaltungen gav 
	inner join Gaeste_Aussteller_Daten gad ON gav.gav_gaeste_ID = gad.gad_gaeste_ID) 
	inner join Veranstaltungen_Daten vd ON gav.gav_veranst_ID = vd.vd_veranst_ID
	WHERE gav_veranst_ID = 	(	SELECT Veranstaltungsnummer
								FROM nächste_Veranstaltung
								WHERE  Veranstaltungsbeginn = (SELECT MIN(Veranstaltungsbeginn) FROM nächste_Veranstaltung))

--Query7: bester Kunde (auf Basis #Umsatzvolumen)
SELECT vaa_auftraggeber_name AS Kunde
FROM Veranstaltungen_Auftraggeber INNER JOIN Einnahmen ON vaa_auftraggeber_ID = Auftraggeber_E
WHERE Summe_E = (SELECT MAX(Summe_E) FROM Einnahmen)

--Query8: durchschnittl. Besucherzahl Veranstaltungen
--CREATE VIEW Besucheranzahl
--AS
--SELECT COUNT(gav_gaeste_ID) AS Besucheranzahl,gav_veranst_ID
--FROM Gaeste_Aussteller_Veranstaltungen
--GROUP BY gav_veranst_ID
--Query8: durchschnittl. Besucherzahl Veranstaltungen
SELECT AVG(Besucheranzahl) AS durchschnittliche_Besucheranzahl
FROM Besucheranzahl

--Query9: VIP- Zuständiger MA
SELECT DISTINCT  mad_mitarbeiter_ID AS Mitarbeiternummmer,mad_mitarbeiter_vname AS Vorname, mad_mitarbeiter_nname AS Nachname
FROM (Mitarbeiter_Daten md 
	INNER JOIN Mitarbeiter_Veranstaltungen mv 
	ON md.mad_mitarbeiter_ID = mv.mav_mitarbeiter_ID)
	INNER JOIN Gaeste_Aussteller_Veranstaltungen gav
	ON mv.mav_veranst_ID = gav.gav_veranst_ID
	INNER JOIN Gaeste_Aussteller_Daten gad
	ON gav.gav_gaeste_ID = gad.gad_gaeste_ID
 WHERE gad.gad_gaeste_vip = 'Ja'

--Query10:Veranstaltung mit dem meisten Gewinn
--CREATE VIEW Einnahmen
--AS
--SELECT vd_veranst_auftraggeber AS Auftraggeber_E, SUM(ve_einnahmen_hoehe)AS Summe_E
--FROM Veranstaltungen_Daten,Veranstaltungen_Einnahmen
--WHERE ve_veranst_ID = vd_veranst_ID
--GROUP BY vd_veranst_auftraggeber

--CREATE VIEW Ausgaben
--As
--SELECT SUM(va_ausgaben_betrag) AS Summe,vd_veranst_auftraggeber AS Auftraggeber
--FROM Veranstaltungen_Ausgaben,Veranstaltungen_Daten
--WHERE va_veranst_ID = vd_veranst_ID
--GROUP BY vd_veranst_auftraggeber
--Query10:Veranstaltung mit dem meisten Gewinn
SELECT vag.vaa_auftraggeber_name AS Kunde
FROM (Einnahmen e inner join Ausgaben a ON e.Auftraggeber_E = a.Auftraggeber)inner join Veranstaltungen_Auftraggeber vag ON e.Auftraggeber_E= vag.vaa_auftraggeber_ID
WHERE Summe_E - Summe = (SELECT MAX(Summe_E - Summe) FROM Einnahmen e inner join Ausgaben a ON e.Auftraggeber_E = a.Auftraggeber)

--Query11: Konzerte die noch keine Reservierungen haben
SELECT vd_veranst_ID AS VeranstaltungsID, vd_veranst_name AS Veranstaltung
FROM Veranstaltungen_Daten
WHERE vd_veranst_name like '%konzert%' Or vd_veranst_info like '%konzert%' And vd_veranst_ID not in (SELECT vds_veranst_ID FROM Veranstaltungen_Daten_Showacts )

--Query12: Liste aller DL inkl. Veranstaltungen
SELECT lfdd_lieferanten_name AS Lieferant_Dienstleister, vd_veranst_name AS Veranstaltung
FROM (Lieferanten_Dienstleister_Daten 
		FULL JOIN Lieferanten_Veranstaltungen 
		ON lfdd_lieferanten_ID = lv_lieferanten_ID) 
		LEFT OUTER JOIN Veranstaltungen_Daten 
		ON lv_veranst_ID = vd_veranst_ID
