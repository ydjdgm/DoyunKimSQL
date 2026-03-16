DROP DATABASE projektwoche2026;
CREATE DATABASE projektwoche2026;
use projektwoche2026


CREATE TABLE klasse (
    klasseID INT PRIMARY KEY AUTO_INCREMENT,
    bezeichnung VARCHAR(100)
);

CREATE TABLE schueler (
    schuelerID INT PRIMARY KEY AUTO_INCREMENT,
    vorname VARCHAR(50),
    nachname VARCHAR(50),
    email VARCHAR(100),
    klasseID INT,
    FOREIGN KEY (klasseID) REFERENCES klasse(klasseID)
);

CREATE TABLE workshop (
    workshopID INT PRIMARY KEY AUTO_INCREMENT,
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
(NULL, 'IT-Fachinformatiker 2023'),
(NULL, 'Mediengestalter 2024'),
(NULL, 'Wirtschaftsinformatik Q1');

-- Testdaten für die Tabelle 'schueler'
INSERT INTO schueler (schuelerID, vorname, nachname, email, klasseID) VALUES
(NULL, 'Max', 'Mustermann', 'max.mustermann@schule.de', 1),
(NULL, 'Erika', 'Musterfrau', 'erika.m@web.de', 1),
(NULL, 'Leon', 'Schmidt', 'l.schmidt@gmail.com', 2),
(NULL, 'Sophie', 'Müller', 'sophie.mueller@schule.de', 3),
(NULL, 'Julian', 'Wagner', 'j.wagner@outlook.com', 2);

-- Testdaten für die Tabelle 'workshop'
INSERT INTO workshop (workshopID, nr, titel, kosten, beschreibung, voraussetzungen, teilnehmerMin, teilnehmerMax, schwerpunkt) VALUES
(NULL, 101, 'Einführung in SQL', 25.00, 'Grundlagen relationaler Datenbanken.', 'Keine', 5, 20, 'Datenbanken'),
(NULL, 102, 'Webdesign mit CSS', 40.00, 'Gestaltung moderner Webseiten.', 'HTML Grundkenntnisse', 8, 15, 'Design'),
(NULL, 103, 'Python für Anfänger', 0.00, 'Programmierung kleiner Tools.', 'Logisches Verständnis', 10, 25, 'Programmierung');