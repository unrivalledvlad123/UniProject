CREATE TABLE [dbo].[WarehouseReceipt] (
    [OwnerId]                UNIQUEIDENTIFIER NOT NULL,
    [PartnerId]              UNIQUEIDENTIFIER NOT NULL,
    [SaleId]                 UNIQUEIDENTIFIER NOT NULL,
    [WarehouseReceiptId]     UNIQUEIDENTIFIER NOT NULL,
    [WarehouseReceiptNumber] INT              NOT NULL,
    [BuyerCompanyName]       VARCHAR (250)    NULL,
    [BuyerAddress]           VARCHAR (250)    NULL,
    [BuyerVATNumber]         VARCHAR (50)     NULL,
    [BuyerBulstat]           VARCHAR (50)     NULL,
    [OwnerCompanyName]       VARCHAR (200)    NULL,
    [OwnerAddress]           VARCHAR (250)    NULL,
    [OwnerVATNumber]         VARCHAR (50)     NULL,
    [OwnerBulstat]           VARCHAR (50)     NULL,
    [BuyerMol]               VARCHAR (250)    NULL,
    [OwnerMol]               VARCHAR (250)    NULL,
    [DiscountPercent] DECIMAL(18, 2) NULL, 
    CONSTRAINT [PK_WarehouseReceipt] PRIMARY KEY CLUSTERED ([WarehouseReceiptId] ASC)
);

