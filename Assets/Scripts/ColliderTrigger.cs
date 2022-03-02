using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{

    private void OnCollisionEnter (Collision collision)
    {
        ScoreManager.instance.AddPoint();
        Destroy(GetComponent<MeshCollider>());
        Debug.Log("Got in!");
    }
}
