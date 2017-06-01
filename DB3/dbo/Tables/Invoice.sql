CREATE TABLE [dbo].[Invoice] (
    [OwnerId]          UNIQUEIDENTIFIER NOT NULL,
    [PartnerId]        UNIQUEIDENTIFIER NOT NULL,
    [SaleId]           UNIQUEIDENTIFIER NOT NULL,
    [InvoiceId]        UNIQUEIDENTIFIER NOT NULL,
    [InvoiceNumber]    INT              NOT NULL,
    [BuyerCompanyName] VARCHAR (200)    NULL,
    [BuyerAddress]     VARCHAR (250)    NULL,
    [BuyerVATNumber]   VARCHAR (50)     NULL,
    [BuyerBulstat]     VARCHAR (50)     NULL,
    [OwnerCompanyName] VARCHAR (200)    NULL,
    [OwnerAddress]     VARCHAR (250)    NULL,
    [OwnerVATNumber]   VARCHAR (50)     NULL,
    [OwnerBulstat]     VARCHAR (50)     NULL,
    [OwnerBank]        VARCHAR (250)    NULL,
    [OwnerIBAN]        VARCHAR (100)    NULL,
    [OwnerSwiftCode]   VARCHAR (50)     NULL,
    [BuyerMol]         VARCHAR (250)    NULL,
    [OwnerMol]         VARCHAR (250)    NULL,
    [DiscountPercent]  DECIMAL (18, 2)  NULL,
    CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED ([InvoiceId] ASC)
);









