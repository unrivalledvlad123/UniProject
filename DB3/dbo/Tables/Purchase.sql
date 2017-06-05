CREATE TABLE [dbo].[Purchase] (
    [PurchaseId]       UNIQUEIDENTIFIER NOT NULL,
    [BuyerId]          UNIQUEIDENTIFIER NOT NULL,
    [SellerId]         UNIQUEIDENTIFIER NOT NULL,
    [Date]             DATETIME         NOT NULL,
    [InvoiceId]        VARCHAR (50)     NULL,
    [WareHouseReceipt] VARCHAR (50)     NULL,
    [PaymentCompleted] BIT              NOT NULL,
    CONSTRAINT [PK_Purchase_1] PRIMARY KEY CLUSTERED ([PurchaseId] ASC),
    CONSTRAINT [FK_Purchase_Owner] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_Purchase_Partner1] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Partner] ([PartnerId])
);











