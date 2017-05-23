CREATE TABLE [dbo].[ItemTypesDDS] (
    [RowId]      INT             NOT NULL,
    [Type]       INT             NOT NULL,
    [DDSPercent] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_ItemTypesDDS] PRIMARY KEY CLUSTERED ([RowId] ASC)
);

