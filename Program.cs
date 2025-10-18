using Microsoft.Data.Sqlite;
string connectionString = "Data Source=tienda.db;";

using (SqliteConnection connection = new SqliteConnection(connectionString))
{
  connection.Open();


  // INSERT
  string insertQuery = "INSERT INTO producto (Descripcion, Precio) VALUES ('Cable Inalámbrico',500)";
  using (SqliteCommand insertCmd = new SqliteCommand(insertQuery, connection))
  {
    int numFilas = insertCmd.ExecuteNonQuery();
    Console.WriteLine($"Insertado {numFilas} nuevo producto");
  }


  // SELECT
  string selectQuery = "SELECT * FROM producto";
  using (SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection))
  using (SqliteDataReader reader = selectCmd.ExecuteReader())
  {
    while (reader.Read())
      Console.WriteLine($"IdProducto: {reader["IdProducto"]}, Descripcion: {reader["Descripcion"]}, Precio: {reader["Precio"]}");
  }

  // DELETE
  string deleteQuery = "DELETE FROM producto WHERE descripcion = 'Cable Inalámbrico'";
  using (SqliteCommand deleteCmd = new SqliteCommand(deleteQuery, connection))
  {
    int numFilas = deleteCmd.ExecuteNonQuery();
    Console.WriteLine($"{numFilas} filas eliminadas");
  }


  connection.Close();
}

// dotnet add package Microsoft.Data.SQLite