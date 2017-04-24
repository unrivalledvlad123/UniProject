CREATE TABLE [dbo].[MOL] (
    [MolId]     UNIQUEIDENTIFIER NOT NULL,
    [FirstName] VARCHAR (200)    NULL,
    [LastName]  VARCHAR (200)    NULL,
    [Address]   VARCHAR (200)    NULL,
    [Phone]     VARCHAR (200)    NULL,
    [Email]     VARCHAR (200)    NULL,
    [OwnerId]   UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_MOL] PRIMARY KEY CLUSTERED ([MolId] ASC)
);

















