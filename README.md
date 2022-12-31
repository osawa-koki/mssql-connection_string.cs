# mssql-connection_string.cs

なんか、接続文字列を生成するためのクラスがあるとの噂が、、、  

## 説明

```cs
SqlConnectionStringBuilder sqlConnectionStringBuilder = new();
sqlConnectionStringBuilder.DataSource = "localhost";
sqlConnectionStringBuilder.UserID = "userid";
sqlConnectionStringBuilder.Password = "password";
sqlConnectionStringBuilder.InitialCatalog = "database";
sqlConnectionStringBuilder.TrustServerCertificate = true;

string connection_string = sqlConnectionStringBuilder.ConnectionString;

Console.WriteLine(connection_string);

// -> Data Source=localhost;Initial Catalog=database;User ID=userid;Password=password;TrustServerCertificate=True
```
