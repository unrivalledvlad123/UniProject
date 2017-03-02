CREATE TABLE [dbo].[MOL] (
    [FirstName] VARCHAR (50)     NOT NULL,
    [LastName]  VARCHAR (50)     NULL,
    [Address]   VARCHAR (50)     NULL,
    [Phone]     VARCHAR (20)     NULL,
    [Email]     VARCHAR (50)     NULL,
    [MollId]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_MOL_1] PRIMARY KEY CLUSTERED ([MollId] ASC)
);





