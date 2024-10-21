# apiProject

Luego de restaurar la base de datos, ejecutar la siguiente consulta:
``` sql
CREATE LOGIN userdbsql   
    WITH PASSWORD = '1234';  
 
CREATE USER userdbsql FOR LOGIN userdbsql   
    WITH DEFAULT_SCHEMA = dbo;  
GO
```

Revisar el archivo Web.config en: data source=DESKTOP-IACUI2U
``` xml
<add name="DB_FLUJOCAJAEntities" connectionString="metadata=res://*/dbFlujoModel.csdl|res://*/dbFlujoModel.ssdl|res://*/dbFlujoModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-IACUI2U;initial catalog=DB_FLUJOCAJA;user id=userdbsql;password=1234;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
```