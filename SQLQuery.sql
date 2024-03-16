--select * from Color
--select distinct Color,Id from Color order by Color asc

--select distinct Destino from Remito order by Destino asc

--insert into Remito (Destino) values ('Ramon')

--update Remito set Numero = 1 where Id = 1

--select Id,Numero,Destino from Remito where Numero = 1120
--select Id,Id_artificial,Id_color, Id_remito, Cantidad from Armado where Id_remito = 11


--insert into Armado (Id_artificial, Id_color, Id_remito, Cantidad) values (5,5,1,85)

--select A.Id,R.Numero Remito, S.Modelo, C.Color,A.Cantidad from Armado A,Color C,Artificial S,Remito R
--where Id_remito = R.Id and A.Id_artificial = S.Id and A.Id_color = C.Id and R.Numero = 4


--update Armado set Id_artificial = 6, Id_color = 5, Cantidad = 35 where Id = 4

--delete from Remito where Numero = 10
--delete from Anilla where Id =	
--select distinct Modelo from Artificial

--select A.Id, Codigo, Modelo,C.Color, Peso, Cantidad, C.Id IdColor,A.Imagen from Artificial A, Color C
--where A.Id_color = C.Id --and Modelo = 'Arrow' and Color = 'BKB' --Datos del color seleccionado

--update Artificial set Imagen = 'https://techtackle.com.ar/wp-content/uploads/2021/04/04.jpg' where Id = 4 

--select MAX(Numero) as Ultimo from Remito

--select * from Artificial

--SELECT COUNT(*) AS Total FROM Armado WHERE Id_artificial = 6 AND Id_color = 11 and Id_remito = 5

--select * from Armado 
--select * from Remito
--select * from Anilla
--select * from Anzuelo
--select * from Blister
--select * from Carcasa
--select * from Carton
--select * from Piton
--select * from Artificial
--select * from Standar

--UPDATE Armado SET Cantidad = @Cantidad WHERE Id_artificial = @Art AND Id_color = @Color AND Id_remito = @Remito
--UPDATE Armado SET Cantidad = @Cantidad WHERE Id = @Id

--truncate table standar

--select Cantidad from Armado where Id_artificial = 1 and Id_color = 1 and Id_remito = 14

--delete from Anzuelo where Id = 1007

--select Id from Remito where Numero = 3

--insert into Standar (Modelo, IdAnillasA, IdAnillasP, IdAnzueloS, IdAnzueloT, IdBlister, IdCarton, IdPiton) values ('Arrow',2,4,2,1,1,1,1)
--update Standar SET IdAnillasP = 1005, IdBlister = 1, IdCarton = 8 WHERE Id = 2
--update Standar SET IdBlister = 4, IdCarton = 10 WHERE Id = 1004
--select * from Standar

--SELECT S.Id, S.Modelo, A.Tamaño AnillaA,Pit.Tamaño AnillaP, H.Numero AnzSimple, HT.Numero AnzTriple, C.Modelo Carton, B.Modelo Blister, P.Modelo Piton
--FROM Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Carton C, Blister B, Standar S, Piton P 
--WHERE S.IdAnzueloS = H.Id AND S.IdAnzueloT = HT.Id AND S.IdAnillasA = A.Id AND S.IdAnillasP = Pit.Id AND S.IdCarton = C.Id AND S.IdBlister = B.Id AND S.IdPiton = P.Id

--select distinct Id, Numero from Anzuelo order by Numero asc

--select distinct Id, Tamaño from Anilla order by Tamaño asc

--insert into Anilla(Tamaño) values (0)
--insert into Anzuelo(Numero) values (0)

--select S.Id, S.Modelo, A.Tamaño AnillaA,A.Id AnAnzId,Pit.Tamaño AnillaP, Pit.Id AnPitId, H.Numero AnzSimple,H.Id ASId, HT.Numero AnzTriple, HT.Id ATId, B.Modelo Blister, B.Id idBlister, C.Modelo Carton, C.Id idCarton
--from Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Standar S, Blister B, Carton C
--where S.IdAnzueloS = H.Id and S.IdAnzueloT = HT.Id and S.IdAnillasA = A.Id and S.IdAnillasP = Pit.Id and S.IdCarton = C.Id and S.IdBlister = B.Id and S.Modelo = 'Bendy 1'

--delete from Standar where Id = 5

--update Standar set IdAnillasA = 3, IdAnillasP = 2, IdAnzueloS = 7, IdAnzueloT = 2 where Id = 2
--update Anzuelo set Descripcion = 'No lleva', Cantidad = 0, Peso = 0 where Id = 7
--update Anilla set Marca = 'Vacio',Tamaño = 'x', Cantidad = 0, Peso = 0 where Id = 4

--select A.Id,Imagen from Artificial A, Color C where A.Modelo = 'Bendy 1' and C.Color = 'FTG' and A.Id_color = C.Id

--insert into Remito (Numero,Destino,FechaCreacion) values (@Numero,@Destino,@Fecha)

--select * from Remito

--select Peso from Anzuelo where Numero = '#1/0'
--select Peso from Anilla where Tamaño = '#4'
--select Peso from Blister where Modelo = '#1040/1'
--select Peso from Carton where Modelo = 'Grande'

--select Id, Numero, Destino, FechaCreacion from Remito

--delete from Anzuelo where Id = 
--update Anzuelo set Numero = '',Descripcion = '', Cantidad = 1, Peso = 2 where Id = 
--delete from Blister where Id = 
--update Blister set Modelo = '', Descripcion = '', Cantidad = 1, Peso = 1 where Id =
--delete from Carcasa where Id =
--UPDATE Carcasa SET Modelo = '',PesoArmado = 0, Cantidad = 0 WHERE Id = 
--DELETE FROM Carton WHERE Id = 
--UPDATE Carton SET Modelo = '', Descripcion = '', Cantidad = 1, Peso = 1 WHERE Id = 
--DELETE FROM Piton WHERE Id =
--UPDATE Piton SET Modelo = '', Cantidad = 1, Peso = 1 WHERE Id = 

--SELECT COLUMN_NAME Columna, DATA_TYPE Tipo
--FROM INFORMATION_SCHEMA.COLUMNS
--WHERE TABLE_NAME = 'Anilla'

--SELECT Id, Marca, Tamaño, Cantidad, Peso FROM Anilla

--select A.Id, Codigo, Modelo, C.Color Color, Imagen, Peso, Cantidad, C.Id IdColor, C.Descripcion Descripcion from Artificial A, Color C where A.Id_color = C.Id
--select descripcion from COLOR
--update COLOR set color = '', descripcion = '' where id = 

--UPDATE ARTIFICIAL SET codigo = '', id_color = 1, modelo = '', imagen = '', cantidad = 1, peso = 1.2 WHERE id = 1

SELECT Codigo, Modelo, C.Color Color, Imagen, Peso, Cantidad, C.Id IdColor, C.Descripcion Descripcion FROM Artificial A, Color C WHERE A.Id_color = C.Id