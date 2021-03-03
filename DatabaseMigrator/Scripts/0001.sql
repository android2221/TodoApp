CREATE TABLE Todos(
    ID int IDENTITY(1,1) PRIMARY KEY AUTO_INCREMENT,
    Title varchar(255),
    Note varchar(max)
);