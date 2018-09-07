CREATE DATABASE dbiLocator

CREATE TABLE tblUserLogs
(
	userLogID INT IDENTITY,
	usertype VARCHAR(20),
	currentLocation VARCHAR(50),
	destination VARCHAR(50),
	userLogTime DATETIME
)

CREATE PROC sp_AddUserLogs
	@utype VARCHAR(20),
	@start VARCHAR(50),
	@dest VARCHAR(50),
	@logTime DATETIME

AS
BEGIN
	INSERT INTO tblUserLogs
	VALUES (@utype, @start, @dest, @logTime)
END
GO
CREATE PROC sp_SearchUserLogs
	@searchkey VARCHAR(100)

AS
	SELECT * FROM tblUserLogs 
	WHERE userLogID LIKE '%'+@searchkey+'%' OR usertype LIKE '%'+@searchkey+'%' 
	OR currentLocation LIKE '%'+@searchkey+'%' OR destination LIKE '%'+@searchkey+'%' OR
	userLogTime LIKE '%'+@searchkey+'%'
GO