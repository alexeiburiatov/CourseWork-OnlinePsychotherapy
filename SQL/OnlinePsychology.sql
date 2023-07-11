CREATE DATABASE PsychologyOnline
COLLATE Cyrillic_General_CI_AS
GO

USE PsychologyOnline
GO

CREATE TABLE TherapyTypes
	(
		TherapyID int PRIMARY KEY NOT NULL IDENTITY(1,1),
		TherapyType nvarchar(255) NOT NULL
	);
GO

CREATE TABLE TherapyMethods	
	(
		TherapyID int PRIMARY KEY NOT NULL IDENTITY(1,1),
		TherapyMethod nvarchar(255) NOT NULL
	);
GO

CREATE TABLE LanguageNames 
	(
		LanguageID int PRIMARY KEY NOT NULL IDENTITY(1,1),
		LanguageName nvarchar(35) NOT NULL
	);
GO


CREATE TABLE DataClients
	(
		ClientID int PRIMARY KEY NOT NULL IDENTITY(1,1),
		ClientLName nvarchar(255) NOT NULL,
		ClientFName nvarchar(255) NOT NULL,
		ClientPatronymic nvarchar(255) NULL,
		ClientSex BIT NOT NULL,
		ClientDateOfBirth date NOT NULL,
		ClientLanguage int NOT NULL,
		ClientMail nvarchar(255) NOT NULL,
		CONSTRAINT FK_DataClients_To_LanguageNames FOREIGN KEY (ClientLanguage)
		REFERENCES LanguageNames (LanguageID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	);
GO

ALTER TABLE DataClients
DROP CONSTRAINT FK_DataClients_To_LanguageNames

ALTER TABLE DataClients
ADD CONSTRAINT FK_DataClients_To_LanguageNames FOREIGN KEY (ClientLanguage)
		REFERENCES LanguageNames (LanguageID)
		ON DELETE CASCADE
		ON UPDATE NO ACTION






CREATE TABLE DataSupervs
	(
		SupervID int PRIMARY KEY NOT NULL IDENTITY(1,1),
		SupervLName nvarchar(255) NOT NULL,
		SupervFName nvarchar(255) NOT NULL,
		SupervPatronymic nvarchar(255) NULL,
		SupervSex BIT NOT NULL,
		SupervDateOfBirth date NOT NULL,
		SupervLanguage int NOT NULL,
		HourlyRate int NOT NULL,
		SupervMail nvarchar(255) NOT NULL,
		CONSTRAINT FK_DataSupervs_To_LanguageNames FOREIGN KEY (SupervLanguage)
		REFERENCES LanguageNames (LanguageID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	);
GO



CREATE TABLE DataDoctors
	(
		DoctorID int PRIMARY KEY NOT NULL IDENTITY(1,1),
		DoctorLName nvarchar(255) NOT NULL,
		DoctorFName nvarchar(255) NOT NULL,
		DoctorPatronymic nvarchar(255) NULL,
		DoctorSex BIT NOT NULL,
		DoctorDateOfBirth date NOT NULL,
		DoctorLanguage int NOT NULL,
		HourlyRate int NOT NULL,
		TherapyMethod int NOT NULL,
		SupervisorID int NOT NULL,
		DoctorMail nvarchar(255) NOT NULL,
		CONSTRAINT FK_DataDoctors_To_LanguageNames FOREIGN KEY (DoctorLanguage)
		REFERENCES LanguageNames (LanguageID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
		CONSTRAINT FK_DataDoctors_To_DataSupervs FOREIGN KEY (SupervisorID)
		REFERENCES DataSupervs (SupervID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
		CONSTRAINT FK_DataDoctors_To_TherapyMethods FOREIGN KEY (TherapyMethod)
		REFERENCES TherapyMethods (TherapyID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	);
GO




CREATE TABLE Meetings
	(
		Identifier int PRIMARY KEY NOT NULL IDENTITY(1539,1),
		ClientID int NOT NULL,
		DoctorID int NOT NULL,
		TherapyType int NOT NULL,
		SessionBegin datetime NOT NULL,
		SessionEnd datetime NOT NULL,
		CONSTRAINT FK_Meetings_To_DataClients FOREIGN KEY (ClientID)
		REFERENCES DataClients (ClientID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
		CONSTRAINT FK_Meetings_To_DataDoctors FOREIGN KEY (DoctorID)
		REFERENCES DataDoctors (DoctorID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
		CONSTRAINT FK_Meetings_To_TherapyTypes FOREIGN KEY (TherapyType)
		REFERENCES TherapyTypes (TherapyID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
	);
GO



CREATE TABLE SupAnDocMeetings
	(
		Identifier int PRIMARY KEY NOT NULL IDENTITY(129,1),
		SupervisorID int NOT NULL,
		DoctorID int NOT NULL,
		SessionBegin datetime NOT NULL,
		SessionEnd datetime NOT NULL,
		CONSTRAINT FK_SupAnDocMeetings_To_DataSupervs FOREIGN KEY (SupervisorID)
		REFERENCES DataSupervs (SupervID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
		CONSTRAINT FK_SupAnDocMeetings_To_DataDoctors FOREIGN KEY (DoctorID)
		REFERENCES DataDoctors (DoctorID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	);
GO

INSERT INTO LanguageNames
VALUES
	('���������'),
	('��������'),
	('���������'),
	('����������'),
	('ͳ������'),
	('��������')
	;
GO

INSERT INTO TherapyTypes
VALUES
	;
GO

INSERT INTO TherapyMethods
VALUES

	;
GO

INSERT INTO DataSupervs 
VALUES

	;
GO


INSERT INTO DataDoctors
VALUES
	;
GO

INSERT INTO DataClients
VALUES

GO

INSERT INTO SupAnDocMeetings
VALUES
	(1,4,'2019-10-10 18:47:00','2020-01-01 19:47:00'),
	(1,1,'2020-01-01 10:10:00','2020-01-01 11:10:00'),
	(2,2,'2020-05-01 12:00:00','2020-05-01 13:00:00'),
	(2,3,'2020-05-01 19:30:00','2020-05-01 20:30:00')
	;
GO

INSERT INTO Meetings
VALUES
	(2,1,1,'2018-10-10 10:47:00','2018-10-10 11:47:00'),
	(6,2,1,'2018-01-10 10:00:00','2018-01-10 11:00:00'),
	(7,3,1,'2018-01-10 18:35:00','2018-02-10 19:35:00'),
	(7,7,1,'2018-01-11 18:35:00','2018-02-11 19:35:00'),
	(13,6,1,'2018-01-12 10:00:00','2018-01-12 11:00:00'),
	(10,5,1,'2018-01-12 15:00:00','2018-01-12 16:00:00'),
	(9,3,1,'2019-05-10 07:00:00','2019-05-10 08:00:00')
	;
GO





DROP PROCEDURE SlctDoctorsByLName
CREATE PROCEDURE SlctDoctorsByLName
@LastN NVARCHAR(255) 
AS
SELECT DISTINCT dd.DoctorID AS'������ ID',
	dd.DoctorFName AS '��''�',
	dd.DoctorPatronymic AS '��-�������',
		dd.DoctorLName AS '�������',
	[dbo].gender(dd.DoctorSex) AS '�����',
	dd.DoctorDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	dd.HourlyRate AS '������/���.',
	tm.TherapyMethod AS '����� ����ﳿ',
	ds.SupervID '��������� ID',
	ds.SupervFName '�������',
	ds.SupervLName '��''�',
	ds.SupervPatronymic '��-�������',
	dd.DoctorMail AS '�����'
FROM DataDoctors dd
JOIN LanguageNames ln ON ln.LanguageID=dd.DoctorLanguage
JOIN TherapyMethods tm ON dd.TherapyMethod=tm.TherapyID
JOIN DataSupervs ds ON dd.SupervisorID= ds.SupervID
WHERE dd.DoctorLName=@LastN
	;
GO

DROP PROCEDURE SlctSupervByLName
CREATE PROCEDURE SlctSupervByLName
@LastN NVARCHAR(255)
AS
SELECT ds.SupervID '��������� ID',
	ds.SupervLName '��''�',
		ds.SupervPatronymic '��-�������',
	ds.SupervFName '�������',
	[dbo].gender(ds.SupervSex) AS '�����',
	ds.SupervDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	ds.HourlyRate AS '������/���.',
	ds.SupervMail AS '�����'
FROM DataSupervs ds
JOIN LanguageNames ln ON ln.LanguageID=ds.SupervLanguage
WHERE ds.SupervLName=@LastN
	;
GO

DROP PROCEDURE SlctClientByLName
CREATE PROCEDURE SlctClientByLName
@LastN NVARCHAR(255)
AS
SELECT ClientID AS'�볺�� ID',
	ClientFName AS '��''�',
	ClientPatronymic AS '��-�������',
		ClientLName AS '�������',
	[dbo].gender(ClientSex) AS '�����',
	ClientDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	ClientMail AS '�����'
FROM DataClients d
JOIN LanguageNames ln ON ln.LanguageID=d.ClientLanguage
WHERE ClientLName=@LastN
	;
GO

DROP PROCEDURE SlctDoctorsByID
CREATE PROCEDURE SlctDoctorsByID
@Ident INT 
AS
SELECT DISTINCT dd.DoctorID AS'������ ID',
	dd.DoctorLName AS '�������',
	dd.DoctorFName AS '��''�',
	dd.DoctorPatronymic AS '��-�������',
	[dbo].gender(dd.DoctorSex) AS '�����',
	dd.DoctorDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	dd.HourlyRate AS '������/���.',
	tm.TherapyMethod AS '����� ����ﳿ',
	ds.SupervID '��������� ID',
	ds.SupervFName '�������',
	ds.SupervLName '��''�',
	ds.SupervPatronymic '��-�������',
	dd.DoctorMail AS '�����'
FROM DataDoctors dd
JOIN LanguageNames ln ON ln.LanguageID=dd.DoctorLanguage
JOIN TherapyMethods tm ON dd.TherapyMethod=tm.TherapyID
JOIN DataSupervs ds ON dd.SupervisorID= ds.SupervID
WHERE dd.DoctorID=@Ident
	;
GO


DROP PROCEDURE SlctSupervByID
CREATE PROCEDURE SlctSupervByID
@Ident INT
AS
SELECT ds.SupervID '��������� ID',
	ds.SupervFName '��''�',
	ds.SupervPatronymic '��-�������',
	ds.SupervLName '�������',
	[dbo].gender(ds.SupervSex) AS '�����',
	ds.SupervDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	ds.HourlyRate AS '������/���.',
	ds.SupervMail AS '�����'
FROM DataSupervs ds
JOIN LanguageNames ln ON ln.LanguageID=ds.SupervLanguage
WHERE ds.SupervID=@Ident
	;
GO

CREATE PROCEDURE SlctSupervByName
@Ident NVARCHAR(255)
AS
SELECT ds.SupervID '��������� ID',
	ds.SupervFName '��''�',
	ds.SupervPatronymic '��-�������',
	ds.SupervLName '�������',
	[dbo].gender(ds.SupervSex) AS '�����',
	ds.SupervDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	ds.HourlyRate AS '������/���.',
	ds.SupervMail AS '�����'
FROM DataSupervs ds
JOIN LanguageNames ln ON ln.LanguageID=ds.SupervLanguage
WHERE ds.SupervLName=@Ident
	;
GO



CREATE PROCEDURE SlctClientByID
@Ident INT
AS
SELECT ClientID AS'�볺�� ID',
	ClientFName AS '��''�',
	ClientLName AS '�������',
	ClientPatronymic AS '��-�������',
	[dbo].gender(ClientSex) AS '�����',
	ClientDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	ClientMail AS '�����'
FROM DataClients d
JOIN LanguageNames ln ON ln.LanguageID=d.ClientLanguage
WHERE ClientID=@Ident
	;
GO



CREATE PROCEDURE SlctMeetingByID
@MeetingID INT
AS
	SELECT * FROM Meetings m
	WHERE m.Identifier= @MeetingID
	;
GO

CREATE PROCEDURE AddClient
@ClientFName NVARCHAR(35),
@ClientMName NVARCHAR(35),
@ClientLName NVARCHAR(35),
@Sex TINYINT,
@BirthD DATETIME,
@Language INT,
@Mail NVARCHAR(35)
AS
	INSERT INTO DataClients
	VALUES (@ClientLName, @ClientFName,@ClientMName, @Sex, @BirthD, @Language, @Mail)
	;
GO

DROP PROCEDURE AddSuperv
CREATE PROCEDURE AddSuperv
@FName NVARCHAR(35),
@MName NVARCHAR(35),
@LName NVARCHAR(35),
@Sex TINYINT,
@BirthD DATETIME,
@Language INT,
@HourlyRate INT,
@Mail NVARCHAR(35)
AS
	INSERT INTO DataSupervs
	VALUES (@LName, @FName,@MName, @Sex, @BirthD, @Language,@HourlyRate,@Mail)
	;
GO


EXEC SlctAllClients

CREATE PROCEDURE AddDoctor
@DoctorFName NVARCHAR(35),
@DoctorMName NVARCHAR(35),
@DoctorLName NVARCHAR(35),
@Sex TINYINT,
@BirthD DATETIME,
@Language INT,
@HourlyRate INT,
@TherapyMethod INT,
@SupervisorID INT,
@Mail NVARCHAR(35)
AS
	INSERT INTO DataDoctors
	VALUES (@DoctorLName, @DoctorFName, @DoctorMName,@Sex,
	@BirthD,@Language, @HourlyRate,@TherapyMethod, @SupervisorID,
	@Mail
	)
	;
GO

EXEC SlctAllDoctors;


CREATE PROCEDURE AddSuperv
@SupervFName NVARCHAR(35),
@SupervMName NVARCHAR(35),
@SupervLName NVARCHAR(35),
@Sex TINYINT,
@BirthD DATETIME,
@Language INT,
@HourlyRate INT,
@Mail NVARCHAR(35)
AS
	INSERT INTO DataSupervs
	VALUES (@SupervLName, @SupervFName, @SupervMName,@Sex,
	@BirthD,@Language, @HourlyRate,	@Mail
	)
	;
GO

EXEC SlctAllSuperv;


CREATE PROCEDURE AddMeetingsClient
@ClientID INT,
@DoctorID INT,
@TherapyType TINYINT
AS
	DECLARE @curr_time AS DATETIME= GETDATE()
	INSERT INTO Meetings(ClientID,DoctorID, TherapyType, SessionBegin, SessionEnd)
	VALUES (@ClientID, @DoctorID, @TherapyType, @curr_time, DATEADD(hh, 1, @curr_time))
	;
GO

EXEC AddMeetingsClient 2, 8, 1 ;

CREATE PROCEDURE AddMeetingsSuperv
@DoctorID INT
AS
	DECLARE @curr_time AS DATETIME= GETDATE(),
			@SupervID AS INT

	SELECT @SupervID=SupervisorID
	FROM DataDoctors
	WHERE DoctorID=@DoctorID

	INSERT INTO SupAnDocMeetings(SupervisorID,DoctorID, SessionBegin, SessionEnd)
	VALUES (@SupervID, @DoctorID,@curr_time, DATEADD(hh, 1, @curr_time))
	;
GO



CREATE FUNCTION gender(
	@SexID BIT
)
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE
		@GENDER NVARCHAR(10)
	SET @GENDER='�������'
	IF(@SexID=0)
		SET @GENDER='Ƴ����'
	RETURN @GENDER
END

CREATE PROCEDURE SlctAllClients
AS
SELECT ClientID AS'�볺�� ID',
	ClientFName AS '��''�',
	ClientPatronymic AS '��-�������',
	ClientLName AS '�������',
	[dbo].gender(ClientSex) AS '�����',
	ClientDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	ClientMail AS '�����'
FROM DataClients d
JOIN LanguageNames ln ON ln.LanguageID=d.ClientLanguage
;
GO




--+++
DROP PROCEDURE SlctAllDoct
CREATE PROCEDURE SlctAllDoct
AS
SELECT DISTINCT dd.DoctorID AS'������ ID',
	dd.DoctorFName AS '��''�',
	dd.DoctorPatronymic AS '��-�������',
	dd.DoctorLName AS '�������',
	[dbo].gender(dd.DoctorSex) AS '�����',
	dd.DoctorDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	dd.HourlyRate AS '������/���.',
	tm.TherapyMethod AS '����� ����ﳿ',
	ds.SupervID '��������� ID',
	ds.SupervFName '��''� ����������',
	ds.SupervPatronymic '��-������� ����������',
	ds.SupervLName '������� ����������',
	dd.DoctorMail AS '�����'
FROM DataDoctors dd
JOIN LanguageNames ln ON ln.LanguageID=dd.DoctorLanguage
JOIN TherapyMethods tm ON dd.TherapyMethod=tm.TherapyID
JOIN DataSupervs ds ON dd.SupervisorID= ds.SupervID
	;
GO

CREATE PROCEDURE SlctDoctByID
@DoctorID INT
AS
SELECT DISTINCT dd.DoctorID AS'������ ID',
	dd.DoctorFName AS '��''�',
	dd.DoctorPatronymic AS '��-�������',
	dd.DoctorLName AS '�������',
	[dbo].gender(dd.DoctorSex) AS '�����',
	dd.DoctorDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	dd.HourlyRate AS '������/���.',
	tm.TherapyMethod AS '����� ����ﳿ',
	ds.SupervID '��������� ID',
	ds.SupervFName '��''� ����������',
	ds.SupervPatronymic '��-������� ����������',
	ds.SupervLName '������� ����������',
	dd.DoctorMail AS '�����'
FROM DataDoctors dd
JOIN LanguageNames ln ON ln.LanguageID=dd.DoctorLanguage
JOIN TherapyMethods tm ON dd.TherapyMethod=tm.TherapyID
JOIN DataSupervs ds ON dd.SupervisorID= ds.SupervID
WHERE dd.DoctorID=@DoctorID
	;
GO




DROP PROCEDURE SlctAllSuperv
CREATE PROCEDURE SlctAllSuperv
AS
SELECT ds.SupervID '��������� ID',
	ds.SupervFName '��''�',
		ds.SupervPatronymic '��-�������',
	ds.SupervLName '�������',
	[dbo].gender(ds.SupervSex) AS '�����',
	ds.SupervDateOfBirth AS '���� ����������',
	ln.LanguageName AS '���� ����������',
	ds.HourlyRate AS '������/���.',
	ds.SupervMail AS '�����'
FROM DataSupervs ds
JOIN LanguageNames ln ON ln.LanguageID=ds.SupervLanguage
	;
GO


DROP PROCEDURE SlctAllMeetings
CREATE PROCEDURE SlctAllMeetings
AS
SELECT m.Identifier AS '�������������',
	m.ClientID AS '�볺�� ID',
	dc.ClientFName AS '��''�',
		dc.ClientPatronymic AS '��-�������',
	dc.ClientLName AS '�������',
	dd.DoctorID AS '������ ID',
	dd.DoctorFName AS '��''� �����',
		dd.DoctorPatronymic AS '��-������� �����',
	dd.DoctorLName AS '������� �����',
	tt.TherapyType AS '��� ����ﳿ',
	m.SessionBegin AS '������� ����ﳿ',
	m.SessionEnd AS 'ʳ���� ����ﳿ'
FROM Meetings m
JOIN TherapyTypes tt ON tt.TherapyID= m.TherapyType
JOIN DataClients dc ON dc.ClientID=m.ClientID
JOIN DataDoctors dd ON dd.DoctorID=m.DoctorID
	;
GO

CREATE PROCEDURE SlctAllMeetingsByClientID
@ClientID INT
AS
SELECT m.Identifier AS '�������������',
	m.ClientID AS '�볺�� ID',
	dc.ClientFName AS '��''�',
		dc.ClientPatronymic AS '��-�������',
	dc.ClientLName AS '�������',
	dd.DoctorID AS '������ ID',
	dd.DoctorFName AS '��''� �����',
		dd.DoctorPatronymic AS '��-������� �����',
	dd.DoctorLName AS '������� �����',
	tt.TherapyType AS '��� ����ﳿ',
	m.SessionBegin AS '������� ����ﳿ',
	m.SessionEnd AS 'ʳ���� ����ﳿ'
FROM Meetings m
JOIN TherapyTypes tt ON tt.TherapyID= m.TherapyType
JOIN DataClients dc ON dc.ClientID=m.ClientID
JOIN DataDoctors dd ON dd.DoctorID=m.DoctorID
WHERE m.ClientID=@ClientID
	;
GO

EXEC SlctAllMeetingsByClientID 6

CREATE PROCEDURE SlctAllSupAndDocMeetings
AS
SELECT m.Identifier AS '�������������',

	dd.DoctorID AS '������ ID',
	dd.DoctorFName AS '��''�',
	dd.DoctorPatronymic AS '��-�������',
	dd.DoctorLName AS '�������',
	ds.SupervID AS '��������� ID',
	ds.SupervFName AS '��''� ����������',
	ds.SupervPatronymic AS '��-������� ����������',
	ds.SupervLName AS '������� ����������',
	m.SessionBegin AS '������� ������',
	m.SessionEnd AS 'ʳ���� ������'
FROM SupAnDocMeetings m
JOIN DataSupervs ds ON ds.SupervID=m.SupervisorID
JOIN DataDoctors dd ON dd.DoctorID=m.DoctorID
	;
GO


CREATE PROCEDURE SlctAllSupAndDocMeetingsByDoctorID
@DoctorID INT
AS
SELECT m.Identifier AS '�������������',

	dd.DoctorID AS '������ ID',
	dd.DoctorFName AS '��''�',
	dd.DoctorPatronymic AS '��-�������',
	dd.DoctorLName AS '�������',
	ds.SupervID AS '��������� ID',
	ds.SupervFName AS '��''� ����������',
	ds.SupervPatronymic AS '��-������� ����������',
	ds.SupervLName AS '������� ����������',
	m.SessionBegin AS '������� ������',
	m.SessionEnd AS 'ʳ���� ������'
FROM SupAnDocMeetings m
JOIN DataSupervs ds ON ds.SupervID=m.SupervisorID
JOIN DataDoctors dd ON dd.DoctorID=m.DoctorID
WHERE dd.DoctorID=@DoctorID
	;
GO





CREATE PROCEDURE UpdateDataClient
@ClientID INT,
@FNAME NVARCHAR (255),
@Patronymic NVARCHAR (255),
@LNAME NVARCHAR(255),
@EMAIL NVARCHAR(255)
AS
UPDATE DataClients 
SET ClientFName=@FNAME,
	ClientLName=@LNAME,
	ClientPatronymic=@Patronymic,
	ClientMail=@EMAIL
WHERE ClientID=@ClientID
	;
GO

CREATE PROCEDURE UpdateDataSuperv
@SupervID INT,
@FNAME NVARCHAR (255),
@Patronymic NVARCHAR (255),
@LNAME NVARCHAR(255),
@MONEY INT,
@EMAIL NVARCHAR(255)
AS
UPDATE DataSupervs 
SET SupervFName=@FNAME,
	SupervLName=@LNAME,
	SupervPatronymic=@Patronymic,
	HourlyRate=@MONEY,
	SupervMail=@EMAIL
WHERE SupervID=@SupervID
	;
GO
CREATE PROCEDURE UpdateDataDoct
@DoctID INT,
@FNAME NVARCHAR (255),
@Patronymic NVARCHAR (255),
@LNAME NVARCHAR(255),
@MONEY INT,
@EMAIL NVARCHAR(255)
AS
UPDATE DataDoctors 
SET DoctorFName=@FNAME,
	DoctorLName=@LNAME,
	DoctorPatronymic=@Patronymic,
	HourlyRate=@MONEY,
	DoctorMail=@EMAIL
WHERE DoctorID=@DoctID
	;
GO


CREATE PROCEDURE DeleteClient
@ClientID INT
AS
DELETE FROM DataClients
WHERE ClientID=@ClientID
	;
GO

CREATE PROCEDURE DeleteDoctor
@DoctorID INT
AS
DELETE FROM DataDoctors
WHERE DoctorID=@DoctorID
	;
GO

CREATE PROCEDURE DeleteSuperv
@SupervID INT
AS
DELETE FROM DataSupervs
WHERE SupervID=@SupervID
	;
GO

CREATE PROCEDURE SlctSupervsIDName
AS
SELECT SupervID AS '���������ID',
	CONCAT(SupervFName,' ',SupervPatronymic,' ',SupervLName) AS 'ϲ�' 
FROM DataSupervs

CREATE PROCEDURE SlctDoctorsIDName
AS
SELECT DoctorID AS '������ID',
	CONCAT(DoctorFName,' ',DoctorPatronymic,' ',DoctorLName) AS 'ϲ�' 
FROM DataDoctors

CREATE PROCEDURE SlctClientsIDName
AS
SELECT ClientID AS 'ClientID',
	CONCAT(ClientFName,' ',ClientPatronymic,' ',ClientLName) AS 'ϲ�' 
FROM DataClients


SELECT * FROM TherapyTypes

CREATE PROCEDURE AddSupAndDocMeeting
@DoctorID INT
AS
	INSERT INTO SupAnDocMeetings
	VALUES (
	(SELECT SupervisorID FROM DataDoctors
	WHERE DoctorID=@DoctorID
	),
	@DoctorID,
	GETDATE(),
	DATEADD(hh, 1, current_timestamp))
	;
GO

CREATE VIEW AllMeetings
AS
	SELECT Identifier AS '�������������',
		ClientID AS 'PatientID',
		DoctorID AS 'DoctorID',
		SessionBegin AS '������� ���',
		SessionEnd AS 'ʳ���� ���',
		'�볺��' AS '��� ��������'
	FROM Meetings
UNION ALL
	SELECT Identifier AS '�������������',
		DoctorID AS 'PatientID',
		SupervisorID AS 'DoctorID',
		SessionBegin AS '������� ���',
		SessionEnd AS 'ʳ���� ���',
		'˳���' AS '��� ��������'
	FROM  SupAnDocMeetings

SELECT * FROM AllMeetings

CREATE TABLE DataClientsArchive
	(
		ClientID int NOT NULL,
		ClientLName nvarchar(255) NOT NULL,
		ClientFName nvarchar(255) NOT NULL,
		ClientPatronymic nvarchar(255) NULL,
		ClientSex BIT NOT NULL,
		ClientDateOfBirth date NOT NULL,
		ClientLanguage int NOT NULL,
		ClientMail nvarchar(255) NOT NULL,
		WhoDeleted nvarchar(255) NOT NULL DEFAULT(CURRENT_USER),
		WhenDeleted datetime NOT NULL DEFAULT (GETDATE())
	);

CREATE TRIGGER DataClients_DELETE ON DataClients
AFTER DELETE  
AS
INSERT INTO DataClientsArchive (ClientID,ClientLName,ClientFName,ClientPatronymic,ClientSex,ClientDateOfBirth,ClientLanguage,ClientMail)
SELECT  ClientID,ClientLName,ClientFName,ClientPatronymic,ClientSex,ClientDateOfBirth,ClientLanguage,ClientMail
FROM DELETED


CREATE TABLE DataDoctorsArchive
	(
		DoctorID int PRIMARY KEY NOT NULL IDENTITY(1,1),
		DoctorLName nvarchar(255) NOT NULL,
		DoctorFName nvarchar(255) NOT NULL,
		DoctorPatronymic nvarchar(255) NULL,
		DoctorSex BIT NOT NULL,
		DoctorDateOfBirth date NOT NULL,
		DoctorLanguage int NOT NULL,
		HourlyRate int NOT NULL,
		TherapyMethod int NOT NULL,
		SupervisorID int NOT NULL,
		DoctorMail nvarchar(255) NOT NULL,
		WhoDeleted nvarchar(255) NOT NULL DEFAULT(CURRENT_USER),
		WhenDeleted datetime NOT NULL DEFAULT (GETDATE())
	);

CREATE TRIGGER DataDoctors_DELETE ON DataDoctors
AFTER DELETE  
AS
INSERT INTO DataDoctorsArchive (DoctorID,DoctorLName,DoctorFName,DoctorPatronymic,DoctorSex,DoctorDateOfBirth,DoctorLanguage,HourlyRate,TherapyMethod,SupervisorID,DoctorMail)
SELECT  DoctorID,DoctorLName,DoctorFName,DoctorPatronymic,DoctorSex,DoctorDateOfBirth,DoctorLanguage,HourlyRate,TherapyMethod,SupervisorID,DoctorMail
FROM DELETED


CREATE TABLE DataSupervArchive
(
		SupervID int PRIMARY KEY NOT NULL IDENTITY(1,1),
		SupervLName nvarchar(255) NOT NULL,
		SupervFName nvarchar(255) NOT NULL,
		SupervPatronymic nvarchar(255) NULL,
		SupervSex BIT NOT NULL,
		SupervDateOfBirth date NOT NULL,
		SupervLanguage int NOT NULL,
		HourlyRate int NOT NULL,
		SupervMail nvarchar(255) NOT NULL,
		WhoDeleted nvarchar(255) NOT NULL DEFAULT(CURRENT_USER),
		WhenDeleted datetime NOT NULL DEFAULT (GETDATE())
);


CREATE TRIGGER DataSuperv_DELETE ON DataSupervs
AFTER DELETE  
AS
INSERT INTO DataSupervArchive(SupervID,SupervLName,SupervFName,SupervPatronymic,SupervSex,SupervDateOfBirth,SupervLanguage,HourlyRate,SupervMail)
SELECT  SupervID,SupervLName,SupervFName,SupervPatronymic,SupervSex,SupervDateOfBirth,SupervLanguage,HourlyRate,SupervMail
FROM DELETED

CREATE VIEW CurrentMeeting
AS
SELECT �������������,
	PatientID,
	CASE 
		WHEN [��� ��������]='�볺��' THEN (
			SELECT CONCAT(ClientFName,' ',ClientPatronymic,' ',ClientLName) AS 'ϲ�'
			FROM DataClients
			WHERE ClientID=PatientID)
		WHEN [��� ��������]='˳���' THEN (
			SELECT CONCAT(DoctorFName,' ',DoctorPatronymic,' ',DoctorLName) AS 'ϲ�'
			FROM DataDoctors
			WHERE DoctorID=PatientID)
	END AS 'ϲ� ��������',
	meet.DoctorID,
		CASE 
		WHEN [��� ��������]='�볺��' THEN (
			SELECT CONCAT(DoctorFName,' ',DoctorPatronymic,' ',DoctorLName) AS 'ϲ�'
			FROM DataDoctors
			WHERE meet.DoctorID=DoctorID)
		WHEN [��� ��������]='˳���' THEN (
			SELECT CONCAT(SupervFName,' ',SupervPatronymic,' ',SupervLName) AS 'ϲ�' 
			FROM DataSupervs
			WHERE meet.DoctorID=SupervID)
	END AS 'ϲ� ˳����',
	[��� ��������] AS '��� �������',
	[������� ���],
	[ʳ���� ���]
FROM AllMeetings meet
WHERE [ʳ���� ���]>GETDATE()

EXEC AddSupAndDocMeeting 2
SELECT * FROM CurrentMeeting



CREATE FUNCTION ShowDoctorsByPrice (@priceFrom MONEY, @priceTo MONEY)
RETURNS TABLE
AS
RETURN
(
	SELECT DISTINCT DoctorID AS '˳���ID',
		CONCAT(DoctorFName,' ',DoctorPatronymic,' ',DoctorLName) AS 'ϲ�',
		HourlyRate AS '��������� ������'
	FROM DataDoctors 
	WHERE HourlyRate BETWEEN @priceFrom AND @priceTo
);
GO

SELECT * FROM dbo.ShowDoctorsByPrice(10,200)

USE PsychologyOnline

CREATE ROLE accessClients
GRANT SELECT, UPDATE ON DataClients TO accessClients
GRANT SELECT, UPDATE ON Meetings TO accessClients
GRANT SELECT ON LanguageNames TO accessClients
GRANT SELECT ON TherapyTypes TO accessClients

CREATE LOGIN AlexClient WITH PASSWORD = '05fc1c06vh'
CREATE USER AlexClient FOR LOGIN AlexClient

ALTER ROLE accessClients ADD MEMBER AlexClient

CREATE ROLE accessDoctors
GRANT SELECT, UPDATE ON DataDoctors TO accessDoctors
GRANT SELECT, UPDATE ON SupAnDocMeetings TO accessDoctors
GRANT SELECT ON LanguageNames TO accessDoctors
GRANT SELECT ON TherapyTypes TO accessDoctors
GRANT SELECT ON TherapyMethods TO accessDoctors

CREATE LOGIN AlexeiDoctor WITH PASSWORD = '05fc1c06vh'
CREATE USER AlexeiDoctor FOR LOGIN AlexeiDoctor

ALTER ROLE accessDoctors ADD MEMBER AlexeiDoctor

CREATE ROLE accessSuperv
GRANT SELECT, UPDATE ON DataSupervs TO accessSuperv
GRANT SELECT, UPDATE ON SupAnDocMeetings TO accessSuperv
GRANT SELECT ON LanguageNames TO accessSuperv
GRANT SELECT ON TherapyTypes TO accessSuperv

CREATE LOGIN OleksiiSuperv WITH PASSWORD = '05fc1c06vh'
CREATE USER OleksiiSuperv FOR LOGIN OleksiiSuperv

ALTER ROLE accessSuperv ADD MEMBER OleksiiSuperv
