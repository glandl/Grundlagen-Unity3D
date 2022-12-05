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

    public RotationAxis axis = RotationAxis.MouseXY;
    public float horizontalSensitivity = 8.0f;
    public float verticalSensitivity = 8.0f;
    public float minVertical = 0.0f;
    public float maxVertical = 45.0f;
    private float _rotationX = 0.0f;
    private float _rotationY = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (axis == RotationAxis.MouseX)
        {
            // horizontal rotation -> rotation around y-axis
            float delta = Input.GetAxis("Mouse X") * horizontalSensitivity;
            transform.Rotate(0, delta, 0 );
        }
        else if (axis == RotationAxis.MouseY)
        {
            // vertical rotation
            _rotationX -= Input.GetAxis("Mouse Y") * verticalSensitivity;
            _rotationX = Mathf.Clamp(_rotationX, minVertical, maxVertical);
            _rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
        }
        else
        {
            // horizontal and vertical rotation
            _rotationX -=  Input.GetAxis("Mouse Y") * verticalSensitivity;
            _rotationX = Mathf.Clamp(_rotationX, minVertical, maxVertical);

            float delta = Input.GetAxis("Mouse X") * horizontalSensitivity;
            _rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
        }
    }
}
