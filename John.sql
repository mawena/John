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
        employee_id int NULL,
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
        credit int,
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
        "AOUKOU",
        "Pierrette",
        "+228 98676615",
        "pierretteaoukou@gmail.com",
        "Female",
        "TuititionService"
    ), (
        "BOUILI",
        "Espoir",
        "+228 91919191",
        "espoir@gmail.com",
        "Male",
        "Teacher"
    ), (
        "BILAZA",
        "Jeff",
        "+228 91919192",
        "jeff@gmail.com",
        "Male",
        "TuititionService"
    ), (
        "NYAVEDJI",
        "Rhamone",
        "+228 91909090",
        "rhamone@gmail.com",
        "Male",
        "Teacher"
    ), (
        "EUSEBIO",
        "Claude",
        "+228 91909290",
        "eusebio@gmail.com",
        "Male",
        "Teacher"
    ), (
        "DAMALI",
        "Claude",
        "+228 91939090",
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
VALUES ("Mawena", "licdovic", NULL), ("Pierrette", "AOUKOU", 1), ("Espoir", "BOUILI", 2), ("Jeff", "jeff", 3), ("Rhamone", "Kota", 4), ("Eusebio", "claude", 5), ("Damli", "Damali", 6);

INSERT INTO
    Careers(libelle, sigle, institute_id)
VALUES (
        "Dévéloppement d'Application",
        "DA",
        1
    ), ("Maths-Informatique", "MI", 1), ("Mathématiques", "Maths", 2);

INSERT INTO
    UEs(libelle, semester, career_id)
VALUES ("Programmation de Base", 1, 1), ("Programmation de Base", 1, 2), ("Base de données", 1, 2);

INSERT INTO
    ECUEs(libelle, credit, employee_id)
VALUES (
        "Aplication Programmation 1",
        3,
        5
    ), ("Base de données", 3, 6);

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