using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public List<Transform> jointThumb;
    public List<Transform> jointIndex;
    public List<Transform> jointMiddle;
    public List<Transform> jointRotate;

    float wristRoll = 0f;
    public float wristRotationSpeed = 30;

    void Start()
    {
        
    }
    
    void Update()
    {
        UpdateWristRoll();
        UpdateFingers();
    }

    void UpdateWristRoll()
    {
        bool tilt_left = Input.GetKey(KeyCode.Q);
        bool tilt_right = Input.GetKey(KeyCode.E);

        if (tilt_left)
        {
            wristRoll += wristRotationSpeed * Time.deltaTime;          
        }
        else if (tilt_right)
        {
            wristRoll -= wristRotationSpeed * Time.deltaTime;
        }
        
        wristRoll = Mathf.Clamp(wristRoll, -30f, 40f);
        
        jointRotate[0].localEulerAngles = Vector3.right * wristRoll;
        jointRotate[1].localEulerAngles = Vector3.right * wristRoll * 0.8f;
        jointRotate[2].localEulerAngles = Vector3.right * wristRoll * 0.6f;

    }

    void UpdateFingers()
    {
        bool close = Input.GetKey("mouse 0");
        bool open = Input.GetKey("mouse 1");

        if (close)
        {
            // joint_index_1.localRotation *= Quaternion.Euler(0,0,0.1f);
            jointIndex[0].localRotation *= Quaternion.Euler(0, 0, 1f);
            jointMiddle[0].localRotation *= Quaternion.Euler(0, 0, 1f);
            jointThumb[0].localRotation *= Quaternion.Euler(0, 0, 1f);
        }
        else if (open)
        {
            // joint_index_1.localRotation *= Quaternion.Euler(0,0,0.1f);
            jointIndex[0].localRotation *= Quaternion.Euler(0, 0, -1f);
            jointMiddle[0].localRotation *= Quaternion.Euler(0, 0, -1f);
            jointThumb[0].localRotation *= Quaternion.Euler(0, 0, -1f);
        }

        //Debug.Log("Index" + jointIndex[0].localEulerAngles);
        //Debug.Log("Middle" + jointMiddle[0].localEulerAngles);
        //Debug.Log("Thumb" + jointThumb[0].localEulerAngles);
    }
}




/* 
    Extra Information
    https://docs.unity3d.com/ScriptReference/Transform.Translate.html
*/