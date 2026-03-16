DROP DATABASE projektwoche2026;
CREATE DATABASE projektwoche2026;
use projektwoche2026

CREATE TABLE workshop(
    workshopID INT AUTO_INCREMENT PRIMARY KEY,
    nr INT,
    titel VARCHAR(50),
    kosten INT,
    beschreibung VARCHAR(100),
    voraussetzungen VARCHAR(100),
    teilnehmerMin INT,
    teilnehmerMax INT,
    schwerpunkt VARCHAR(100)
);

CREATE TABLE klasse (
    klasseID INT PRIMARY KEY,
    bezeichnung VARCHAR(100)
);

CREATE TABLE schueler (
    schuelerID INT PRIMARY KEY,
    vorname VARCHAR(50),
    nachname VARCHAR(50),
    email VARCHAR(100),
    klasseID INT,
    FOREIGN KEY (klasseID) REFERENCES klasse(klasseID)
);

CREATE TABLE workshop (
    workshopID INT PRIMARY KEY,
    nr INT,
    titel VARCHAR(255),
    kosten INT,
    beschreibung VARCHAR(255),
    voraussetzungen VARCHAR(255),
    teilnehmerMin INT,
    teilnehmerMax INT,
    schwerpunkt VARCHAR(100)
);

-- Testdaten für die Tabelle 'klasse'
INSERT INTO klasse (klasseID, bezeichnung) VALUES
(1, 'IT-Fachinformatiker 2023'),
(2, 'Mediengestalter 2024'),
(3, 'Wirtschaftsinformatik Q1');

-- Testdaten für die Tabelle 'schueler'
INSERT INTO schueler (schuelerID, vorname, nachname, email, klasseID) VALUES
(1, 'Max', 'Mustermann', 'max.mustermann@schule.de', 1),
(2, 'Erika', 'Musterfrau', 'erika.m@web.de', 1),
(3, 'Leon', 'Schmidt', 'l.schmidt@gmail.com', 2),
(4, 'Sophie', 'Müller', 'sophie.mueller@schule.de', 3),
(5, 'Julian', 'Wagner', 'j.wagner@outlook.com', 2);

-- Testdaten für die Tabelle 'workshop'
INSERT INTO workshop (workshopID, nr, titel, kosten, beschreibung, voraussetzungen, teilnehmerMin, teilnehmerMax, schwerpunkt) VALUES
(1, 101, 'Einführung in SQL', 25.00, 'Grundlagen relationaler Datenbanken.', 'Keine', 5, 20, 'Datenbanken'),
(2, 102, 'Webdesign mit CSS', 40.00, 'Gestaltung moderner Webseiten.', 'HTML Grundkenntnisse', 8, 15, 'Design'),
(3, 103, 'Python für Anfänger', 0.00, 'Programmierung kleiner Tools.', 'Logisches Verständnis', 10, 25, 'Programmierung');