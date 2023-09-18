using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class DayNightCycleController : MonoBehaviour
{
    public float duration;
    [SerializeField]
    Gradient gradient;
    Light2D _light;
    float _startTime;

    // Declare a delegate type for the hour events
    public delegate void HourEventHandler(int hour);

    // Dictionary to store event handlers for each hour
    private Dictionary<int, HourEventHandler> hourEventHandlers = new Dictionary<int, HourEventHandler>();

    void Awake()
    {
        _light = GetComponent<Light2D>();
        _startTime = Time.time;
    }

    private void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            int hour = i;
            hourEventHandlers[hour] = (h) => printHours(h);
        }
    }

    void Update()
    {
        float timeElapsed = Time.time - _startTime; // Calculate elapsed time correctly

        float percentage = Mathf.Sin(timeElapsed / duration * Mathf.PI * 2.0f) * 0.5f + 0.5f;
        percentage = Mathf.Clamp01(percentage);

        _light.color = gradient.Evaluate(percentage);

        // Calculate the current hour
        int currentHour = Mathf.FloorToInt((timeElapsed / duration) * 24) % 24;
        // Trigger the event for the current hour
        hourEventHandlers[currentHour]?.Invoke(currentHour);
    }

    void printHours(int hour)
    {
        print("HOUR " + hour);
    }
}
