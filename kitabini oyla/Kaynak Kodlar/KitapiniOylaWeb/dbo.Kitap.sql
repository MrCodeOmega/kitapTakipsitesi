CREATE TABLE [dbo].[Kitap] (
    [Id]       INT           NOT NULL,
    [KitapAdi] VARCHAR (50)  NULL,
    [KategoriId] INT  NULL,
    [KategoriAdi]    VARCHAR (50)  NULL,
    [Yazar]    VARCHAR (50) NULL,
    [Resim] VARCHAR(190) NULL, 
    [Puan] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

