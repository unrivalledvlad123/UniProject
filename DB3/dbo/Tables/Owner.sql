CREATE TABLE [dbo].[Owner] (
    [Users]       INT              NOT NULL,
    [CompanyName] VARCHAR (100)    NOT NULL,
    [Address]     VARCHAR (250)    NOT NULL,
    [Phone]       VARCHAR (50)     NULL,
    [Email]       VARCHAR (50)     NULL,
    [OwnerId]     UNIQUEIDENTIFIER NOT NULL,
    [MollId]      UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Owner_1] PRIMARY KEY CLUSTERED ([OwnerId] ASC),
    CONSTRAINT [FK_Owner_MOL] FOREIGN KEY ([MollId]) REFERENCES [dbo].[MOL] ([MollId])
);



