using UnityEngine;

public class HealthPack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.AddHealth();
            Destroy(gameObject);
        }
    }
}