using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenager : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 0.125f; 

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + new Vector3(-74.4f, 66.8f, -88.7f); 
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.rotation = Quaternion.Euler(30f, 40f, 0f);
        }
    }
}
