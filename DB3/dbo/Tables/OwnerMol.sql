CREATE TABLE [dbo].[OwnerMol] (
    [OwnerId] UNIQUEIDENTIFIER NULL,
    [MolId]   UNIQUEIDENTIFIER NULL,
    CONSTRAINT [FK_OwnerMol_MOL] FOREIGN KEY ([MolId]) REFERENCES [dbo].[MOL] ([MolId]),
    CONSTRAINT [FK_OwnerMol_Owner] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Owner] ([OwnerId])
);

