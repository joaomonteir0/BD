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
π nome (σ fornecedor=null (encomenda ⟗ fornecedor = nif fornecedor))
```

### *b)* 

```
π nome, media (γ codProd;avg(unidades)-> media (item) ⨝codProd=codigo produto)
```


### *c)* 

```
γ;avg(num_prod)->media (γ numEnc;count(codProd)-> num_prod (item))
```


### *d)* 

```
temp1 = γ codProd,fornecedor;sum(unidades)->quantidade (item ⨝numEnc=numero encomenda)
π fornecedor.nome,produto.nome,quantidade (temp1 ⨝fornecedor=nif fornecedor ⨝codProd=codigo produto)
```


## ​Problema 5.3

### *a)*

```
π nome, paciente.numUtente (σ numPresc=null (prescricao ⟗prescricao.numUtente=paciente.numUtente paciente))
```

### *b)* 

```
γ especialidade; count(numPresc) -> totalP (prescricao ⨝numMedico=numSNS medico)
```


### *c)* 

```
γ nome; count(numPresc)->totalP (prescricao ⨝ farmacia = nome farmacia)
```


### *d)* 

```
F906 = π farmaco.nome (σ numRegFarm = 906 (farmaco ⨝ numRegFarm = numReg farmaceutica))
P906 = π nomeFarmaco (σ numRegFarm = 906 presc_farmaco)
F906 - P906
```

### *e)* 

```
qtdFARMACOS = σ farmacia != null (presc_farmaco ⨝ presc_farmaco.numPresc = prescricao.numPresc prescricao)
ListEx3e = γ farmacia, numRegFarm; count(numRegFarm)->qtd_farmacos qtdFARMACOS
π farmacia,nome,qtd_farmacos (ListEx3e ⨝numRegFarm=numReg farmaceutica)
```

### *f)* 

```
ListEx3f = σ numMed > 1 (γ numUtente; count(numMedico)-> numMed (π numUtente,numMedico prescricao))
π nome (paciente ⨝ paciente.numUtente = prescricao.numUtente ListEx3f)
```
