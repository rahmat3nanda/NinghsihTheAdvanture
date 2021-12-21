using UnityEngine;

namespace Banaspati
{
    public class BanaspatiScript : MonoBehaviour
    {
        private bool _moveUp;
        private float _objSpeed;

        private void Start()
        {
            _moveUp = true;
            _objSpeed = 0.02f;
        }

        private void Update()
        {
            MoveVertical();
        }

        private void MoveVertical()
        {
            var temp = transform.position;
            if (_moveUp)
            {
                temp.y += _objSpeed;
                transform.position = temp;
                if (transform.position.y >= 1f) _moveUp = false;
            }

            if (!_moveUp)
            {
                temp.y -= _objSpeed;
                transform.position = temp;
                if (transform.position.y <= -1f) _moveUp = true;
            }
        }
    }
}