using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerangTulup : MonoBehaviour
{
    public float Speed = 4.5f;
    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<EnemyBehavior>();
        if (collision.gameObject.CompareTag("enemy"))
        {
            enemy.kenadamage(2);
            Destroy(gameObject);
        }
        
    }
}
