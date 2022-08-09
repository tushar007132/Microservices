TASK 2

-----------------------------

1)  select * from emp
    where ename like 'A%'

2)  select * from emp
    where mgrid is null;

3)  select  Ename,Empno,sal
    from Emp
    where sal between 1200 and 1400;

4)  update Emp
    set sal=sal*0.10
    from Emp e
    left join Dept d
    on e.deptno = d.deptno
    where d.dname='research'

    select * from Emp;



5)  select count(*) as Clerk_Employee_Count from Emp
    where job = 'clerk'

6)  select count(*) as number , avg(sal) as average_salary , job
    from Emp 
    group by job


7) select TOP 1 sal as Highest_sal
   from Emp
   order by sal desc;

   select TOP 1 sal as Lowest_sal
   from Emp
   order by sal;

8) SELECT * FROM Dept
   WHERE NOT EXISTS 
   (select deptno FROM Emp where dept.deptno=emp.deptno);



9) select Ename,sal 
   from Emp
   where job ='Analyst' and sal>=1200 and deptno=20 
   order by Ename asc;


10) select d.dname,d.deptno,SUM(e.sal) as total_sal
    from dept d
    left join Emp e
    on e.deptno = d.deptno
    group by d.deptno,d.dname

11) select sal 
    from Emp
    where Ename = 'SMITH' or Ename='MILLER';

12) Select * from Emp
    where Ename like 'A%' OR Ename like '%M'



13) select 12*sal as Yearly_salary
    from Emp
    where ename = 'SMITH'


14) select * 
    from Emp
    where sal NOT between 1500 and 2850
