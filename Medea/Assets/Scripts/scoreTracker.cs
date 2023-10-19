using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public int score;
    public int hp=5;
    public Text scoreText;
    public Text hpText;

    public float scoreIncrementInterval = 1.0f; // Interval in seconds to increment the score.
    private float nextScoreIncrementTime;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial score and calculate the next score increment time.
        score = 0;
        nextScoreIncrementTime = Time.time + scoreIncrementInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if it's time to increment the score.
        if (Time.time >= nextScoreIncrementTime)
        {
            IncrementScore(100); // Increment the score by 100 every second.
            nextScoreIncrementTime = Time.time + scoreIncrementInterval;
            scoreText.text = score.ToString();
            hpText.text = hp.ToString();
        }
    }

    // Method to increment the score by a specified amount.
    public void IncrementScore(int amount)
    {
        score += amount;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger && other.CompareTag("enemy"))
        {
            if (hp > 1)
            {
                hp--;
            }
            else
            {
                scoreShower.finalScore = score;
                SceneManager.LoadScene("Save Score");
            }
        }
    }
}
