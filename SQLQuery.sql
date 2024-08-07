--select distinct Color,Id from Color order by Color asc

--select distinct Destino from Remito order by Destino asc

--insert into Remito (Destino) values ('Ramon')

--update Remito set Numero = 1 where Id = 1

--select Id,Numero,Destino from Remito where Numero = 1120
--select Id,Id_artificial,Id_color, Id_remito, Cantidad from Armado where Id_remito = 11

--insert into Armado (Id_artificial, Id_color, Id_remito, Cantidad) values (5,5,1,85)

--SELECT A.Id Id, R.Numero, S.Modelo, C.Color, A.Cantidad FROM Armado A, Color C, Artificial S,Remito R WHERE Id_artificial = S.Id AND A.Id_color = C.Id AND Id_remito = R.Id

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

--SELECT S.Id, S.Modelo, A.Tamaño AnillaA,A.Id AnAnzId,Pit.Tamaño AnillaP, Pit.Id AnPitId, H.Numero AnzSimple,H.Id ASId, HT.Numero AnzTriple, HT.Id ATId, B.Modelo Blister, B.Id idBlister, C.Modelo Carton, C.Id idCarton,P.modelo Piton, P.id idPiton 
--FROM Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Standar S, Blister B, Carton C, PITON P 
--WHERE S.IdAnzueloS = H.Id AND S.IdAnzueloT = HT.Id AND S.IdAnillasA = A.Id AND S.IdAnillasP = Pit.Id AND S.IdCarton = C.Id AND S.IdBlister = B.Id AND S.idPiton = P.id
--ORDER BY S.Modelo

--select A.Id,R.Numero Remito, S.Modelo, C.Color,A.Cantidad from Armado A,Color C,Artificial S,Remito R
--where Id_remito = R.Id and A.Id_artificial = S.Id and A.Id_color = C.Id and R.Numero = 14

select * from Anilla
select * from Anzuelo
select * from Blister
select * from Carcasa
select * from Carton
select * from Piton
select * from Color
select * from ARTIFICIAL
select * from ARMADO
select * from Remito
select * from Standar

--SELECT DISTINCT id, modelo from CARTON ORDER BY modelo 
--UPDATE Armado SET Cantidad = @Cantidad WHERE Id_artificial = @Art AND Id_color = @Color AND Id_remito = @Remito
--UPDATE Armado SET Cantidad = @Cantidad WHERE Id = @Id
--UPDATE ANZUELO SET  descripcion = 'NO LLEVA' where id = 4
--UPDATE STANDAR SET idAnillasA = @aniAnzuelo, idAnillasP = @aniPaleta, idAnzueloS = @anzSimple, idAnzueloT = @anzTriple, idBlister = @blister, idCarton = @carton, idPiton = @piton WHERE id = @id
 
--truncate table armado; truncate table remito; 
--truncate table anilla; truncate table anzuelo; truncate table blister; truncate table carton; truncate table piton;

--select Cantidad from Armado where Id_artificial = 1 and Id_color = 1 and Id_remito = 14

--delete from Anzuelo where Id = 1007
 
--select Id from Remito where Numero = 3

--insert into Standar (Modelo, IdAnillasA, IdAnillasP, IdAnzueloS, IdAnzueloT, IdBlister, IdCarton, IdPiton) values ('Arrow',2,4,2,1,1,1,1)
--update Standar SET IdAnillasP = 1005, IdBlister = 1, IdCarton = 8 WHERE Id = 2
--update Standar SET IdBlister = 4, IdCarton = 10 WHERE Id = 1004
--select * from Standar

--select distinct Id, Numero from Anzuelo order by Numero asc

--select distinct Id, Tamaño from Anilla order by Tamaño asc

--insert into Anilla(Tamaño) values (0)
--insert into Anzuelo(Numero) values (0)

--SELECT S.Id, S.Modelo, A.Tamaño AnillaA,A.Id AnAnzId,Pit.Tamaño AnillaP, Pit.Id AnPitId, H.Numero AnzSimple,H.Id ASId, HT.Numero AnzTriple, HT.Id ATId, B.Modelo Blister, B.Id idBlister, C.Modelo Carton, C.Id idCarton,P.modelo Piton, P.id idPiton
--FROM Anilla A, Anilla Pit, Anzuelo H, Anzuelo HT, Standar S, Blister B, Carton C, PITON P
--WHERE S.IdAnzueloS = H.Id AND S.IdAnzueloT = HT.Id AND S.IdAnillasA = A.Id AND S.IdAnillasP = Pit.Id AND S.IdCarton = C.Id AND S.IdBlister = B.Id AND S.idPiton = P.id

--delete from Standar where Id = 11

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

--SELECT Codigo, Modelo, C.Color Color, Imagen, Peso, Cantidad, C.Id IdColor, C.Descripcion Descripcion FROM Artificial A, Color C WHERE A.Id_color = C.Id

--SELECT S.id, S.modelo Modelo, A.tamaño AnillaA,Pit.tamaño AnillaP, H.numero AnzSimple, HT.numero AnzTriple, C.modelo Carton, B.modelo Blister, P.modelo Piton
--FROM ANILLA A, ANILLA Pit, ANZUELO H, ANZUELO HT, CARTON C, BLISTER B, STANDAR S, PITON P
--WHERE S.idAnzueloS = H.id AND S.idAnzueloT = HT.id AND S.idAnillasA = A.id AND S.idAnillasP = Pit.id AND S.idCarton = C.id AND S.idBlister = B.id AND S.idPiton = P.id

--SELECT A.Id, Codigo, Modelo, C.Color Color, Imagen, Peso, Cantidad, C.Id IdColor, C.Descripcion Descripcion 
--FROM Artificial A, Color C 
--WHERE A.Id_color = C.Id 
--ORDER BY modelo ASC

--SELECT DISTINCT modelo FROM ARTIFICIAL

--insert into STANDAR (modelo,idAnillasA,idAnillasP,idAnzueloS,idAnzueloT, idBlister,idCarton,idPiton) values ('@model',0,0,0,0,0,0,0)

--SELECT A.Id, Codigo, Modelo, C.Color Color, Imagen, Peso, Cantidad, C.Id IdColor, C.Descripcion Descripcion FROM Artificial A, Color C WHERE A.Id_color = C.Id ORDER BY modelo ASC

SELECT A.Id,R.Numero,R.fechaCreacion Fecha, S.Modelo, C.Color,A.Cantidad FROM Armado A,Color C,Artificial S,Remito R WHERE Id_remito = R.Id AND A.Id_artificial = S.Id AND A.Id_color = C.Id AND R.Numero = 16