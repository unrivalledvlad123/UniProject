CREATE TABLE [dbo].[PartnerDiscount] (
    [RowID]       INT             IDENTITY (1, 1) NOT NULL,
    [PartnerType] INT             NOT NULL,
    [Discount]    DECIMAL (18, 2) NOT NULL,
    [RangeFrom]   DECIMAL (18, 2) NULL,
    [RangeTo]     DECIMAL (18, 2) NULL,
    [TypeName]    VARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_PartnerDiscount] PRIMARY KEY CLUSTERED ([RowID] ASC)
);





