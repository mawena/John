-- Active: 1672136555693@@127.0.0.1@3306@john

DROP DATABASE IF EXISTS John;

CREATE DATABASE John;

use John;

DROP TABLE IF EXISTS Employees;

CREATE TABLE
    Employees(
        id int PRIMARY KEY AUTO_INCREMENT,
        last_name VARCHAR(30) NOT NULL,
        first_name VARCHAR(150) NOT NULL,
        phone_number VARCHAR(30) NOT NULL UNIQUE,
        email VARCHAR(200) NOT NULL UNIQUE,
        gender ENUM('Female', 'Male') DEFAULT 'Female' NOT NULL,
        function_field ENUM('TuititionService', 'Teacher') DEFAULT 'Teacher' NOT NULL,
        UNIQUE(last_name, first_name)
    );

DROP TABLE IF EXISTS Users;

CREATE TABLE
    Users(
        id int PRIMARY KEY AUTO_INCREMENT,
        username VARCHAR(80) UNIQUE NOT NULL,
        password_field VARCHAR(150) NOT NULL,
        employee_id int NULL UNIQUE,
        FOREIGN KEY(employee_id) REFERENCES Employees(id) ON DELETE CASCADE
    );

DROP TABLE IF EXISTS Institutes;

CREATE TABLE
    Institutes(
        id int PRIMARY KEY AUTO_INCREMENT,
        libelle VARCHAR(150) NOT NULL UNIQUE,
        sigle VARCHAR(40) NOT NULL
    );

DROP TABLE IF EXISTS Careers;

CREATE TABLE
    Careers(
        id int PRIMARY KEY AUTO_INCREMENT,
        libelle VARCHAR(150) NOT NULL UNIQUE,
        sigle VARCHAR(40) NOT NULL,
        institute_id int NOT NULL,
        FOREIGN KEY(institute_id) REFERENCES Institutes(id) ON DELETE CASCADE
    );

DROP TABLE IF EXISTS UEs;

CREATE TABLE
    UEs(
        id int PRIMARY KEY AUTO_INCREMENT,
        libelle VARCHAR(150) NOT NULL,
        semester int NOT NULL,
        career_id int NOT NULL,
        FOREIGN KEY(career_id) REFERENCES Careers(id) ON DELETE CASCADE,
        UNIQUE(libelle, semester, career_id)
    );

DROP TABLE IF EXISTS ECUEs;

CREATE TABLE
    ECUEs(
        id int PRIMARY KEY AUTO_INCREMENT,
        libelle VARCHAR(150) NOT NULL UNIQUE,
        credit int NOT NULL,
        employee_id int NOT NULL,
        FOREIGN KEY(employee_id) REFERENCES Employees(id) ON DELETE CASCADE
    );

DROP TABLE IF EXISTS ECUEsUEs;

CREATE TABLE
    ECUEsUEs(
        ECUE_id int NOT NULL,
        UE_id int NOT NULL,
        FOREIGN KEY(ECUE_id) REFERENCES ECUEs(id),
        FOREIGN KEY(UE_id) REFERENCES UEs(id),
        PRIMARY KEY(ECUE_id, UE_id)
    );

DROP TABLE IF EXISTS Students;

CREATE TABLE
    Students(
        id int PRIMARY KEY AUTO_INCREMENT,
        last_name VARCHAR(30) NOT NULL,
        first_name VARCHAR(150) NOT NULL,
        birth_date DATE,
        gender ENUM('Female', 'Male'),
        email VARCHAR(200) NOT NULL,
        phone_number VARCHAR(30) NOT NULL,
        picture_path VARCHAR(300) NOT NULL,
        career_id int NOT NULL,
        FOREIGN KEY(career_id) REFERENCES Careers(id) ON DELETE CASCADE,
        UNIQUE(last_name, first_name, email)
    );

CREATE TABLE
    ECUEsStudents(
        ECUE_id int NOT NULL,
        student_id int NOT NULL,
        FOREIGN KEY(ECUE_id) REFERENCES ECUEs(id) ON DELETE CASCADE,
        FOREIGN KEY(student_id) REFERENCES Students(id) ON DELETE CASCADE,
        PRIMARY KEY(ECUE_id, student_id)
    );

DROP TABLE IF EXISTS Evaluations;

CREATE TABLE
    Evaluations(
        id int PRIMARY KEY AUTO_INCREMENT,
        grade DOUBLE NOT NULL,
        student_id int NOT NULL,
        ECUE_id int NOT NULL,
        date_field DATETIME,
        weight_field DOUBLE,
        type_field ENUM('D', 'E', 'R'),
        FOREIGN KEY(ECUE_id) REFERENCES ECUEs(id) ON DELETE CASCADE,
        FOREIGN KEY(student_id) REFERENCES Students(id) ON DELETE CASCADE
    );

INSERT INTO
    Institutes(libelle, sigle)
VALUES (
        "Institut Supérieur de Technologie Informatique et Numérique",
        "ISTIN"
    ), ("Faculté Des Sciences", "FDS");

