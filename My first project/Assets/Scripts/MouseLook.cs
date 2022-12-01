using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxis
    {
        MouseXY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxis  axis = RotationAxis.MouseXY;
    public float horizontalSensitivity = 8.0f;

    // Update is called once per frame
    void Update()
    {
        if (axis == RotationAxis.MouseX)
        {
            // horizontal rotation -> rotation around y-axis
            transform.Rotate(0, Input.GetAxis("Mouse X") * horizontalSensitivity, 0 );
        }
        else if (axis == RotationAxis.MouseY)
        {
            // vertical rotation
        }
        else
        {
            // horizontal and vertical rotation
        }
    }
}
