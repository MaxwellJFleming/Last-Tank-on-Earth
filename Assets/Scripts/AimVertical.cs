using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimVertical : MonoBehaviour
{
    [SerializeField]
    private float AimSpeed = 1;

    [SerializeField]
    private float MaxAimRotation = -90;

    [SerializeField]
    private float MinAimRotation = 10;

    private float oldMouseY;

    //private float originalRotation;

    void Start()
    {
        oldMouseY = Input.GetAxis("Mouse Y");
    }

    void Update()
    {
        float newMouseY = Input.GetAxis("Mouse Y");

        
        
        if (Input.GetMouseButton(2))
        {
            transform.Rotate(-(oldMouseY - newMouseY) * AimSpeed * Time.deltaTime, 0, 0);
        }
    }
}
