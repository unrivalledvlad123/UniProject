CREATE TABLE [dbo].[Partner] (
    [Name]      VARCHAR (100)    NOT NULL,
    [Address]   VARCHAR (500)    NOT NULL,
    [Phone]     VARCHAR (50)     NULL,
    [Email]     VARCHAR (50)     NULL,
    [PartnerId] UNIQUEIDENTIFIER NOT NULL,
    [MollId]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Partner] PRIMARY KEY CLUSTERED ([PartnerId] ASC),
    CONSTRAINT [FK_Partner_MOL] FOREIGN KEY ([MollId]) REFERENCES [dbo].[MOL] ([MollId])
);



