CREATE TABLE [dbo].[Sales] (
    [SaleId]    UNIQUEIDENTIFIER NOT NULL,
    [BuyerId]   UNIQUEIDENTIFIER NOT NULL,
    [SellerId]  UNIQUEIDENTIFIER NOT NULL,
    [Date]      DATETIME         NOT NULL,
    [Type]      INT              NOT NULL,
    [InvoiceId] INT              NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([SaleId] ASC),
    CONSTRAINT [FK_Sales_Owner] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_Sales_Partner1] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Partner] ([PartnerId])
);







