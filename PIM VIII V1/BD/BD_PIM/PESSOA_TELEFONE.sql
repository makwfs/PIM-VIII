﻿CREATE TABLE [dbo].[PESSOA_TELEFONE]
(
	[Id_PESSOA] INTEGER NOT NULL PRIMARY KEY, 
    [Id_TELEFONE] INTEGER NULL, 
    CONSTRAINT [AK_PESSOA_TELEFONE_Column] UNIQUE ([Id_TELEFONE]), 
    CONSTRAINT [FK_PESSOA_TELEFONE_ToTable] FOREIGN KEY ([Id_TELEFONE]) REFERENCES [TELEFONE]([ID])

)