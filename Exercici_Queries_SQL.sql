/* 1. Quantitat de registres de la taula de vols */ 
select count(*) from flights;

/* 2. Retard promig de sortida i arribada segons l’aeroport origen */
select  Origin, avg(ArrDelay) as prom_arribades , avg(DepDelay) as prom_sortides
from flights
group by Origin
order by 1;

/* 3. Retard promig d’arribada dels vols, per mesos, anys i segons l’aeroport origen. */
select  Origin, colYear ,colMonth, avg(ArrDelay) as prom_arribades 
from flights
group by Origin, colYear, ColMonth
order by Origin, colYear ,colMonth;

/* 4. Retard promig d’arribada dels vols, per mesos, anys i segons l’aeroport origen (mateixa consulta que abans i amb el mateix ordre). 
Però a més, ara volen que en comptes del codi de l’aeroport es mostri el nom de la ciutat. */
select City, colYear ,colMonth, avg(ArrDelay) as prom_arribades
from flights  join  USAirports on flights.Origin=USAirports.IATA
group by City, colYear, ColMonth
order by City,colYear ,colMonth;

/* 5. Les companyies amb més vols cancelats, per mesos i any. 
A més, han d’estar ordenades de forma que les companyies amb més cancel·lacions apareguin les primeres.*/
select UniqueCarrier, colYear ,colMonth, count(Cancelled) as total_cancelled
from flights 
where Cancelled is true 
group by UniqueCarrier, colYear, ColMonth
order by total_cancelled desc ,UniqueCarrier,colYear ,colMonth;

/* 6. L’identificador dels 10 avions que més distància han recorregut fent vols. */
select TailNum, sum(Distance) as totalDistance
from flights 
where Cancelled is false 
	and TailNum <>'' /********* Existen vuelos sin número de avión : En ZIP de carga no hay datos en ese campo*/
group by TailNum
order by sum(Distance) desc
limit 10;


/* 7. Companyies amb el seu retard promig només d’aquelles les quals els seus vols arriben al seu destí amb un retràs promig major de 10 minuts */
select UniqueCarrier, avg(ArrDelay) as avgDelay
from flights 
group by UniqueCarrier
having avgDelay > 10
order by avgDelay desc ;


