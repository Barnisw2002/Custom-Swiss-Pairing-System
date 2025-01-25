using Custom_Swiss_Pairing_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Custom_Swiss_Pairing_System.DAO
{
    internal class JatekosSqliteDao : IJatekosDao
    {
        public string ConnectionString { get; set; }

        public JatekosSqliteDao(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public JatekosSqliteDao() { }

        public bool addJatekos(Jatekos jatekos)
        {
            if (jatekos == null)
                return false;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO Jatekos (Nev, Nem, SzuletesiIdo, Rang, Regio, Elkerules) 
                    VALUES (@Nev, @Nem, @SzuletesiIdo, @Rang, @Regio, @Elkerules)";
                using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Nev", jatekos.Nev);
                    insertCommand.Parameters.AddWithValue("@Nem", jatekos.Nem);
                    insertCommand.Parameters.AddWithValue("@SzuletesiIdo", jatekos.SzuletesiIdo);
                    insertCommand.Parameters.AddWithValue("@Rang", jatekos.Rang);
                    insertCommand.Parameters.AddWithValue("@Regio", jatekos.Regio);
                    insertCommand.Parameters.AddWithValue("@Elkerules", jatekos.Elkerules);

                    return insertCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool deleteJatekos(Jatekos jatekos)
        {
            if (jatekos == null) return false;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Jatekos WHERE ID = @ID";
                using (var deleteCommand = new SQLiteCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@ID", jatekos.ID);
                    return deleteCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        public IEnumerable<Jatekos> getJatekosok()
        {
            var jatekosok = new List<Jatekos>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID, Nev, Nem, SzuletesiIdo, Rang, Regio, Elkerules FROM Jatekos";
                using (var selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var jatekos = new Jatekos
                            {
                                ID = reader.GetInt64(0),
                                Nev = reader.GetString(1),
                                Nem = reader.GetString(2),
                                SzuletesiIdo = reader.GetString(3),
                                Rang = reader.GetString(4),
                                Regio = reader.GetString(5),
                                Elkerules = reader.GetString(6)
                            };
                            jatekosok.Add(jatekos);
                        }
                    }
                }
            }
            return jatekosok;
        }

        public bool modifyJatekos(Jatekos jatekos)
        {
            if (jatekos == null) return false;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string updateQuery = @"
                    UPDATE Jatekos 
                    SET Nev = @Nev, Nem = @Nem, SzuletesiIdo = @SzuletesiIdo, Rang = @Rang, Regio = @Regio, Elkerules = @Elkerules 
                    WHERE ID = @ID";
                using (var updateCommand = new SQLiteCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@ID", jatekos.ID);
                    updateCommand.Parameters.AddWithValue("@Nev", jatekos.Nev);
                    updateCommand.Parameters.AddWithValue("@Nem", jatekos.Nem);
                    updateCommand.Parameters.AddWithValue("@SzuletesiIdo", jatekos.SzuletesiIdo);
                    updateCommand.Parameters.AddWithValue("@Rang", jatekos.Rang);
                    updateCommand.Parameters.AddWithValue("@Regio", jatekos.Regio);
                    updateCommand.Parameters.AddWithValue("@Elkerules", jatekos.Elkerules);

                    return updateCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        public Jatekos getJatekosById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID, Nev, Nem, SzuletesiIdo, Rang, Regio, Elkerules FROM Jatekos WHERE ID = @ID";
                using (var selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@ID", id);

                    using (var reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Jatekos
                            {
                                ID = reader.GetInt64(0),
                                Nev = reader.GetString(1),
                                Nem = reader.GetString(2),
                                SzuletesiIdo = reader.GetString(3),
                                Rang = reader.GetString(4),
                                Regio = reader.GetString(5),
                                Elkerules = reader.GetString(6)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int countJatekos()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM Jatekos";
                using (var countCommand = new SQLiteCommand(countQuery, connection))
                {
                    return Convert.ToInt32(countCommand.ExecuteScalar());
                }
            }
        }
    }
}
