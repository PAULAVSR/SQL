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
	lfdd_lieferanten_straﬂe varchar(50) not null,
	lfdd_lieferanten_hsnr varchar(10) not null,
	lfdd_lieferanten_plz varchar(5),
	lfdd_lieferanten_ort int FOREIGN KEY REFERENCES Veranstaltungen_Ort_Standort,
	lfdd_lieferanten_bereich int FOREIGN KEY REFERENCES Veranstaltungen_Ausgaben_Kategorien)

create table Lieferanten_Veranstaltungen (	
	lv_lieferanten_ID int FOREIGN KEY REFERENCES Lieferanten_Dienstleister_Daten,
	lv_veranst_ID int FOREIGN KEY REFERENCES Veranstaltungen_Daten)


--Block3: G‰ste und Aussteller

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