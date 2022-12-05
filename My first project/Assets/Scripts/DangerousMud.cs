using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerousMud : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Collider collider = collision.gameObject.GetComponent<Collider>();
        if (collider != null)
        {
            collider.enabled = false;
        }
    }

}
