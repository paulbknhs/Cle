@echo off
echo Stopping SQL Server...
net stop MSSQL$SQLEXPRESS
echo SQL Server stopped.

setlocal
set "datestamp=%date:/=-%"
set "datestamp=%datestamp: =_%"
set "datestamp=%datestamp:.=%"
set "backup_file=C:\Program Files\Microsoft SQL Server\BACKUP\master_%datestamp%.mdf"

echo Copying master database to %backup_file%...
copy "C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\master.mdf" "%backup_file%"
echo Master database copied.

echo Starting SQL Server...
net start MSSQL$SQLEXPRESS
echo SQL Server started.
