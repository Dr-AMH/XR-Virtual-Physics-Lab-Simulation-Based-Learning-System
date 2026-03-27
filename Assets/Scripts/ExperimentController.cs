using UnityEngine;

public class ExperimentController : MonoBehaviour
{
    public Rigidbody ball;
    public Rigidbody box;

    public DataLogger logger;

    public void DropObjects()
    {
        ball.useGravity = true;
        box.useGravity = true;
    }

    public void ResetObjects()
    {
        // your existing reset logic (reposition objects)

        if (logger != null)
        {
            logger.LogEvent("ExperimentRestarted", "User reset objects");
        }
    }

}