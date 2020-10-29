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

    void Start()
    {
        oldMouseY = Input.GetAxis("Mouse Y");
    }

    void Update()
    {
        float newMouseY = Input.GetAxis("Mouse Y");

        //rotates view & cannon verically if a button is held
        if (Input.GetMouseButton(2))
        {
            transform.Rotate(Mathf.Clamp(-(oldMouseY - newMouseY) * AimSpeed * Time.deltaTime, MinAimRotation, MaxAimRotation), 0, 0);
        }
    }
}
