CREATE TABLE Events (
    ID int IDENTITY(1,1) PRIMARY KEY,
    Title varchar(255),
    Note varchar(max),
    EventDate DateTime
)