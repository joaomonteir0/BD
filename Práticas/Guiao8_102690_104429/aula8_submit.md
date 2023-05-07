# BD: Guião 8


## ​8.1. Complete a seguinte tabela.
Complete the following table.

| #    | Query                                                        | Rows  | Cost  | Pag. Reads | Time (ms) | Index used                       | Index Op.                                       | Discussion |
| :--- | :----------------------------------------------------------- | :---- | :---- | :--------- | :-------- | :------------------------------- | :---------------------------------------------- | :--------- |
| 1    | SELECT * from Production.WorkOrder                           | 72591 | 0.484 | 531        | 1171      | …                                | Clustered Index Scan                            |            |
| 2    | SELECT * from Production.WorkOrder where WorkOrderID=1234    | 1     | 0,002 | 13         | 38        | PK                               | Clustered Index Seek                            |            |
| 3.1  | SELECT * FROM Production.WorkOrder WHERE WorkOrderID between 10000 and 10010 | 11    | 0,002 | 13         | 110       | PK                               | Clustered Index Seek                            |            |
| 3.2  | SELECT * FROM Production.WorkOrder WHERE WorkOrderID between 1 and 72591 | 72591 | 0,484 | 542        | 1343      | PK                               | Clustered Index Seek                            |            |
| 4    | SELECT * FROM Production.WorkOrder WHERE StartDate = '2007-06-25' | 55    | 0,520 | 542        | 251       | PK                               | Clustered Index Scan                            |            |
| 5    | SELECT * FROM Production.WorkOrder WHERE ProductID = 757     | 9     | 0,003 | 31         | 115       | ProductID                        | Non Clustered Index Seek / Clustered Key Lookup |            |
| 6.1  | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 757 | 9     | 0,006 | 16         | 3         | ProductID covered (Start Date)   | Non Clustered Index Seek                        |            |
| 6.2  | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 945 | 1105  | 0,006 | 20         | 109       | ProductID covered (Start Date)   | Non Clustered Index Seek                        |            |
| 6.3  | SELECT WorkOrderID FROM Production.WorkOrder WHERE ProductID = 945 AND StartDate = '2006-01-04' | 1     | 0,016 | 22         | 5         | ProductID covered (Start Date)   | Non Clustered Index Seek                        |            |
| 7    | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 945 AND StartDate = '2006-01-04' | 1     | 0,003 | 23         | 59        | ProductID and StartDate          | Non Clustered Index Seek twice                  |            |
| 8    | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 945 AND StartDate = '2006-01-04' | 1     |       | 16         | 6         | Composite (ProductID, StartDate) | Non Clustered Index Seek                        |            |

## ​8.2.

### a)

```
... Write here your answer ...
```

### b)

```
... Write here your answer ...
```

### c)

```
... Write here your answer ...
```

### d)

```
... Write here your answer ...
```

### e)

```
... Write here your answer ...
```

## ​8.3.

```
... Write here your answer ...
```
