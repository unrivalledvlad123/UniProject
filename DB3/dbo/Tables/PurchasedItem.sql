CREATE TABLE [dbo].[PurchasedItem] (
    [Price]      DECIMAL (18)     NOT NULL,
    [Quantity]   INT              NOT NULL,
    [PurchaseId] UNIQUEIDENTIFIER NOT NULL,
    [ItemId]     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [FK_PurchasedItem_Item1] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId]),
    CONSTRAINT [FK_PurchasedItem_Purchase1] FOREIGN KEY ([PurchaseId]) REFERENCES [dbo].[Purchase] ([PurchaseId])
);





