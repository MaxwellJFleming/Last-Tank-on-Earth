using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AimVertical : MonoBehaviour
{
    //aim speed multiplier
    [SerializeField]
    private float AimSpeed = 1;

    //bounds for aim rotation
    [SerializeField]
    private float MaxAimRotation = 90;
    [SerializeField]
    private float MinAimRotation = -10;

    void Start()
    {
        //locks the cursor while playing
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //UnityEngine.Cursor.lockState = CursorLockMode.Locked;

        float rotateAmount = -Input.GetAxis("Mouse Y") * AimSpeed * Time.deltaTime;

        //rotates view & cannon verically if the new rotation is within bounds
        if (rotateAmount < MaxAimRotation && rotateAmount > MinAimRotation)
        {
            transform.Rotate(rotateAmount, 0, 0);
        }
    }
}
