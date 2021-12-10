using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 jumpForce = new Vector2(0, 200);
    Vector3 kekanan, kekiri, maju, mundur, keatas, kebawah;
    public int aksi;
    public float speed;
    int score;

    void Start()
    {
        kekanan = new Vector3(1, 0, 0);
        kekiri = new Vector3(-1, 0, 0);
        maju = new Vector3(0, 0, 1);
        mundur = new Vector3(0, 0, -1);
   

    }

    public void jalan_kiri()
    {
        transform.position = transform.position + (kekiri * speed * Time.deltaTime);

    }

    public void jalan_kanan()
    {
        transform.position = transform.position + (kekanan * speed * Time.deltaTime);
    }

    public void melompat()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(jumpForce);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            jalan_kiri();
        }

         if (Input.GetKeyDown("space"))
        
        {
            melompat();
        }

        if (Input.GetKey(KeyCode.D))
        {
            jalan_kanan();
        }

     
    }
   
}
