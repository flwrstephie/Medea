using UnityEngine;
using UnityEngine.UI;

public class ScoreSubmissionUI : MonoBehaviour
{
    public InputField playerNameInput;
    public Text playerScore;
    public LeaderboardManager leaderboardManager;

    public void SubmitScore()
    {
        string playerName = playerNameInput.text;
        int score = int.Parse(playerScore.text); // Assuming the player inputs a valid integer.

        // Call the AddScore method from the leaderboard manager.
        leaderboardManager.AddScore(playerName, score);
        Debug.Log("Score Added!");
    }
}
