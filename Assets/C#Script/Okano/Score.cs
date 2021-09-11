using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public Text text;
    // Use this for initialization
    void Start()
    {
        text.text = ((int)GameController.power).ToString() + " kg";
    }
}
