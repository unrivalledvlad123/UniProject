CREATE TABLE [dbo].[SoldItem] (
    [SaleId]   INT          NOT NULL,
    [ItemId]   INT          NOT NULL,
    [Price]    DECIMAL (18) NOT NULL,
    [Quantity] INT          NOT NULL,
    CONSTRAINT [FK_SoldItem_Item1] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId]),
    CONSTRAINT [FK_SoldItem_Sales] FOREIGN KEY ([SaleId]) REFERENCES [dbo].[Sales] ([SaleId])
);

