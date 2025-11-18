using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    void Update()
    {
        transform.Translate(new Vector3(0,-1,0) * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth player = other.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.TakeDamage(1);
            }

            Destroy(gameObject);
        }
    }
}