INSERT INTO
    Employees (
        last_name,
        first_name,
        phone_number,
        email,
        gender,
        function_field
    )
VALUES (
        "LABA",
        "Laba",
        "+228 98676615",
        "Laba@gmail.com",
        "Male",
        "Teacher"
    ), (
        "BOUILI",
        "Espoir",
        "+228 91919191",
        "espoir@gmail.com",
        "Male",
        "TuititionService"
    ), (
        "MENSAH",
        "Mensah",
        "+228 91909292",
        "mensah@gmail.com",
        "Male",
        "Teacher"
    ), (
        "WODOME",
        "Wodome",
        "+228 91349292",
        "wodome@gmail.com",
        "Male",
        "Teacher"
    ), (
        "AMELINA",
        "Amelina",
        "+228 91999292",
        "amelina@gmail.com",
        "Male",
        "Teacher"
    ), (
        "EUSEBIO",
        "Claude",
        "+228 91969290",
        "eusebio@gmail.com",
        "Male",
        "Teacher"
    ), (
        "DALMEDA",
        "Dalmeda",
        "+228 91929290",
        "dalmeda@gmail.com",
        "Female",
        "Teacher"
    ), (
        "DAMALI",
        "Damali",
        "+228 91931290",
        "Damali@gmail.com",
        "Male",
        "Teacher"
    );

INSERT INTO
    Users(
        username,
        password_field,
        employee_id
    )
VALUES ("Mawena", "licdovic", NULL), ("Laba", "dums", 1), ("Espoir", "BOUILI", 2), ("Mensah", "dums", 3), ("Wodome", "dums", 4), ("Amelina", "dums", 5), ("Eusebio", "claude", 6), ("Damli", "Damali", 7);

INSERT INTO
    Careers(libelle, sigle, institute_id)
VALUES (
        "Dévéloppement d'Application",
        "DA",
        1
    ), ("Maths-Informatique", "MI", 1), (
        "Réseaux Informatique et Télécomunication",
        "RIT",
        1
    );

INSERT INTO
    UEs(libelle, semester, career_id)
VALUES (
        "COMMUNICATION-ETHIQUE-LANGUE",
        1,
        1
    ), (
        "COMMUNICATION-ETHIQUE-LANGUE",
        1,
        2
    ), (
        "COMMUNICATION-ETHIQUE-LANGUE",
        1,
        3
    ), ("MATHEMATIQUES", 1, 1), ("MATHEMATIQUES", 1, 2), ("MATHEMATIQUES", 1, 3), (
        "PROBABILITE-STATISTIQUE",
        1,
        1
    ), (
        "PROBABILITE-STATISTIQUE",
        1,
        2
    ), (
        "PROBABILITE-STATISTIQUE",
        1,
        3
    ), (
        "PROGRAMMATION-ARCHITECHTURE",
        1,
        1
    ), (
        "PROGRAMMATION-ARCHITECHTURE",
        1,
        2
    ), (
        "PROGRAMMATION-ARCHITECHTURE",
        1,
        3
    ), (
        "SYSTEME D'EXPLOITATION-BASE DE DONNEES",
        1,
        1
    ), (
        "SYSTEME D'EXPLOITATION-BASE DE DONNEES",
        1,
        2
    ), (
        "SYSTEME D'EXPLOITATION-BASE DE DONNEES",
        1,
        3
    );

INSERT INTO
    ECUEs(libelle, credit, employee_id)
VALUES ("Anglais", 2, 1), (
        "Cours d'Education aux valeurs (Ethique)",
        2,
        1
    ), (
        "Technique de Communication Ecrite et Orale",
        2,
        1
    ), (
        "Logique Ensembles et Relation",
        3,
        3
    ), (
        "Nombres Réels - Suites et Fonctions Numérique",
        3,
        3
    ), (
        "Base de calcul de Probabilité",
        3,
        4
    ), (
        "Statistiques Descriptives",
        3,
        4
    ), (
        "Algorithme Programmation de Base",
        4,
        6
    ), (
        "Architechture et Technologie des Ordinateurs",
        2,
        7
    ), ("Base de Données", 3, 8), ("Système d'Exploitation", 3, 5);

INSERT INTO
    `ecuesues` (`ECUE_id`, `UE_id`)
VALUES (1, 1), (1, 2), (1, 3), (2, 1), (2, 2), (2, 3), (3, 1), (3, 2), (3, 3), (4, 4), (4, 5), (4, 6), (5, 4), (5, 5), (5, 6), (6, 7), (6, 8), (6, 9), (7, 7), (7, 8), (7, 9), (8, 10), (8, 11), (8, 12), (9, 10), (9, 11), (9, 12), (10, 13), (10, 14), (10, 15), (11, 13), (11, 14), (11, 15);

INSERT INTO Students
VALUES (
        1,
        "GAMLIGO",
        "Charles Dieu-Donné",
        "03/03/2000",
        "M",
        "gamligocharles@gmail.com",
        "+228 98676615",
        "/home/mawena/dums.jpg",
        1
    );