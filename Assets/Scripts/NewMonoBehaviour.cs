using UnityEngine;
using System.Collections;

public class NewMonoBehaviour : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset = new Vector3(0, 0, -1);

    void FixedUpdate()
    {
        if (target)
        {
            transform.position = new Vector3
            (
                target.transform.position.x + offset.x,
                target.transform.position.y + offset.y,
                target.transform.position.z + offset.z
            );
        }
    }

}
