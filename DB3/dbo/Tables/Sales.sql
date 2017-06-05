CREATE TABLE [dbo].[Sales] (
    [SaleId]             UNIQUEIDENTIFIER NOT NULL,
    [BuyerId]            UNIQUEIDENTIFIER NOT NULL,
    [SellerId]           UNIQUEIDENTIFIER NOT NULL,
    [Date]               DATETIME         NOT NULL,
    [Type]               INT              NOT NULL,
    [InvoiceId]          UNIQUEIDENTIFIER NULL,
    [PaymentCompleted]   BIT              NOT NULL,
    [WarehouseReceiptId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([SaleId] ASC),
    CONSTRAINT [FK_Sales_Invoice] FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[Invoice] ([InvoiceId]),
    CONSTRAINT [FK_Sales_Owner] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_Sales_Partner1] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Partner] ([PartnerId]),
    CONSTRAINT [FK_Sales_WarehouseReceipt] FOREIGN KEY ([WarehouseReceiptId]) REFERENCES [dbo].[WarehouseReceipt] ([WarehouseReceiptId])
);













