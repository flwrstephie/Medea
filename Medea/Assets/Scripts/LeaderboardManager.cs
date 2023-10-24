using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{

    private string databaseName = "URI=file:Leaderboard.db";

    // Start is called before the first frame update
    void Start()
    {

        CreateDatabase();
    }

    public void CreateDatabase()
    {
        using (var connection = new SqliteConnection(databaseName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS Leaderboard (PlayerName VARCHAR(20), Score INT);";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public void AddScore(string PlayerName, int score)
    {
        using (IDbConnection dbConnection = new SqliteConnection(databaseName))
        {
            dbConnection.Open();

            using (IDbCommand dbCommand = dbConnection.CreateCommand())
            {
                // Assuming that the score is already generated when the player loses the game.
                dbCommand.CommandText = "INSERT INTO Leaderboard (PlayerName, Score) VALUES (@PlayerName, @Score)";
                dbCommand.Parameters.Add(new SqliteParameter("@PlayerName", PlayerName));
                dbCommand.Parameters.Add(new SqliteParameter("@Score", score));
                dbCommand.ExecuteNonQuery();
            }
        }
    }

}