1)
select * from EMP
where job='MANAGER';

2)
select ename,sal
from EMP
where sal>1000

3)
select ename,sal 
from Emp
where ename!='JAMES'

4)
select *
from emp
where ename like 'S%'

5)
select *
from emp
where ename like '%A%'

6)
select *
from emp
where ename like '__L%'

7)
select (sal*12/365) as daily_wage
from emp
where ename='jones'

8)
select sum(sal) as totalSalary
from EMP;

9)
select avg(sal*12) as AverageAnuualSal
from EMP;

10)
select Ename,job,sal,deptno
from emp
where job!='salesman' and deptno=30

11)
select distinct(deptno)
from emp;

12)
select ename as Employee,sal as monthlysalary
from emp
where sal>1500 and deptno IN (10,30);

13)
select ename,job,sal
from emp
where job in ('MANAGER','Analyst') and sal not in (1000,3000,5000)

14)
select ename,sal,comm
from emp
where comm>=sal*0.10

15)

select ename 
from emp
where ename like '%l%l%' and (deptno=30 or mgrid=7782);


16)


select ename,COUNT(empno) AS 'NUMBER'
from emp
where DATEDIFF(MONTH,hiredate,GETDATE())/12 BETWEEN 30 AND 40
GROUP BY CUBE(eNAME)


17)

select emp.ename,dept.dname
from emp 
join dept
on emp.deptno = dept.deptno
order by dept.dname asc ,emp.ename desc;

18)

select datediff(MONTH,hiredate,GETDATE())/12 as Experience
from emp
where ename='MILLER'
