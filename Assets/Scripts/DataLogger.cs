using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataLogger : MonoBehaviour
{
    private List<string> logData = new List<string>();
    string filePath;

    void Start()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        filePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/learning_data.csv";
#else
        filePath = Application.persistentDataPath + "/learning_data.csv";
#endif

        logData.Clear();
        logData.Add("Time,Event,Value");
    }

    public void LogEvent(string eventName, string value)
    {
        string time = Time.time.ToString("F2");
        string line = time + "," + eventName + "," + value;
        logData.Add(line);
        Debug.Log("Logged: " + line);
    }

    public void SaveToFile()
    {
        File.WriteAllLines(filePath, logData.ToArray());
        Debug.Log("Data saved to: " + filePath);
    }

    void OnApplicationQuit()
    {
        SaveToFile();
    }
}