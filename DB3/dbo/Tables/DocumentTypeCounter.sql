CREATE TABLE [dbo].[DocumentTypeCounter] (
    [DocumentType] INT              IDENTITY (1, 1) NOT NULL,
    [CounterId]    UNIQUEIDENTIFIER NOT NULL,
    [DocumentName] VARCHAR (150)    NOT NULL,
    CONSTRAINT [PK_DocumentTypeCounter] PRIMARY KEY CLUSTERED ([DocumentType] ASC),
    CONSTRAINT [FK_DocumentTypeCounter_Counter] FOREIGN KEY ([CounterId]) REFERENCES [dbo].[Counter] ([CounterId])
);

