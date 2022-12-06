using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using TMPro;

public class AddPointsEvent : MonoBehaviour
{
    private UnityAction actionAddPoints;
    private TextMeshProUGUI txtObject;

    private void Awake()
    {
        actionAddPoints = new UnityAction(OnAddPoints);
        txtObject = GetComponent<TextMeshProUGUI>();
        txtObject.text = "0";
    }

    private void OnEnable()
    {
        EventManager.StartListening("AddPoints", actionAddPoints);
    }

    private void OnDisable()
    {
        EventManager.StopListening("AddPoints", actionAddPoints);
    }

    private void OnAddPoints()
    {
        txtObject.text = Convert.ToString(Int32.Parse(txtObject.text) + 5);
    }

}
