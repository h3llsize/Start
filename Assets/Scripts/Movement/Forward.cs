using UnityEngine;

namespace Cars.Movement {
    public abstract class Forward : MonoBehaviour
    {
        private string status;

        private void Update()
        {
            status = gameObject.GetComponent<Car>().getStatus();
            

            if(status.Equals("run"))
            {
                Move();
            }
        }
        public abstract void Move();
    }
}
