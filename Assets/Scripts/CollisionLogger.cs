using UnityEngine;

public class CollisionLogger : MonoBehaviour
{
    public DataLogger logger;

    void OnCollisionEnter(Collision collision)
    {
        if (logger != null)
        {
            logger.LogEvent("Collision", gameObject.name + " hit " + collision.gameObject.name);
        }
    }
}