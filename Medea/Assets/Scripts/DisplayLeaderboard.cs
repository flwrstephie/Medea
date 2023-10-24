using UnityEngine;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;

public class DisplayLeaderboard : MonoBehaviour
{
    public Text[] rankTexts;
    public Text[] playerNameTexts;
    public Text[] scoreTexts;
    private string databaseName = "URI=file:Leaderboard.db";

    private void Start()
    {
        DisplayTop10Leaderboard();
    }

    private void DisplayTop10Leaderboard()
    {
        using (IDbConnection dbConnection = new SqliteConnection(databaseName))
        {
            dbConnection.Open();
            using (IDbCommand dbCommand = dbConnection.CreateCommand())
            {
                // Select the top 10 entries ordered by Score in descending order.
                dbCommand.CommandText = "SELECT PlayerName, Score FROM Leaderboard ORDER BY Score DESC LIMIT 10";
                using (IDataReader reader = dbCommand.ExecuteReader())
                {
                    int rank = 1;
                    while (reader.Read() && rank <= rankTexts.Length)
                    {
                        string playerName = reader.GetString(0);
                        int score = reader.GetInt32(1);

                        // Assign the data to different Text components on separate GameObjects.
                        rankTexts[rank - 1].text = rank.ToString();
                        playerNameTexts[rank - 1].text = playerName;
                        scoreTexts[rank - 1].text = score.ToString();

                        rank++;
                    }
                }
            }
        }
    }
}
