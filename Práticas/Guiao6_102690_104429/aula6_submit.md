# BD: Guião 6

## Problema 6.1

### *a)* Todos os tuplos da tabela autores (authors);

```
SELECT * FROM authors;
```

### *b)* O primeiro nome, o último nome e o telefone dos autores;

```
SELECT au_fname, au_lname, phone FROM authors;
```

### *c)* Consulta definida em b) mas ordenada pelo primeiro nome (ascendente) e depois o último nome (ascendente); 

```
SELECT au_fname, au_lname, phone FROM authors ORDER BY au_fname, au_lname;
```

### *d)* Consulta definida em c) mas renomeando os atributos para (first_name, last_name, telephone); 

```
SELECT au_fname AS first_name, au_lname AS last_name, phone AS telephone FROM authors ORDER BY first_name, last_name;
```

### *e)* Consulta definida em d) mas só os autores da Califórnia (CA) cujo último nome é diferente de ‘Ringer’; 

```
SELECT au_fname AS first_name, au_lname AS last_name, phone AS telephone FROM authors WHERE (state='CA' AND au_lname != 'Ringer') ORDER BY first_name, last_name;
```

### *f)* Todas as editoras (publishers) que tenham ‘Bo’ em qualquer parte do nome; 

```
SELECT * FROM publishers WHERE pub_name LIKE '%Bo%';
```

### *g)* Nome das editoras que têm pelo menos uma publicação do tipo ‘Business’; 

```
SELECT DISTINCT pub_name FROM publishers, titles WHERE type='Business' AND titles.pub_id=publishers.pub_id;
```

### *h)* Número total de vendas de cada editora; 

```
SELECT pub_name, SUM(ytd_sales) AS total_sales FROM ((sales INNER JOIN titles ON sales.title_id = titles.title_id) INNER JOIN publishers ON publishers.pub_id = titles.pub_id) GROUP BY pub_name;
```

### *i)* Número total de vendas de cada editora agrupado por título; 

```
SELECT pub_name, title, ytd_sales FROM (publishers INNER JOIN titles ON publishers.pub_id = titles.pub_id);
```

### *j)* Nome dos títulos vendidos pela loja ‘Bookbeat’; 

```
SELECT title FROM ((titles INNER JOIN sales ON titles.title_id = sales.title_id) INNER JOIN stores ON sales.stor_id = store_stor_id) WHERE stor_name = 'Bookbeat';
```

### *k)* Nome de autores que tenham publicações de tipos diferentes; 

```
SELECT au_fname, au_lname FROM ((authors INNER JOIN titleauthor ON author.au_id = titleauthor.au_id) INNER JOIN titles ON titles.title_id=titleauthor.title_id) GROUP BY au_fname, au_lname HAVING COUNT(DISTINCT type) > 1;
```

### *l)* Para os títulos, obter o preço médio e o número total de vendas agrupado por tipo (type) e editora (pub_id);

```
SELECT titles.pub_id, type, COUNT(ytd_sales) AS qtd_sales, AVG(price) AS preco_medio FROM publishers INNER JOIN titles ON titles.pub_id=publisher.pub_id GROUP BY titles.pub_id, type;
```

### *m)* Obter o(s) tipo(s) de título(s) para o(s) qual(is) o máximo de dinheiro “à cabeça” (advance) é uma vez e meia superior à média do grupo (tipo);

```
SELECT type FROM titles GROUP BY type HAVING MAX(advance) > 1.5*AVG(advance);
```

### *n)* Obter, para cada título, nome dos autores e valor arrecadado por estes com a sua venda;

```
SELECT au_fname, au_lname, ytd_sales*price*royalty/100 as valor_arrecadado FROM ((titles INNER JOIN titleauthor.title_id = titles.title_id) INNER JOIN authors ON authors.au_id = titleauthor.au_id);
```

### *o)* Obter uma lista que incluía o número de vendas de um título (ytd_sales), o seu nome, a faturação total, o valor da faturação relativa aos autores e o valor da faturação relativa à editora;

```
SELECT title, ytd_sales*price AS faturacao, ytd_sales*price*royalty/100 AS auths_revenue, price*ytd_sales*-price*ytd_sales*royalty/100 AS publisher_revenue FROM titles;
```

### *p)* Obter uma lista que incluía o número de vendas de um título (ytd_sales), o seu nome, o nome de cada autor, o valor da faturação de cada autor e o valor da faturação relativa à editora;

```
SELECT title, ytd_sales, CONCAT(au_fname, ' ', au_lname) AS author, ytd_sales*price AS faturacao, ytd_sales*price*royalty/100 AS auths_revenue, price*ytd_sales*-price*ytd_sales*royalty/100 AS publisher_revenue FROM ((titles INNER JOIN titleauthor.title_id = titles.title_id) INNER JOIN authors ON authors.au_id = titleauthor.au_id) GROUP BY title, ytd_sales, price, au_fname, au_lname, royalty;
```

