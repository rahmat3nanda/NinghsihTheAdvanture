using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float HP;
    public float MaxHP = 10;
    public Healthbar hb;
     
    void Start()
    {
        HP = MaxHP;
        hb.SetHealth(HP, MaxHP);
    }

    // Update is called once per frame
    public void kenadamage(float damage)
    {
        HP -= damage;
        hb.SetHealth(HP, MaxHP);
         
        if (HP <=0)
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.collider.GetComponent<PlayerBehavior>();
        if (collision.gameObject.CompareTag("player"))
        {
            player.kehit(2);
            
        }

    }

}
