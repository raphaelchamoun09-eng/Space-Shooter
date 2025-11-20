using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float fireRate = 0.25f; // Hur ofta man kan skjuta (sekunder)
    private float fireCooldown = 0f;

    void Update()
    {
        // Rörelse
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveX * moveSpeed * Time.deltaTime);

        // Skjuta så länge Space är nedtryckt
        if (Input.GetKey(KeyCode.Space) & fireCooldown <= 0f)
        {
            Shoot();
            fireCooldown = fireRate; // Återställ skott-timer
        }

        // Räkna ner cooldown
        if (fireCooldown > 0f)
        {
            fireCooldown -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }
}

