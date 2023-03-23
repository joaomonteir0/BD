# BD: Guião 5


## ​Problema 5.1
 
### *a)*

```
ListEx1a = project ⨝ Dno = Dnum employee
π Pname, Ssn, Fname, Lname (ListEx1a)
```


### *b)* 

```
CarlosDGomes = π Mgr_ssn←Ssn (σ Fname='Carlos' ∧ Minit='D' ∧ Lname='Gomes' (employee))
ListEx1b = employee ⨝ Super_ssn = Mgr_ssn CarlosDGomes
π Fname, Lname (ListEx1b)
```


### *c)* 

```
ListEx1c = γ Pno; sum(Hours) -> totalHours works_on
π Pname, totalHours (project ⨝ Pnumber = Pno ListEx1c)
```


### *d)* 

```
π employee.Fname σ project.Pname = 'Aveiro Digital' ∧ works_on.Hours > 20 ∧ employee.Dno = 3 
((project) ⟖ project.Pnumber = works_on.Pno (works_on) ⟕ works_on.Essn = employee.Ssn (employee))
```


### *e)* 

```
π Fname, Lname (σ Pno = null (employee ⟕ Ssn = Essn works_on))
```


### *f)* 

```
γ department.Dname; avg(employee.Salary) -> avgSalary σ employee.Sex = 'F' 
(employee ⟕ employee.Dno = department.Dnumber department)
```


### *g)* 

```
ListEx1g = σ numDep > 1 (γ Essn; count(Essn) -> numDep dependent)
π Fname, Lname (ListEx1g ⨝ Essn = Ssn employee)
```


### *h)* 

```
ListEx1h =  σ Essn = null (dependent ⟖ Essn=Ssn employee)
π Fname, Lname (department ⨝ Mgr_ssn=Ssn ListEx1h)
```


### *i)* 

```
ListEx1i = σ Dlocation != 'Aveiro' ∧ Plocation = 'Aveiro' (project ⨝ Dnum=Dnumber dept_location)
π Fname, Lname, Address (employee ⨝ Dno=Dnum ListEx1i)

```


## ​Problema 5.2

### *a)*

```
... Write here your answer ...
```

### *b)* 

```
... Write here your answer ...
```


### *c)* 

```
... Write here your answer ...
```


### *d)* 

```
... Write here your answer ...
```


## ​Problema 5.3

### *a)*

```
... Write here your answer ...
```

### *b)* 

```
... Write here your answer ...
```


### *c)* 

```
... Write here your answer ...
```


### *d)* 

```
... Write here your answer ...
```

### *e)* 

```
... Write here your answer ...
```

### *f)* 

```
... Write here your answer ...
```
