using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    private Rigidbody2D fa;

    public float KecepatanGerak;

    public bool memutar;

    // Start is called before the first frame update
    void Start()
    {
        memutar = true;
        fa = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (memutar)
        {
            fa.velocity = new Vector2(KecepatanGerak, fa.velocity.y);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else
        {
            fa.velocity = new Vector2(-KecepatanGerak, fa.velocity.y);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Puter"))
        {
            memutar = !memutar;
        }
    }
}
