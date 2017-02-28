CREATE TABLE [dbo].[Sales] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [Company_id]  INT      NOT NULL,
    [Date]        DATETIME NOT NULL,
    [Contract_id] INT      NULL,
    [Type]        INT      NOT NULL,
    [Reciept_id]  INT      NOT NULL,
    [Invoice_id]  INT      NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sales_Company] FOREIGN KEY ([Company_id]) REFERENCES [dbo].[Company] ([Id])
);

