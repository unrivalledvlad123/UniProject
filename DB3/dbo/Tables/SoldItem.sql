CREATE TABLE [dbo].[SoldItem] (
    [Price]      DECIMAL (18)     NOT NULL,
    [Quantity]   INT              NOT NULL,
    [ItemId]     UNIQUEIDENTIFIER NOT NULL,
    [SoldItemId] UNIQUEIDENTIFIER NOT NULL,
    [SaleId]     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_SoldItem] PRIMARY KEY CLUSTERED ([SoldItemId] ASC),
    CONSTRAINT [FK_SoldItem_Item1] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId]),
    CONSTRAINT [FK_SoldItem_Sales1] FOREIGN KEY ([SaleId]) REFERENCES [dbo].[Sales] ([SaleId])
);







