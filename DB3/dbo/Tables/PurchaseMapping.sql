CREATE TABLE [dbo].[PurchaseMapping] (
    [Purchase_id] INT          NOT NULL,
    [Goods_id]    INT          NOT NULL,
    [Price]       DECIMAL (18) NOT NULL,
    [Quantity]    INT          NOT NULL,
    CONSTRAINT [FK_PurchaseMapping_Goods] FOREIGN KEY ([Goods_id]) REFERENCES [dbo].[Goods] ([Id]),
    CONSTRAINT [FK_PurchaseMapping_Purchases1] FOREIGN KEY ([Purchase_id]) REFERENCES [dbo].[Purchases] ([Id])
);

