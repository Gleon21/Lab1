CREATE DATABASE Notas;
GO
USE Notas;
Go
CREATE TABLE TblNotasEstudiante(
	TblNotasEstudianteId int Primary Key NOT NULL,
	NombreEstudiante Varchar(100),
	lab1 Decimal,
	lab2 Decimal,
	lab3 Decimal,
	par1 Decimal,
	par2 Decimal,
	par3 Decimal

)
USE Notas
select * from TblNotasEstudiante

USE Notas
delete from TblNotasEstudiante 
where TblNotasEstudianteId = 611246782
