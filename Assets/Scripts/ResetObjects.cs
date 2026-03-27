using UnityEngine;

public class ResetObjects : MonoBehaviour
{
    //public DataLogger logger;
    public Rigidbody ball;
    public Rigidbody box;

    Vector3 ballStart;
    Vector3 boxStart;

    void Start()
    {
        ballStart = ball.transform.position;
        boxStart = box.transform.position;
    }

    public void ResetScene()
    {
        ball.linearVelocity = Vector3.zero;
        box.linearVelocity = Vector3.zero;

        ball.transform.position = ballStart;
        box.transform.position = boxStart;
    }
}