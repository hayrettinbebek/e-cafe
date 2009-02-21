sqlcmd -S "ERNIE-HOME\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE_0221" -i DROP.sql -o output_drop.log

sqlcmd -S "ERNIE-HOME\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE_0221" -i update_001.sql -o output001.log

sqlcmd -S "ERNIE-HOME\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE_0221" -i update_002.sql -o output001.log

sqlcmd -S "ERNIE-HOME\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE_0221" -i END.sql -o output_end.log