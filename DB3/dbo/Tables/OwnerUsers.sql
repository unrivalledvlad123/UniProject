CREATE TABLE [dbo].[OwnerUsers] (
    [OwnerId] INT NOT NULL,
    [UserId]  INT NOT NULL,
    CONSTRAINT [FK_OwnerUsers_Owner] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Owner] ([OwnerId]),
    CONSTRAINT [FK_OwnerUsers_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

