CREATE TABLE [dbo].[Purchase] (
    [PurchaseId]       INT      IDENTITY (1, 1) NOT NULL,
    [Date]             DATETIME NOT NULL,
    [InvoiceId]        INT      NOT NULL,
    [WareHouseReceipt] INT      NOT NULL,
    [PaymentId]        INT      NOT NULL,
    [SellerId]         INT      NOT NULL,
    [BuyerId]          INT      NOT NULL,
    CONSTRAINT [PK__Purchase__3214EC07483F8964] PRIMARY KEY CLUSTERED ([PurchaseId] ASC),
    CONSTRAINT [FK_Purchase_Owner] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_Purchase_Partner] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Partner] ([PartnerId])
);

