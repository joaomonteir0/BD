# BD: Guião 9


## ​9.1
 
### *a)*

```
GO
CREATE PROC removeEmployee @ssn INT 
AS
	BEGIN
		DELETE FROM Company.[Dependent] WHERE Essn=@ssn;
		DELETE FROM Company.Works_on WHERE Essn=@ssn;
		UPDATE Company.Department SET Mgr_ssn=NULL WHERE Mgr_ssn=@ssn;
		UPDATE Company.Employee set Super_ssn=NULL WHERE Super_ssn=@ssn;
		DELETE FROM Company.Employee WHERE Ssn=@ssn;
	END


Preocupações adicionais que devem ser tidas no storage procedure são o update do Mgr_ssn no Department e na tabela Employee.

```

### *b)* 

```
GO
CREATE PROC gestorDep (@ssngestor INT OUTPUT, @numanos INT OUTPUT)
AS
	BEGIN
		SELECT Employee.* FROM Company.Employee INNER JOIN Company.Department ON Company.Employee.Ssn = Company.Department.Mgr_ssn;
		SELECT @mgr_ssn = Department.Mgr_ssn, @worked_yrs = DATEDIFF(year, Mgr_start_date, GETDATE()) FROM Company.Department 
			WHERE Mgr_start_date = (SELECT MIN(Mgr_start_date) from Company.Department);
	END

DECLARE @ssngestor INT;
DECLARE @numanos INT;
EXEC gestorDep @ssngestor OUTPUT, @numanos OUTPUT;
PRINT @ssngestor;
PRINT @numanos;

```

### *c)* 

```
GO
CREATE TRIGGER oneDep ON Company.Department INSTEAD OF INSERT, UPDATE
AS
	BEGIN
		IF EXISTS(SELECT Mgr_ssn, COUNT(*) AS mgrcount FROM DEPARTMENT GROUP BY(Mgr_ssn) HAVING COUNT(*) > 1) 
			BEGIN
				IF (SELECT COUNT(Dnumber) FROM Company.Department WHERE Mgr_ssn=@ssnemp) > 1
					RAISERROR('An employee can only manage one department.', 16, 1);
		    END
    END

```

### *d)* 

```
GO
CREATE TRIGGER dbo.salary on dbo.EMPLOYEE AFTER INSERT, UPDATE
AS
	BEGIN
		SET NOCOUNT ON;

		DECLARE @mgrsalary INT
		DECLARE @dno INT
		DECLARE @ssnemp INT
		DECLARE @empsalary INT
		SELECT @dno=inserted.Dno, @empsalary=inserted.Salary, @ssnemp=inserted.Ssn FROM inserted;

		SELECT @mgrsalary=Salary
		FROM dbo.DEPARTMENT JOIN dbo.EMPLOYEE ON Mgr_ssn=Ssn
		WHERE Dnumber=@dno

		IF (@empsalary > @mgrsalary)
		BEGIN
			UPDATE dbo.EMPLOYEE
			SET Salary=@mgrsalary - 1
			WHERE Ssn=@ssnemp
		END
	END
```

### *e)* 

```
GO
CREATE FUNCTION Company.infoProj (@ssnemp INT) RETURNS @tabela
TABLE([name] VARCHAR(30), [location] VARCHAR(20))
AS
	BEGIN
		INSERT @tabela
			SELECT Company.Project.Pname, Company.Project.Plocation FROM Company.Project
				INNER JOIN Company.Works_on ON Company.Works_on.Pno=Company.Project.Pnumber
				WHERE Works_on.Essn=@ssnemp
		RETURN;
	END

```

### *f)* 

```
CREATE FUNCTION FuncDno (@dno int = 0)
RETURNS TABLE
AS
    RETURN
	(
	SELECT Company.Employee.*
	  FROM Company.Employee
	 WHERE Company.Employee.Dno = @dno
	   AND Employee.Salary > (
	   		SELECT AVG(E.Salary) as Sal_medio
			  FROM Company.Employee E
			 WHERE E.Dno = @dno
		  GROUP BY E.Dno	
		)
	);
GO
```

### *g)* 

```
DROP FUNCTION Budget
GO

GO
CREATE FUNCTION Budget(@dno int) RETURNS @projtable TABLE (pname varchar(15), number int, plocation varchar(15), dnum int, budget decimal(10,2), totalbudget decimal(10,2))
AS
BEGIN

	DECLARE @pname as varchar(15), @number as int, @plocation as varchar(15), @dnum as int, @budget as decimal(10,2), @totalbudget as decimal(10,2);

	DECLARE C CURSOR FAST_FORWARD
	FOR SELECT Pname, Pnumber, Plocation, Dnumber, Sum(Salary*[Hours]/(40*4))
		FROM	Company.DEPARTMENT 
				JOIN Company.PROJECT ON Dnumber=Dnum
				JOIN Company.Works_on ON Pnumber=Pno
				JOIN Company.EMPLOYEE ON Essn=Ssn
		WHERE Dnumber=@dno
		GROUP BY Pname, Pnumber, Plocation, Dnumber;

	OPEN C;

	FETCH C INTO @pname, @number, @plocation, @dnum, @budget;
	SELECT @totalbudget = 0;

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @totalbudget += @budget;
		INSERT INTO @projtable VALUES (@pname, @number, @plocation, @dnum, @budget, @totalbudget)
		FETCH C INTO @pname, @number, @plocation, @dnum, @budget;
	END

	CLOSE C;

	DEALLOCATE C;

	return;
END
GO

	SELECT * 
FROM Budget (3);
GO
```

### *h)* 

```
CREATE TRIGGER DepDelete ON Company.Department
AFTER DELETE
AS
BEGIN
	IF NOT (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'department_deleted'))
		BEGIN
		CREATE TABLE department_deleted(
			Dname varchar(50) not null,
			Dnumber int PRIMARY KEY,
			Mgr_ssn char(12),
			Mgr_start_date DATE
		);
		END
    INSERT INTO dbo.department_deleted
    SELECT * FROM DELETED
END
GO

```

### *i)* 

```
Existem diferenças entre UDFs e Stored Procedures no SQL. UDFs retornam valores, enquanto Stored Procedures não precisam. Stored Procedures são compiladas uma vez e reutilizadas, enquanto UDFs são compiladas a cada uso. Stored Procedures lidam com exceções, mas UDFs não. Stored Procedures usam variáveis temporárias e tabelas, enquanto UDFs não usam tabelas temporárias. Stored Procedures têm parâmetros de entrada e saída, enquanto UDFs só aceitam parâmetros de entrada. Ambos podem simplificar e otimizar o código SQL.
```
