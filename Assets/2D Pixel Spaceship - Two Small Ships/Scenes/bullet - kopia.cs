using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);    // Förstör fienden
            Destroy(gameObject);          // Förstör kulan

            // Lägg till poäng
            ScoreManager.instance.AddScore(1);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

