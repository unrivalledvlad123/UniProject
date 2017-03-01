CREATE TABLE [dbo].[Partner] (
    [PartnerId] INT           NOT NULL,
    [Name]      VARCHAR (100) NOT NULL,
    [Address]   VARCHAR (500) NOT NULL,
    [MolId]     INT           NOT NULL,
    [Phone]     VARCHAR (50)  NULL,
    [Email]     VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([PartnerId] ASC),
    CONSTRAINT [FK_Partner_MOL] FOREIGN KEY ([MolId]) REFERENCES [dbo].[MOL] ([MolId])
);

