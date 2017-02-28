CREATE TABLE [dbo].[MOL] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [First_name] VARCHAR (50) NOT NULL,
    [Last_name]  VARCHAR (50) NULL,
    [Address]    VARCHAR (50) NULL,
    [Phone]      VARCHAR (20) NULL,
    [Email]      VARCHAR (50) NULL,
    CONSTRAINT [PK_MOL] PRIMARY KEY CLUSTERED ([Id] ASC)
);

