CREATE TABLE [dbo].[Users] (
    [Role]     INT              NOT NULL,
    [Username] VARCHAR (50)     NOT NULL,
    [Password] VARCHAR (50)     NOT NULL,
    [UserId]   UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Users_1] PRIMARY KEY CLUSTERED ([UserId] ASC)
);



