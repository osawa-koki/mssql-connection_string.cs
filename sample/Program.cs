using System;
using System.Data.SqlClient;

SqlConnectionStringBuilder sqlConnectionStringBuilder = new();
sqlConnectionStringBuilder.DataSource = "localhost";
sqlConnectionStringBuilder.UserID = "userid";
sqlConnectionStringBuilder.Password = "password";
sqlConnectionStringBuilder.InitialCatalog = "database";
sqlConnectionStringBuilder.TrustServerCertificate = true;

string connection_string = sqlConnectionStringBuilder.ConnectionString;

Console.WriteLine(connection_string);

// -> Data Source=localhost;Initial Catalog=database;User ID=userid;Password=password;TrustServerCertificate=True
