using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI1 : MonoBehaviour
{

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10,10, 100, 40), "Click on me!") == true)
        {
            Debug.Log("HUD Click!");
        }
    }

}
