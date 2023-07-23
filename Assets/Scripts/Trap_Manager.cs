using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator anim;
    public Player_Movement player;
    public int trapDamage;
    public bool isPlayerOnTop;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerOnTop = true;
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isActive", true);
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerOnTop = false;
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isActive", false);
        }
    }

    public void PlayerDamage()
    {
        if (isPlayerOnTop)
        {
            player.healthPoints -= trapDamage;
        }
    }
}
