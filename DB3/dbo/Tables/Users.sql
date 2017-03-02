CREATE TABLE [dbo].[Users] (
    [UserId]   UNIQUEIDENTIFIER NOT NULL,
    [OwnerId]  UNIQUEIDENTIFIER NOT NULL,
    [Role]     INT              NOT NULL,
    [Username] VARCHAR (50)     NOT NULL,
    [Password] VARCHAR (50)     NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Users_Owner] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Owner] ([OwnerId])
);





