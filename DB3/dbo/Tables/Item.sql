CREATE TABLE [dbo].[Item] (
    [Name]        VARCHAR (150)    NOT NULL,
    [Quantity]    INT              NOT NULL,
    [Type]        INT              NULL,
    [Description] NVARCHAR (500)   NULL,
    [ItemId]      UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([ItemId] ASC)
);



