CREATE TABLE [dbo].[Owner] (
    [OwnerId]     INT           IDENTITY (1, 1) NOT NULL,
    [Users]       INT           NOT NULL,
    [CompanyName] VARCHAR (100) NOT NULL,
    [Address]     VARCHAR (250) NOT NULL,
    [MollId]      INT           NOT NULL,
    [Phone]       VARCHAR (50)  NULL,
    [Email]       VARCHAR (50)  NULL,
    CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED ([OwnerId] ASC),
    CONSTRAINT [FK_Owner_MOL] FOREIGN KEY ([MollId]) REFERENCES [dbo].[MOL] ([MolId])
);

