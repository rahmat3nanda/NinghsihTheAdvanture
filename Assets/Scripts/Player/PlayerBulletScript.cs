using UnityEngine;

namespace Player
{
    public class PlayerBulletScript : MonoBehaviour
    {
        public float speed = 2f;
        private void Update()
        {
            transform.Translate(new Vector3(3f, 0f, 0f) * (speed * Time.deltaTime));
        }
    }
}
