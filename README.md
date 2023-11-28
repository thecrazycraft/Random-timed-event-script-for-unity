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

## Example Usage

```csharp
// Example of subscribing to the RandomTimedEvent
public class ExampleClass : MonoBehaviour
{
    public RandomTimedEvent randomTimedEvent;

    private void Start()
    {
        // Subscribe to the RandomTimedEvent's UnityEvent
        randomTimedEvent.RandomTimedEvent_Event.AddListener(YourCustomMethod);
    }

    private void YourCustomMethod()
    {
        // Your custom logic or action to be executed when the event is triggered
        Debug.Log("Random event occurred!");
    }
}
