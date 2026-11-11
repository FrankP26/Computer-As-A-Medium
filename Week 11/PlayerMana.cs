using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public int mana = 50;
    public TMP_Text ManaText;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ManaText.text = "Mana: " + mana;
    }

    // Update is called once per frame
    void Update()
    {
        ManaText.text = "Mana: " + mana;

        if (Keyboard.current.rKey.wasPressedThisFrame && mana >= 10)
        {
            mana -= 10;
            animator.SetTrigger("Cast");
        }
    }
}
