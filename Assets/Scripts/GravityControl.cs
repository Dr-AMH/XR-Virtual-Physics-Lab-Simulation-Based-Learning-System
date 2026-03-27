using UnityEngine;
using UnityEngine.UI;

public class GravityControl : MonoBehaviour
{
    public Slider gravitySlider;
    public DataLogger logger;

    void Start()
    {
        Physics.gravity = new Vector3(0, gravitySlider.value, 0);

        if (logger != null)
        {
            logger.LogEvent("GravityChanged", gravitySlider.value.ToString("F2"));
        }
    }

    public void SetGravity(float value)
    {
        Physics.gravity = new Vector3(0, value, 0);
        Debug.Log("Gravity changed to: " + value);

        if (logger != null)
        {
            logger.LogEvent("GravityChanged", value.ToString("F2"));
        }
        else
        {
            Debug.LogError("Logger not assigned in GravityControl!");
        }
    }
}