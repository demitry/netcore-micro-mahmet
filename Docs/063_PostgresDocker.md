[061]



- project -> Add Docker Support

- project -> Add container orchestration Support



[063]



Connect to docker postgres and list databases

```
docker ps
docker exec -it c950c1f2ffc5 bash
psql -U postgres
\l
\c
\d
```

Log

```
C:\Users\dmitry>docker ps
CONTAINER ID   IMAGE      COMMAND                  CREATED        STATUS          PORTS                    NAMES
c950c1f2ffc5   postgres   "docker-entrypoint.s…"   32 hours ago   Up 31 minutes   0.0.0.0:5432->5432/tcp   catalogdb

C:\Users\dmitry>docker exec -it c950c1f2ffc5 bash
root@c950c1f2ffc5:/# psql -U postgres
psql (16.0 (Debian 16.0-1.pgdg120+1))
Type "help" for help.

postgres=#
postgres=# \l
                                                      List of databases
   Name    |  Owner   | Encoding | Locale Provider |  Collate   |   Ctype    | ICU Locale | ICU Rules |   Access privileges
-----------+----------+----------+-----------------+------------+------------+------------+-----------+-----------------------
 CatalogDb | postgres | UTF8     | libc            | en_US.utf8 | en_US.utf8 |            |           |
 postgres  | postgres | UTF8     | libc            | en_US.utf8 | en_US.utf8 |            |           |
 template0 | postgres | UTF8     | libc            | en_US.utf8 | en_US.utf8 |            |           | =c/postgres          +
           |          |          |                 |            |            |            |           | postgres=CTc/postgres
 template1 | postgres | UTF8     | libc            | en_US.utf8 | en_US.utf8 |            |           | =c/postgres          +
           |          |          |                 |            |            |            |           | postgres=CTc/postgres
(4 rows)

postgres=# \c CatalogDb
You are now connected to database "CatalogDb" as user "postgres".
CatalogDb=# \d
Did not find any relations.
CatalogDb=#
```
