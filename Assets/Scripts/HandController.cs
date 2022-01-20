using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public Transform joint_rotate;
    public Transform joint_index_1;
    public Transform joint_thumb_1;

    // Update is called once per frame
    void Start()
    {

    }
    
    void Update()
    {
        HandControls();
    }

    void HandControls()
    {
        var tilt_left = Input.GetKey(KeyCode.Q);
        var tilt_right = Input.GetKey(KeyCode.E);
        var close = Input.GetKey("mouse 0");
        var open = Input.GetKey("mouse 1");
        
        if(tilt_left)
        {
            joint_rotate.localRotation *= Quaternion.Euler(1f, 0 , 0);
        }
        
        if(tilt_right)
        {
            joint_rotate.localRotation *= Quaternion.Euler(-1f, 0 , 0);
        }

        if(close)
        {
            // joint_index_1.localRotation *= Quaternion.Euler(0,0,0.1f);
            joint_index_1.localRotation *= Quaternion.Euler(0,0,1f);
            joint_thumb_1.localRotation *= Quaternion.Euler(0,0.5f,1f);
        }

        if(open)
        {
            // joint_index_1.localRotation *= Quaternion.Euler(0,0,0.1f);
            joint_index_1.localRotation *= Quaternion.Euler(0,0,-1f);
            joint_thumb_1.localRotation *= Quaternion.Euler(0,-(0.5f),-1f);
        }
    }
}


/* 
Extra Information and Unused Variables

// https://docs.unity3d.com/ScriptReference/Transform.Translate.html


// Joint Movement
    Closed position
    thumb3_l = 4.401, -6.354, 330,599
    index1_l = 0, 3.679, 54.845

    Open position
    thumb3_l = 14.853, -29.21, 119.948
    index1_l = 0, 3.679, 33.757

// Joint Variables
    public Transform joint_index_2;
    public Transform joint_index_3;

    public Transform joint_middle_1;
    public Transform joint_middle_2;
    public Transform joint_middle_3;
    
    public Transform joint_ring_1;
    public Transform joint_ring_2;
    public Transform joint_ring_3;

    public Transform joint_pinky_1;
    public Transform joint_pinky_2;
    public Transform joint_pinky_3;
    // public Transform joint_pinky_4;

    public Transform joint_thumb_2;
    public Transform joint_thumb_3;

*/