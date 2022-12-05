using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    private float speed = 6.0f;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * speed;
        float dz = Input.GetAxis("Vertical") * speed;

        // Time.DeltaTime return the time needed to render the last frame
        // used to make movement framerate independent!
        Vector3 movement = new Vector3(dx * Time.deltaTime, 0, dz * Time.deltaTime);

        // limit movement to speed, otherwise diagonal movement will be faster
        movement = Vector3.ClampMagnitude(movement, speed);

        // transform movement form local to global system
        movement = transform.TransformDirection(movement);
        movement = new Vector3(movement.x, 0, movement.z);
        
        characterController.Move(movement);
        
    }
}
