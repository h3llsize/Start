using UnityEngine;

namespace Cars.Movement
{
    public abstract class TouchController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                onScreenTouch(touch);
            }

            if (Input.GetMouseButton(0))
            {
                Vector3 pos = Input.mousePosition;
                onClick(pos);
            }
        }


        public abstract void onScreenTouch(Touch touch);

        public abstract void onClick(Vector3 posClick);
    }
}