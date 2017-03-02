CREATE TABLE [dbo].[Sales] (
    [Date]      DATETIME         NOT NULL,
    [Type]      INT              NOT NULL,
    [InvoiceId] INT              NULL,
    [SaleId]    UNIQUEIDENTIFIER NOT NULL,
    [SellerId]  UNIQUEIDENTIFIER NOT NULL,
    [BuyerId]   UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Sales_1] PRIMARY KEY CLUSTERED ([SaleId] ASC),
    CONSTRAINT [FK_Sales_Owner] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_Sales_Partner] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Partner] ([PartnerId])
);





