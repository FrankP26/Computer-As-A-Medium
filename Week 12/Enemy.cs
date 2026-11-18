using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 50;
    bool isDead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword") || other.CompareTag("Bullet"))
        {
            enemyHealth -= 10;
        }
    }

    void Death()
    {
        if (enemyHealth <= 0)
        {
            isDead = true;
            StartCoroutine(EnemyDeath());
        }
    }
    IEnumerator EnemyDeath()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        Color color = sr.color;
        color.a = 0.5f;
        sr.color = color;

        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
