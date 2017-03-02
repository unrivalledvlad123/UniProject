CREATE TABLE [dbo].[Owner] (
    [OwnerId]     UNIQUEIDENTIFIER NOT NULL,
    [MollId]      UNIQUEIDENTIFIER NOT NULL,
    [CompanyName] VARCHAR (100)    NOT NULL,
    [Address]     VARCHAR (250)    NOT NULL,
    [Phone]       VARCHAR (50)     NULL,
    [Email]       VARCHAR (50)     NULL,
    CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED ([OwnerId] ASC),
    CONSTRAINT [FK_Owner_MOL1] FOREIGN KEY ([MollId]) REFERENCES [dbo].[MOL] ([MollId])
);





