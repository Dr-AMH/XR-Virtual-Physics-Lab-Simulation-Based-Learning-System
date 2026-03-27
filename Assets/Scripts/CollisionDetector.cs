using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public TimerLogger timer;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            timer.StopTimer();
        }
    }
}