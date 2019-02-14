FROM mysql:5.7.25
EXPOSE 3006
COPY ./RestASPNETCORE/db/migrations/ /home/database
COPY ./RestASPNETCORE/db/dataset/ /home/database
COPY ./RestASPNETCORE/ci/init_database.sh /docker-entrypoint-initdb.d/backup.sql