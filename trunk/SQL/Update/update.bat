sqlcmd -S "ERNIE-NB\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE" -i DROP.sql -o output_drop.log

sqlcmd -S "ERNIE-NB\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE" -i update_001.sql -o output001.log
sqlcmd -S "ERNIE-NB\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE" -i update_002.sql -o output001.log
sqlcmd -S "ERNIE-NB\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE" -i update_003.sql -o output001.log
sqlcmd -S "ERNIE-NB\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE" -i update_004.sql -o output001.log


sqlcmd -S "ERNIE-NB\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE" -i END.sql -o output_end.log