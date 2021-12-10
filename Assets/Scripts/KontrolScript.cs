using UnityEngine;

public class KontrolScript : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "kiri")
            player.GetComponent<ObjectMovement>().jalan_kiri();
        else if (gameObject.name == "kanan")
            player.GetComponent<ObjectMovement>().jalan_kanan();
        else if (gameObject.name == "jump") player.GetComponent<ObjectMovement>().melompat();
    }

    private void OnMouseDrag()
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
        }
    }

    private void OnMouseUp()
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
}