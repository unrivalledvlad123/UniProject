CREATE TABLE [dbo].[MOL] (
    [MollId]    UNIQUEIDENTIFIER NOT NULL,
    [FirstName] VARCHAR (50)     NOT NULL,
    [LastName]  VARCHAR (50)     NULL,
    [Address]   VARCHAR (50)     NULL,
    [Phone]     VARCHAR (20)     NULL,
    [Email]     VARCHAR (50)     NULL,
    CONSTRAINT [PK_MOL] PRIMARY KEY CLUSTERED ([MollId] ASC)
);







