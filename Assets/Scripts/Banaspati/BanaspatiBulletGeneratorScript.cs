using UnityEngine;

namespace Banaspati
{
    public class BanaspatiBulletGeneratorScript : MonoBehaviour
    {
        public GameObject bullet;
        
        public GameObject banaspati;

        private void Start()
        {
            InvokeRepeating("GenerateBullet", 1f, 2.2f);
        }

        private void GenerateBullet()
        {
            bullet.transform.position = new Vector3(6.94f, banaspati.transform.position.y - 1f, 0f);
            Instantiate(bullet);
        }
    }
}