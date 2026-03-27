using UnityEngine;
using TMPro;
public class TimerLogger : MonoBehaviour
{
    private float startTime;
    private bool running = false;
    public TextMeshProUGUI resultText;
    public UIController ui;

    public void StartTimer()
    {
        startTime = Time.time;
        running = true;
    }

    public void StopTimer()
    {
        if (running)
        {
            float duration = Time.time - startTime;
            ui.UpdateTimer(duration);

            resultText.text = "Experiment Completed!";
            running = false;
        }
    }
}