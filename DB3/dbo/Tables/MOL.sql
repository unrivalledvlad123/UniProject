CREATE TABLE [dbo].[MOL] (
    [MolId]     UNIQUEIDENTIFIER NOT NULL,
    [FirstName] VARCHAR (50)     NULL,
    [LastName]  VARCHAR (50)     NULL,
    [Address]   VARCHAR (50)     NULL,
    [Phone]     VARCHAR (20)     NULL,
    [Email]     VARCHAR (50)     NULL,
    [OwnerId]   UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_MOL] PRIMARY KEY CLUSTERED ([MolId] ASC)
);















