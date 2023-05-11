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
GO

```

### *g)* 

```
... Write here your answer ...
```

### *h)* 

```
... Write here your answer ...
```

### *i)* 

```
... Write here your answer ...
```
