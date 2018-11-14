use Projekt_III
create table xml_Veranstaltungen(
	xml_ID varchar(50) Primary Key,
	veranstaltung xml)

Insert into xml_Veranstaltungen (xml_ID, veranstaltung)
Values ('xml_1','
		<Veranstaltungen_Daten Veranstaltung="7. AutomobilzuliefererTage" Startdatum="2014-01-23" Enddatum="2014-01-24">
  <Veranstaltungen_Ort Veranstaltungsort="Messe">
    <Veranstaltungen_Ort_Standort Standort="Erfurt">
      <Veranstaltungen_Showacts Titel="" Vorname="Ralf" Name="Ruprecht" Firma="Volkswagen AG">
        <Veranstaltungen_Showact_Kategorie Kategorie="Auftaktredner" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Pianissimo" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Streichquartett" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="8. AutomobilzuliefererTage" Startdatum="2015-01-09" Enddatum="2015-01-10">
  <Veranstaltungen_Ort Veranstaltungsort="Messe">
    <Veranstaltungen_Ort_Standort Standort="Erfurt">
      <Veranstaltungen_Showacts Titel="" Vorname="Matthias" Name="Jürgens" Firma="BMW Group München">
        <Veranstaltungen_Showact_Kategorie Kategorie="Auftaktredner" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Jazzorchester Mannheim" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Jazzorchester" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Dental 2014" Startdatum="2014-09-27" Enddatum="2014-09-27">
  <Veranstaltungen_Ort Veranstaltungsort="Friedrich-Schiller-Universität">
    <Veranstaltungen_Ort_Standort Standort="Jena">
      <Veranstaltungen_Showacts Titel="Prof." Vorname="Georg" Name="Rimmel" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Auftaktredner" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Ronald" Name="Treller" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Moderation" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Firmenlauf 2015" Startdatum="2015-09-25" Enddatum="2015-09-25">
  <Veranstaltungen_Ort Veranstaltungsort="Innenstadt">
    <Veranstaltungen_Ort_Standort Standort="Naumburg">
      <Veranstaltungen_Showacts Titel="" Vorname="Rene" Name="Lindner" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Moderation" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Akuwaba" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Trommlergruppe" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Firmenlauf 2016" Startdatum="2016-09-30" Enddatum="2016-09-30">
  <Veranstaltungen_Ort Veranstaltungsort="Innenstadt">
    <Veranstaltungen_Ort_Standort Standort="Naumburg">
      <Veranstaltungen_Showacts Titel="" Vorname="Rene" Name="Lindner" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Moderation" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Voice &quot;n&quot; Fun" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Band" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Augustiner Vicalkreis" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Chor" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="JeNAH Jubiläum" Startdatum="2016-04-01" Enddatum="2016-04-01">
  <Veranstaltungen_Ort Veranstaltungsort="Volkshaus">
    <Veranstaltungen_Ort_Standort Standort="Arnstadt-Alkersleben">
      <Veranstaltungen_Showacts Titel="" Vorname="Tim" Name="Tölke" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Moderation" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Albrecht" Name="Schröter" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Oberbürgermeister Jena" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Pianissimo" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Streichquartett" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Tim" Name="Tölke" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Moderation" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Albrecht" Name="Schröter" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Oberbürgermeister Jena" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Abba99" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Abba-Coverband" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Diamonds" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Showtanzgruppe" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Kinderzirkus Weimar" Startdatum="2015-06-01" Enddatum="2015-06-01">
  <Veranstaltungen_Ort Veranstaltungsort="Kinderland Bummi e.V.">
    <Veranstaltungen_Ort_Standort Standort="Dresden">
      <Veranstaltungen_Showacts Titel="" Vorname="Nathalie" Name="Reimann" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Feuershow" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Peter" Name="Jacobi" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Kaninchendompteur" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Familie" Name="Altmann" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Trapez" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Klassik für jedermann " Startdatum="2015-05-08" Enddatum="2015-05-08">
  <Veranstaltungen_Ort Veranstaltungsort="Mammuthalle">
    <Veranstaltungen_Ort_Standort Standort="Dornburg">
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="MDR Orchester" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Orchester" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Krimiabend " Startdatum="2016-03-20" Enddatum="2016-03-20">
  <Veranstaltungen_Ort Veranstaltungsort="Marien-Magdalen Kirche">
    <Veranstaltungen_Ort_Standort Standort="Gebesee">
      <Veranstaltungen_Showacts Titel="" Vorname="Anna-Maria" Name="Schenkel" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Krimiautorin" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Martin" Name="Meisner" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Krimiautor" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Peter" Name="Decker" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Kriminalhauptkomissar" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Museumsnacht Weimar " Startdatum="2015-06-10" Enddatum="2015-06-10">
  <Veranstaltungen_Ort Veranstaltungsort="">
    <Veranstaltungen_Ort_Standort Standort="Kranichfeld">
      <Veranstaltungen_Showacts Titel="" Vorname="Erwin" Name="Roth" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Klangkunst" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Blue Moon" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Jazzkombo" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Bas" Name="Böttcher" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Poetry Slam" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="FolklOHR" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Band" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Museumsnacht Weimar " Startdatum="2016-06-05" Enddatum="2016-06-05">
  <Veranstaltungen_Ort Veranstaltungsort="">
    <Veranstaltungen_Ort_Standort Standort="Kranichfeld">
      <Veranstaltungen_Showacts Titel="" Vorname="Erwin" Name="Roth" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Klangkunst" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Ben" Name="Becker" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Sprecher" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="Amsterdam Klezmer" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Band" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="" Name="StreichZart" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Klassik" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>
<Veranstaltungen_Daten Veranstaltung="Speeddays" Startdatum="2016-10-01" Enddatum="2016-10-01">
  <Veranstaltungen_Ort Veranstaltungsort="Flugplatz">
    <Veranstaltungen_Ort_Standort Standort="Arnstadt-Alkersleben">
      <Veranstaltungen_Showacts Titel="" Vorname="Dieter" Name="Zucker" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="Moderation" />
      </Veranstaltungen_Showacts>
      <Veranstaltungen_Showacts Titel="" Vorname="Voker" Name="Ziemann" Firma="">
        <Veranstaltungen_Showact_Kategorie Kategorie="DJ" />
      </Veranstaltungen_Showacts>
    </Veranstaltungen_Ort_Standort>
  </Veranstaltungen_Ort>
</Veranstaltungen_Daten>')
