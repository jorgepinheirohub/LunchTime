CREATE DATABASE LunchTime

GO

USE LunchTime

CREATE TABLE [Restaurant] (
    Id		uniqueidentifier    NOT NULL,
    Name	VARCHAR(100)		NOT NULL,
    Votes	INT					NULL,
    CONSTRAINT PK_Restaurant_Id PRIMARY KEY CLUSTERED (Id)
);

CREATE TABLE [User] (
    Id          UNIQUEIDENTIFIER    NOT NULL,
    Username    VARCHAR(50)         NOT NULL,
    Password    VARCHAR(64)         NOT NULL,
    CONSTRAINT PK_User_Id   PRIMARY KEY CLUSTERED (Id)
);