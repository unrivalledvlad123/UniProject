CREATE TABLE [dbo].[Users] (
    [Username]     VARCHAR (100)    NOT NULL,
    [OwnerId]      UNIQUEIDENTIFIER NOT NULL,
    [Password]     VARCHAR (500)    NOT NULL,
    [AssignedTo]   NVARCHAR (150)   NULL,
    [RegisteredAt] DATETIME         NOT NULL,
    [Role]         INT              NOT NULL,
    [PasswordSalt] VARCHAR (50)     NOT NULL,
    [UserId]       UNIQUEIDENTIFIER NOT NULL,
    [Permissions]  NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Username] ASC),
    CONSTRAINT [FK_Users_Owner1] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Owner] ([OwnerId])
);















