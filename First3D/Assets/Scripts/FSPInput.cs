using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSPInput : MonoBehaviour
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

        Vector3 movement = new Vector3(dx * Time.deltaTime, 0, dz * Time.deltaTime);

        characterController.Move(movement);
        
    }
}
