using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public Vector3 cameraOffset;
    deneme deneme;


    private void Awake()
    {
        
    }

    public void SetCameraTarget(Transform cubeTransform)
    {
        target = cubeTransform;
    }

    
    void LateUpdate()
    {
        
            Vector3 newPos = target.position + cameraOffset;
            transform.position = newPos;
        
        
    }
}
