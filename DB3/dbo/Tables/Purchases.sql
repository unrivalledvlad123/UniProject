CREATE TABLE [dbo].[Purchases] (
    [Id]                INT      IDENTITY (1, 1) NOT NULL,
    [CompanyId]         INT      NOT NULL,
    [Date]              DATETIME NOT NULL,
    [Invoice_id]        INT      NOT NULL,
    [WareHouse_receipt] INT      NOT NULL,
    [Payment_id]        INT      NOT NULL,
    CONSTRAINT [PK__Purchase__3214EC07483F8964] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Purchases_Company1] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id])
);

