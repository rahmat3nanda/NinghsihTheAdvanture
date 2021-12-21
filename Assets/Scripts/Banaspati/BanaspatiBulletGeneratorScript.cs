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
            Vector3 bp = banaspati.transform.position;
            bullet.transform.position = new Vector3(bp.x -1, bp.y -1f, 0f);
            Instantiate(bullet);
        }
    }
}