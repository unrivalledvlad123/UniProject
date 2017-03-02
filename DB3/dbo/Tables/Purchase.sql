CREATE TABLE [dbo].[Purchase] (
    [Date]             DATETIME         NOT NULL,
    [InvoiceId]        INT              NOT NULL,
    [WareHouseReceipt] INT              NOT NULL,
    [PaymentId]        INT              NOT NULL,
    [PurchaseId]       UNIQUEIDENTIFIER NOT NULL,
    [SellerId]         UNIQUEIDENTIFIER NOT NULL,
    [BuyerId]          UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED ([PurchaseId] ASC),
    CONSTRAINT [FK_Purchase_Owner] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_Purchase_Partner] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Partner] ([PartnerId])
);



