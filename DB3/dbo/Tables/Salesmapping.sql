CREATE TABLE [dbo].[Salesmapping] (
    [Sale_id]  INT          NOT NULL,
    [Goods_id] INT          NOT NULL,
    [Price]    DECIMAL (18) NOT NULL,
    [Quantity] INT          NOT NULL,
    CONSTRAINT [FK_Salesmapping_Goods] FOREIGN KEY ([Goods_id]) REFERENCES [dbo].[Goods] ([Id]),
    CONSTRAINT [FK_Salesmapping_Sales] FOREIGN KEY ([Sale_id]) REFERENCES [dbo].[Sales] ([Id])
);

