using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ATTACK!!!!");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Stop attack!");
    }

}
