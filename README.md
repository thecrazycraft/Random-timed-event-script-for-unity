# RandomTimedEvent Script

The `RandomTimedEvent` script is a Unity component designed to execute events at randomized intervals within a specified time range. This script offers flexibility in triggering UnityEvents based on user-defined time intervals.

## Features

- **Customizable Time Intervals:** Users can set the minimum and maximum time intervals (in seconds) between event triggers.
  
- **Event Trigger:** Utilizes UnityEvent for seamless integration with other Unity components or custom functionality.
  
- **Initial Trigger Configuration:** Provides an option to enable triggering the event initially upon script activation.

## Usage

1. **Attach the Script:** Add the `RandomTimedEvent` script to any GameObject in your Unity scene.

2. **Set Time Intervals:** Adjust `minInterval` and `maxInterval` variables in the Inspector to define the range for random event triggers.

3. **Event Configuration:** Assign a UnityEvent to `RandomTimedEvent_Event` in the Inspector. This event will be invoked at the specified intervals.

4. **Initial Trigger (Optional):** Enable `triggerInitially` in the Inspector if you want the event to be triggered immediately upon scene start.

## Implementation

The `Start()` method initializes the script by triggering the event initially (if enabled) and then uses `InvokeRepeating` to repeatedly invoke the `TriggerEvent()` method at random intervals within the specified range.

The `TriggerEvent()` method is called by the timer and invokes the assigned UnityEvent, allowing users to define their custom logic or actions to be executed.

## Code

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomTimedEvent : MonoBehaviour
{
    [Header("Time Intervals")]
    [Tooltip("Minimum time in seconds")]
    public float minInterval = 300f;

    [Tooltip("Maximum time in seconds")]
    public float maxInterval = 600f;

    [Header("Event")]
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
