using UnityEngine;

public class Buttom : MonoBehaviour
{
    public GameObject TrapWall;

    void Start()
    {
        TrapWall.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerHealth>() != null)
        {
            TrapWall.SetActive(true);
        }
    }
}