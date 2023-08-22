IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230820133245_initial')
BEGIN
    CREATE TABLE [Authors] (
        [Id] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Authors] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230820133245_initial')
BEGIN
    CREATE TABLE [Books] (
        [BookId] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NOT NULL,
        [PublishDate] datetime2 NOT NULL,
        [BasePrice] decimal(18,2) NOT NULL,
        [AuthorId] int NOT NULL,
        CONSTRAINT [PK_Books] PRIMARY KEY ([BookId]),
        CONSTRAINT [FK_Books_Authors_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [Authors] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230820133245_initial')
BEGIN
    CREATE INDEX [IX_Books_AuthorId] ON [Books] ([AuthorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230820133245_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230820133245_initial', N'7.0.10');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230820170653_seedauthors')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FirstName', N'LastName') AND [object_id] = OBJECT_ID(N'[Authors]'))
        SET IDENTITY_INSERT [Authors] ON;
    EXEC(N'INSERT INTO [Authors] ([Id], [FirstName], [LastName])
    VALUES (1, N''Samuel'', N''Wachira''),
    (2, N''Janet'', N''Gatheru''),
    (3, N''Grace'', N''Nduta'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FirstName', N'LastName') AND [object_id] = OBJECT_ID(N'[Authors]'))
        SET IDENTITY_INSERT [Authors] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230820170653_seedauthors')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230820170653_seedauthors', N'7.0.10');
END;
GO

COMMIT;
GO

