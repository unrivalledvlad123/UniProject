CREATE TABLE [dbo].[PurchasedItem] (
    [PurchaseId] INT          NOT NULL,
    [ItemId]     INT          NOT NULL,
    [Price]      DECIMAL (18) NOT NULL,
    [Quantity]   INT          NOT NULL,
    CONSTRAINT [FK_PurchasedItem_Item1] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId]),
    CONSTRAINT [FK_PurchasedItem_Purchase] FOREIGN KEY ([PurchaseId]) REFERENCES [dbo].[Purchase] ([PurchaseId])
);

