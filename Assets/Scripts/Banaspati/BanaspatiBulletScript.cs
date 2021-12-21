using System;
using UnityEngine;

namespace Banaspati
{
    public class BanaspatiBulletScript : MonoBehaviour
    {
        public float speed = 1f;
        private void Update()
        {
            transform.Translate(new Vector3(0f, -3f, 0f) * speed * Time.deltaTime);
        }
    }
}