### *q)* Lista de lojas que venderam pelo menos um exemplar de todos os livros;

```
SELECT stor_name, count(title) AS nTitles FROM (stores INNER JOIN sales ON sales.stor_id = stores.stor_id) INNER JOIN titles ON sales.title_id = titles.title_id GROUP BY stores.stor_name HAVING COUNT(title)=(SELECT COUNT(title_id) FROM titles);
```

### *r)* Lista de lojas que venderam mais livros do que a média de todas as lojas;

```
SELECT stor_name FROM stores WHERE stor_id IN (SELECT stor_id FROM sales GROUP BY stor_id HAVING SUM(qty) > (SELECT AVG(total_sales) AS sales_avg FROM (SELECT stor_id, SUM(qty) as total_sales FROM sales GROUP BY stor_id) AS sales_data));
```

### *s)* Nome dos títulos que nunca foram vendidos na loja “Bookbeat”;

```
SELECT title FROM titles EXCEPT (SELECT DISTINCT title FROM ((titles INNER JOIN sales ON sales.title_id=titles.title_id)
INNER JOIN stores ON stores.stor_id=sales.stor_id) WHERE stor_name='Bookbeat');
```

### *t)* Para cada editora, a lista de todas as lojas que nunca venderam títulos dessa editora; 

```
(SELECT pub_name, stor_name FROM publishers, stores GROUP BY pub_name, stor_name) EXCEPT (SELECT pub_name, stor_name FROM (((publishers	INNER JOIN titles ON publishers.pub_id=titles.pub_id) INNER JOIN sales  ON titles.title_id=sales.title_id) INNER JOIN stores ON sales.stor_id=stores.stor_id) GROUP BY pub_name, stor_name);
```

## Problema 6.2

### ​5.1

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_1_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_1_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
SELECT Pname, Ssn, Fname, Lname FROM Project
INNER JOIN Works_on ON Pno=Pnumber
INNER JOIN Employee ON Essn=Ssn;
```

##### *b)* 

```
SELECT Fname, Lname FROM Employee
WHERE Super_ssn=(SELECT Ssn FROM Employee WHERE Fname='Carlos' AND Minit='D' AND Lname='Gomes')
```

##### *c)* 

```
WITH Worked_Table AS (
    SELECT Pno, SUM(Hours) AS total_worked
    FROM Works_on
    GROUP BY Pno
)

SELECT P.Pname, WT.total_worked
FROM Project P
JOIN Worked_Table WT
ON P.Pnumber = WT.Pno;

```

##### *d)* 

```
WITH Dep3_Empls AS (
    SELECT Fname, Lname, Ssn
    FROM Employee
    WHERE Dno = 3
)

SELECT E.Fname, E.Lname
FROM Project P
JOIN Works_on WO ON P.Pnumber = WO.Pno
JOIN Dep3_Empls E ON WO.Essn = E.Ssn
WHERE WO.Hours > 20;


```

##### *e)* 

```
SELECT Fname, Minit, Lname FROM Employee
LEFT JOIN Works_on ON Essn=Ssn
WHERE Pno IS NULL

```

##### *f)* 

```
SELECT Dname, AVG(Salary) AS Avg_Salary FROM Department
INNER JOIN (SELECT * FROM Employee WHERE Sex='F') AS F_DEP ON Dnumber=Dno
GROUP BY Dname

```

##### *g)* 

```
SELECT Fname, Minit, Lname FROM Employee
INNER JOIN (
			SELECT Essn, COUNT(Essn) AS count_dep FROM Dependent
			GROUP BY Essn
			HAVING COUNT(Essn)>1
			) AS TWOORMORE
ON Ssn=Essn

```

##### *h)* 

```
SELECT Fname, Minit, Lname FROM Department
INNER JOIN (
			SELECT E.Fname, E.Minit, E.Lname, E.Ssn FROM Employee AS E
			LEFT JOIN Dependent ON Ssn=Essn
			WHERE Essn IS NULL
			) AS NODEP_EMP
ON Mgr_ssn=Ssn
```

##### *i)* 

```
SELECT Fname, Minit, Lname, e_Address FROM Employee
INNER JOIN (
			SELECT * FROM Project
			INNER JOIN Dept_locations ON Dnum=Dnumber
			WHERE Dlocation!='Aveiro' AND Plocation='Aveiro'
			) AS PROJECT_LST
ON Dno=Dnum
```

### 5.2

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_2_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_2_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
... Write here your answer ...
```

##### *b)* 

```
... Write here your answer ...
```


##### *c)* 

```
... Write here your answer ...
```


##### *d)* 

```
... Write here your answer ...
```

### 5.3

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_3_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_3_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
... Write here your answer ...
```

##### *b)* 

```
... Write here your answer ...
```


##### *c)* 

```
... Write here your answer ...
```


##### *d)* 

```
... Write here your answer ...
```

##### *e)* 

```
... Write here your answer ...
```

##### *f)* 

```
... Write here your answer ...
```
