using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomTimedEvent : MonoBehaviour
{
    [Header("Time Intervals")]
    [Tooltip("Minimum time in seconds (5 minutes)")]
    public float minInterval = 300f;

    [Tooltip("Maximum time in seconds (10 minutes)")]
    public float maxInterval = 600f;

    [Header("Event")]
    [Tooltip("Event invoked at random intervals")]
    public UnityEvent RandomTimedEvent_Event;

    [Tooltip("Enable to trigger the event initially")]
    public bool triggerInitially = true;

    private void Start()
    {
        if (triggerInitially)
            TriggerEvent(); // Trigger the event initially if enabled

        // Invoke the TriggerEvent method randomly between minInterval and maxInterval
        InvokeRepeating("TriggerEvent", Random.Range(minInterval, maxInterval), Random.Range(minInterval, maxInterval));
    }

    private void TriggerEvent()
    {
        // Your event or code to trigger goes here
        RandomTimedEvent_Event.Invoke();
    }
}