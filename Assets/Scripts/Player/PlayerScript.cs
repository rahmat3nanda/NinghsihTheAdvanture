using System.Collections;
using UnityEngine;

namespace Player
{
    public class PlayerScript : MonoBehaviour
    {
        public GameObject mawar;
        private bool _spawned;

        private void Start()
        {
            _spawned = false;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.RightShift) && _spawned == false)
            {
                Tembak();
            }
        }

        private void Tembak()
        {
            StartCoroutine(SetDelay());
            Vector3 bp = gameObject.transform.position;
            mawar.transform.position = new Vector3(bp.x +1f, bp.y , 0f);
            Instantiate(mawar);
        }
        
        private IEnumerator SetDelay()
        {
            _spawned = true;
            yield return new WaitForSeconds(1);
            _spawned = false;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("BanaspatiBullet"))
            {
                Destroy(col.gameObject);
            }

            if (col.CompareTag("Banaspati"))
            {
                Destroy(gameObject);
            }
        }
    }
}