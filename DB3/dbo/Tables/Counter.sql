CREATE TABLE [dbo].[Counter] (
    [CounterId]     UNIQUEIDENTIFIER NOT NULL,
    [CurrentNumber] INT              NULL,
    [StartNumber]   INT              NULL,
    [EndNumber]     INT              NULL,
    CONSTRAINT [PK_Counter] PRIMARY KEY CLUSTERED ([CounterId] ASC)
);

