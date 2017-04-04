CREATE TABLE [dbo].[WarehouseItems] (
    [ItemId]           UNIQUEIDENTIFIER NOT NULL,
    [Quantity]         INT              NULL,
    [SellingPriceCent] INT              NULL,
    CONSTRAINT [PK_WarehouseItems] PRIMARY KEY CLUSTERED ([ItemId] ASC),
    CONSTRAINT [FK_WarehouseItems_Item] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId])
);

