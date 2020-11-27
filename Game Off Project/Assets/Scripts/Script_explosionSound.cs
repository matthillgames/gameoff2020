using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_explosionSound : MonoBehaviour
{
    public float Timer = 3f;


    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
