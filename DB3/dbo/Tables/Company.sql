CREATE TABLE [dbo].[Company] (
    [Id]      INT           NOT NULL,
    [Name]    VARCHAR (100) NOT NULL,
    [Address] VARCHAR (500) NOT NULL,
    [Mol_id]  INT           NOT NULL,
    [Phone]   VARCHAR (50)  NULL,
    [Email]   VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Company_MOL] FOREIGN KEY ([Mol_id]) REFERENCES [dbo].[MOL] ([Id])
);

