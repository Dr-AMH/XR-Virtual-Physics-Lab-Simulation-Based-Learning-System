using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public DataLogger logger;

    public void SaveData()
    {
        if (logger != null)
        {
            logger.SaveToFile();
            Debug.Log("Manual Save Triggered");
        }
        else
        {
            Debug.LogError("Logger not assigned!");
        }
    }
}