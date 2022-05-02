using UnityEngine;

public class Height : MonoBehaviour
{

    [SerializeField] private Transform parent;
    [SerializeField] private float height;
    private void Update()
    {
        Ray ray = new Ray(transform.position, new Vector3(0, -90, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
           Vector3 vect = new Vector3(parent.transform.position.x, parent.transform.position.y + (height - hit.distance), parent.transform.position.z);
           parent.transform.position = Vector3.Lerp(parent.transform.position, vect, Time.deltaTime * 2f);
        }
    }
}
