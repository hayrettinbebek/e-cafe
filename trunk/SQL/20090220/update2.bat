sqlcmd -S "ERNIE-HOME\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE_0220" -i DROP.sql -o output_drop.log

sqlcmd -S "ERNIE-HOME\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE_0220" -i update001.sql -o output001.log

sqlcmd -S "ERNIE-HOME\SQLEXPRESS" -U "sa" -P "x" -d "ECAFE_0220" -i END.sql -o output_end.log