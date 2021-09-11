using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject explosionP;
    public Text text;
    public bool debugInput = true;
    public float debugPower = 10;

    public static float power = 10.0f;

    private void Update()
    {
        if (debugInput && Input.GetKeyDown(KeyCode.Space))
        {
            DaiPanEnter(debugPower);
        }
    }

    public void DaiPanEnter(float _power)
    {
        power = _power;
        GameObject explosion = Instantiate(explosionP);

        explosion.transform.localScale *= (_power / 100.0f);

        text.text = ((int)_power).ToString() + " kg";

        Invoke("BreakScreen", 0.5f);

    }

    public void BreakScreen()
    {
        GetComponent<GameManager>().StartCoroutine("TraceOn");
    }
}
