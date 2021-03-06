﻿CREATE TABLE [dbo].[Owner] (
    [OwnerId]     UNIQUEIDENTIFIER NOT NULL,
    [CompanyName] VARCHAR (100)    NOT NULL,
    [Address]     VARCHAR (250)    NOT NULL,
    [Phone]       VARCHAR (50)     NULL,
    [Email]       VARCHAR (50)     NULL,
    [VATNumber]   VARCHAR (50)     NULL,
    [Bulstat]     VARCHAR (50)     NULL,
    [Bank]        VARCHAR (500)    NULL,
    [SWIFTCode]   VARCHAR (50)     NULL,
    [IBAN]        VARCHAR (100)    NULL,
    CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED ([OwnerId] ASC)
);

















