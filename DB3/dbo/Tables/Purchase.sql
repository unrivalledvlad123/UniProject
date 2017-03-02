CREATE TABLE [dbo].[Purchase] (
    [PurchaseId]       UNIQUEIDENTIFIER NOT NULL,
    [BuyerId]          UNIQUEIDENTIFIER NOT NULL,
    [SellerId]         UNIQUEIDENTIFIER NOT NULL,
    [Date]             DATETIME         NOT NULL,
    [InvoiceId]        INT              NOT NULL,
    [WareHouseReceipt] INT              NOT NULL,
    [PaymentId]        INT              NOT NULL,
    CONSTRAINT [PK_Purchase_1] PRIMARY KEY CLUSTERED ([PurchaseId] ASC),
    CONSTRAINT [FK_Purchase_Owner] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_Purchase_Partner1] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Partner] ([PartnerId])
);





