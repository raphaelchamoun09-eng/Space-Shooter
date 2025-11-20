using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        // Singleton så vi kan nå ScoreManager från andra scripts
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }
    private void Update()
    {
        if (score >= 50)
        {
            Time.timeScale = 0;
        }
    }
    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
    }
}
