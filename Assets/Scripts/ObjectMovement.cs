using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 jumpForce = new Vector2(0, 200);
    public int aksi;
    public float speed;
    private Vector3 kekanan, kekiri, maju, mundur, keatas, kebawah;
    private int score;

    private void Start()
    {
        kekanan = new Vector3(1, 0, 0);
        kekiri = new Vector3(-1, 0, 0);
        maju = new Vector3(0, 0, 1);
        mundur = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) jalan_kiri();

        if (Input.GetKeyDown("space")) melompat();

        if (Input.GetKey(KeyCode.D)) jalan_kanan();
    }

    public void jalan_kiri()
    {
        transform.position = transform.position + kekiri * speed * Time.deltaTime;
    }

    public void jalan_kanan()
    {
        transform.position = transform.position + kekanan * speed * Time.deltaTime;
    }

    public void melompat()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(jumpForce);
    }
}