using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicMovment : MonoBehaviour
{
    public float MovementSpeed = 10.0f;
    public float RotationSpeed = 75.0f;

    private float _vInput;
    private float _hInput;

    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MovementSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotationSpeed;
    }

    // FixedUpdate is called once per frame for a fixed framrate -> frame independent
    // Any physics related code should be placed here
    private void FixedUpdate()
    {
        // vector to store the rotation movement
        Vector3 rotation = Vector3.up * _hInput * Time.fixedDeltaTime;
        // calculate a quaternion for the rotation angles
        Quaternion rotationAngle = Quaternion.Euler(rotation) * _rigidbody.rotation;
        _rigidbody.MoveRotation(rotationAngle);

        // move position of player
        _rigidbody.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
    }
}
