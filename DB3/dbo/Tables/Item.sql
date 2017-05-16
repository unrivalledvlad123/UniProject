CREATE TABLE [dbo].[Item] (
    [ItemId]         UNIQUEIDENTIFIER NOT NULL,
    [Name]           VARCHAR (150)    NOT NULL,
    [Type]           INT              NULL,
    [Description]    NVARCHAR (500)   NULL,
    [MeasurmentUnit] INT              NULL,
    [ItemCode]       NVARCHAR (50)    NULL,
    CONSTRAINT [PK_Item_1] PRIMARY KEY CLUSTERED ([ItemId] ASC)
);











