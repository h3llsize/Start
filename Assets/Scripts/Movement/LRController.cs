using UnityEngine;

namespace Cars.Movement
{
    public class LRController : LRHandler
    {
        [SerializeField] private float speed;

        public override void MoveLeft()
        {
            if (transform.position.z < 2f)
                Move(5f);
        }

        public override void MoveRight()
        {
            if (transform.position.z > -2f)
                Move(-5f);
        }

        private void Move(float kf)
        {
            Transform t = gameObject.transform;

            Vector3 moved = new Vector3(t.position.x, t.position.y, t.position.z + kf);

            t.position = Vector3.Lerp(t.position, moved, speed * Time.deltaTime);
        }
    }
}