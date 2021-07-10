using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SerialLight : MonoBehaviour
{

    public SerialHandler serialHandler;
    public Text text;

    void Start()
    {
        serialHandler.OnDataReceived += OnDataReceived;
    }

    void Update()
    {

    }

    void OnDataReceived(string message)
    {
        try
        {
            text.text = message;
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }
}