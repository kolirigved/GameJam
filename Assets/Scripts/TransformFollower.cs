using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFollower : MonoBehaviour
{
    public GameObject target; // The GameObject to follow
    public float fixedZ = -10f; // The fixed z position

    void Update()
    {
        if (target != null)
        {
            // Match the position and rotation of the target, but fix the z component
            Vector3 targetPosition = target.transform.position;
            transform.position = new Vector3(targetPosition.x, targetPosition.y, fixedZ);
            transform.rotation = target.transform.rotation;
            transform.localScale = target.transform.localScale;
        }
    }
}
