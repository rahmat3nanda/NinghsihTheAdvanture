using UnityEngine;

public class CtrlScript : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    // Start is called before the first frame update
    public void Maju()
    {
        player.GetComponent<ObjectMovement>().jalan_kanan();
    }

    public void Mundur()
    {
        player.GetComponent<ObjectMovement>().jalan_kiri();
    }
}