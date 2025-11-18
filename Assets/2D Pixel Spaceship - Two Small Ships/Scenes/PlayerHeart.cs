using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHearts : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 3;
    public int currentHealth;

    [Header("UI Elements")]
    public Image[] hearts;
    public Sprite fullHeart; //Heart6
    public Sprite emptyHeart; // Heart4

    [Header("Game Over")]
    public GameObject gameOverPanel; // UI-panel med "Game Over" text

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHeartsUI();
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHeartsUI();

        if (currentHealth <= 0)
        {
            GameOver();
        }
    }

    void UpdateHeartsUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }

    void GameOver()
    {
        Debug.Log("GAME OVER");
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        // Stäng av spelaren (du kan ändra detta till vad du vill)
        gameObject.SetActive(false);
    }
}
