CREATE TABLE [dbo].[PartnerItemMapping] (
    [rowId]     INT              IDENTITY (1, 1) NOT NULL,
    [PartnerId] UNIQUEIDENTIFIER NOT NULL,
    [ItemId]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PartnerItemMapping] PRIMARY KEY CLUSTERED ([rowId] ASC),
    CONSTRAINT [FK_PartnerItemMapping_Item] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId]),
    CONSTRAINT [FK_PartnerItemMapping_Partner] FOREIGN KEY ([PartnerId]) REFERENCES [dbo].[Partner] ([PartnerId])
);

