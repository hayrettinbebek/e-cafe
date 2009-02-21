if dbo.CheckVersion(3) = 1 begin
print 'OK'
end else begin print'nem OK'
end
UPDATE VERSION  SET DB_VER = '004'






