CREATE TABLE [dbo].[Partner] (
    [PartnerId] UNIQUEIDENTIFIER NOT NULL,
    [MollId]    UNIQUEIDENTIFIER NOT NULL,
    [Name]      VARCHAR (100)    NOT NULL,
    [Address]   VARCHAR (500)    NOT NULL,
    [Phone]     VARCHAR (50)     NULL,
    [Email]     VARCHAR (50)     NULL,
    CONSTRAINT [PK_Partner_1] PRIMARY KEY CLUSTERED ([PartnerId] ASC),
    CONSTRAINT [FK_Partner_MOL1] FOREIGN KEY ([MollId]) REFERENCES [dbo].[MOL] ([MollId])
);





