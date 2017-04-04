CREATE TABLE [dbo].[Users] (
    [UserId]       UNIQUEIDENTIFIER NOT NULL,
    [OwnerId]      UNIQUEIDENTIFIER NOT NULL,
    [Role]         INT              NOT NULL,
    [Username]     VARCHAR (50)     NOT NULL,
    [Password]     VARCHAR (150)    NOT NULL,
    [AssignedTo]   NVARCHAR (150)   NULL,
    [RegisteredAt] DATETIME         NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Users_Owner] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Owner] ([OwnerId])
);







