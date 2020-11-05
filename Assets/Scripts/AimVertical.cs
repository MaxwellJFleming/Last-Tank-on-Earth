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

    private float oldMouseY;
    private float ogRotation;

    void Start()
    {
        //stores current mouse y pos and cannon rotation as scene starts
        oldMouseY = Input.GetAxis("Mouse Y");
        ogRotation = transform.rotation.x;
    }

    void Update()
    {
        float newMouseY = Input.GetAxis("Mouse Y");
        float rotateAmount = -(newMouseY - oldMouseY) * AimSpeed * Time.deltaTime;

        //rotates view & cannon verically if the new rotation is within bounds
        if (transform.rotation.x + rotateAmount < MaxAimRotation && transform.rotation.x + rotateAmount > MinAimRotation)
        {
            transform.Rotate(rotateAmount, 0, 0);
        }

        //resets rotation when right mouse button is clicked
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(transform.rotation.x - ogRotation, 0, 0);
        }
    }
}
