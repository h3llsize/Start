using UnityEngine;

namespace Cars.Movement
{
    public abstract class LRHandler : TouchController
    {
        public override void onClick(Vector3 posClick)
        {
            int kf = Screen.width / 4;

            if (posClick.x < kf)
            {
                MoveLeft();
            }
            if (posClick.x > (Screen.width - kf))
            {
                MoveRight();
            }
        }

        public override void onScreenTouch(Touch touch)
        {
            Vector3 posClick = touch.position;
            Debug.Log("Was clicked : " + posClick.x + " | " + posClick.y);
        }

        public abstract void MoveLeft();
        public abstract void MoveRight();
    }
}