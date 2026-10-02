using Npgsql;

namespace dbgrupb;

class Program
{

    static void Main(string[] args)
    {
        // calculo el connection string
        var Host = "database-1.cnyixo9r8pea.us-east-1.rds.amazonaws.com";
        var User = "postgres";
        var DBname = "postgres";
        var Password = "cendrassos01";
        var Port = "5432";
        
        string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);

        // objecte connexió
        using var conn = new NpgsqlConnection(connString);
        conn.Open();

        for(int codi = 0; codi < 1000; codi++)
        {
            using var command = new NpgsqlCommand(
                $"insert into alumnes (codi, non) values ({codi}, 'Alumne num {codi}')", conn);
            command.ExecuteNonQuery();            
        }

        
    }
}