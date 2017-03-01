CREATE TABLE [dbo].[Sales] (
    [SaleId]    INT      IDENTITY (1, 1) NOT NULL,
    [Date]      DATETIME NOT NULL,
    [Type]      INT      NOT NULL,
    [InvoiceId] INT      NULL,
    [SellerId]  INT      NOT NULL,
    [BuyerId]   INT      NOT NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([SaleId] ASC),
    CONSTRAINT [FK_Sales_Owner] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_Sales_Partner] FOREIGN KEY ([BuyerId]) REFERENCES [dbo].[Partner] ([PartnerId])
);



