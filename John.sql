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
        function_field ENUM(
            'TuititionService',
            'Teacher',
            'SuperUser'
        ) NOT NULL,
        password_field VARCHAR(150) NOT NULL,
        employee_id int NULL,
        FOREIGN KEY(employee_id) REFERENCES Employees(id)
    );

DROP TABLE IF EXISTS Institutes;

CREATE TABLE
    Institutes(
        id int PRIMARY KEY AUTO_INCREMENT,
        libelle VARCHAR(150) NOT NULL UNIQUE,
        sigle VARCHAR(40) NOT NULL
    );

DROP TABLE IF EXISTS Faculties;

CREATE TABLE
    Faculties(
        id int PRIMARY KEY AUTO_INCREMENT,
        libelle VARCHAR(150) NOT NULL UNIQUE,
        sigle VARCHAR(40) NOT NULL,
        institute_id int NOT NULL,
        FOREIGN KEY(institute_id) REFERENCES Institutes(id)
    );

DROP TABLE IF EXISTS UEs;

CREATE TABLE
    UEs(
        id int PRIMARY KEY AUTO_INCREMENT,
        libelle VARCHAR(150) NOT NULL,
        semester int NOT NULL,
        faculty_id int NOT NULL,
        FOREIGN KEY(faculty_id) REFERENCES Faculties(id)
    );

DROP TABLE IF EXISTS ECUEs;

CREATE TABLE
    ECUEs(
        id int PRIMARY KEY AUTO_INCREMENT,
        libelle VARCHAR(150) NOT NULL UNIQUE,
        credit int,
        employee_id int NOT NULL,
        FOREIGN KEY(employee_id) REFERENCES Employees(id)
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
        gender ENUM('F', 'M'),
        email VARCHAR(200) NOT NULL,
        phone_number VARCHAR(30) NOT NULL,
        picture_path VARCHAR(300) NOT NULL,
        faculty_id int NOT NULL,
        FOREIGN KEY(faculty_id) REFERENCES Faculties(id),
        UNIQUE(last_name, first_name, email)
    );

CREATE TABLE
    ECUEsStudents(
        ECUE_id int NOT NULL,
        student_id int NOT NULL,
        FOREIGN KEY(ECUE_id) REFERENCES ECUEs(id),
        FOREIGN KEY(student_id) REFERENCES Students(id),
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
        FOREIGN KEY(ECUE_id) REFERENCES ECUEs(id),
        FOREIGN KEY(student_id) REFERENCES Students(id)
    );

INSERT INTO Institutes
VALUES (
        1,
        "Institut Supérieur de Technologie Informatique et Numérique",
        "ISTIN"
    );

INSERT INTO Faculties
VALUES (
        1,
        "Dévéloppement d'Application",
        "DA",
        1
    );

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

INSERT INTO Employees
VALUES (
        1,
        "GAMLIGO",
        "Charles Dieu-Donné",
        "+228 91611135",
        "gamligocharles@gmail.com",
        "Male",
        "Teacher"
    ), (
        2,
        "AOUKOU",
        "Pierrette",
        "+228 98676615",
        "pierretteaoukou@gmail.com",
        "Female",
        "Teacher"
    ), (
        3,
        "BOUILI",
        "Espoir",
        "+228 91919191",
        "espoir@gmail.com",
        "Male",
        "TuititionService"
    );

INSERT INTO
    Users(
        id,
        username,
        function_field,
        password_field
    )
VALUES (
        1,
        "mawena",
        "SuperUser",
        "licdovic"
    ), (
        2,
        "Pierrette",
        "SuperUser",
        "licdovic"
    ), (
        3,
        "Espoir",
        "Teacher",
        "licdovic"
    ), (
        4,
        "Jeff",
        "TuititionService",
        "licdovic"
    ), (
        5,
        "Rhamone",
        "Teacher",
        "licdovic"
    );

SELECT * FROM Users;

SELECT * FROM Employees;