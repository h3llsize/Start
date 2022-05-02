using UnityEngine;

namespace Cars.Movement {
    public class ForwardController : Forward
    {

        [SerializeField] private float speed;
        public override void Move()
        {
            Vector3 vect = new Vector3(transform.position.x + 10f, transform.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, vect, speed * Time.deltaTime);
        }
    }
}
