using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    void OnMouseDown()
    {
        if (gameObject.name == "kiri")
        {
            player.GetComponent<ObjectMovement>().jalan_kiri();
        }
        else if (gameObject.name == "kanan")
        {
            player.GetComponent<ObjectMovement>().jalan_kanan();
        }
        else if (gameObject.name == "jump")
        {
            player.GetComponent<ObjectMovement>(). melompat();
           
        }


    }

    void OnMouseUp()
    {
        if (gameObject.name == "kiri")
        {
            
        }
        else if (gameObject.name == "kanan")
        {
            
        }
        else if (gameObject.name == "jump")
        {
            
        }


    }

    void OnMouseDrag()
    {
        if (gameObject.name == "kiri")
        {
            player.GetComponent<ObjectMovement>(). jalan_kiri();
        }
        else if (gameObject.name == "kanan")
        {
            player.GetComponent<ObjectMovement>(). jalan_kanan();
        }
        else if (gameObject.name == "jump")
        {
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
