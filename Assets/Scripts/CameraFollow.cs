using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void LateUpdate() { // this is run right after
        transform.position = target.position + offset;
    }

}
