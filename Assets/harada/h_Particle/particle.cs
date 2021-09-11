using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ParticleDestroy();
        }
    }
    public void ParticleDestroy()
    {
        this.transform.localScale = new Vector3(0.0f, 1.0f, 1.0f);
    }
}
