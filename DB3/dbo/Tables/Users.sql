CREATE TABLE [dbo].[Users] (
    [UserId]   INT          IDENTITY (1, 1) NOT NULL,
    [Role]     INT          NOT NULL,
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

