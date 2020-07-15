IF OBJECT_ID(N'dbo.Authors', N'U') IS NULL BEGIN 
	CREATE TABLE Authors (AuthorId int IDENTITY(1,1) PRIMARY KEY, Name varchar(255)); END; 
IF OBJECT_ID(N'dbo.Users', N'U') IS NULL BEGIN 
	CREATE TABLE Users (UserId int IDENTITY(1, 1) PRIMARY KEY, Name varchar (255)); END; -- May need to add password/cookie
IF OBJECT_ID(N'dbo.Books', N'U') IS NULL BEGIN 
	CREATE TABLE Books (BookId int IDENTITY(1, 1) PRIMARY KEY, Title varchar(255), AuthorId int FOREIGN KEY REFERENCES Authors(AuthorId),
		ISBN varchar(13), Copies int); END;
IF OBJECT_ID(N'dbo.CheckedOut', N'U') IS NULL BEGIN 
	CREATE TABLE CheckedOut (TxId int IDENTITY(1, 1) PRIMARY KEY, UserId int FOREIGN KEY REFERENCES Users(UserId),
							BookId int FOREIGN KEY REFERENCES Books(BookId), TakenOut Date, DueDate Date); END;
