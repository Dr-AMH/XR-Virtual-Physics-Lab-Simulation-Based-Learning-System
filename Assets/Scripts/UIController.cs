using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI gravityText;
    public TextMeshProUGUI timerText;

    public void UpdateGravity(float value)
    {
        gravityText.text = "Gravity: " + value.ToString("F2");
    }

    public void UpdateTimer(float time)
    {
        timerText.text = "Time: " + time.ToString("F2") + " s";
    }
}