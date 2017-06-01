CREATE TABLE [dbo].[Partner] (
    [PartnerId]   UNIQUEIDENTIFIER NOT NULL,
    [CompanyName] VARCHAR (100)    NOT NULL,
    [Address]     VARCHAR (500)    NOT NULL,
    [Phone]       VARCHAR (50)     NULL,
    [Email]       VARCHAR (50)     NULL,
    [VATNumber]   VARCHAR (50)     NULL,
    [Bulstat]     VARCHAR (50)     NULL,
    [PartnerType] INT              NOT NULL,
    [Sum]         DECIMAL (18, 2)  NULL,
    CONSTRAINT [PK_Partner_1] PRIMARY KEY CLUSTERED ([PartnerId] ASC)
);















