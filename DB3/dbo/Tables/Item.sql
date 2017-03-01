CREATE TABLE [dbo].[Item] (
    [ItemId]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (150)  NOT NULL,
    [Quantity]    INT            NOT NULL,
    [Type]        INT            NULL,
    [Description] NVARCHAR (500) NULL,
    CONSTRAINT [PK_Goods_1] PRIMARY KEY CLUSTERED ([ItemId] ASC)
);

