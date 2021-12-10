using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
   public void maju()
    {
        player.GetComponent<ObjectMovement>().jalan_kanan();
    }
   public void mundur()
    {
        player.GetComponent<ObjectMovement>().jalan_kiri();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
