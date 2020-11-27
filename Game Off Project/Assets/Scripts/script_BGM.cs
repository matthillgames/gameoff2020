using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_BGM : MonoBehaviour
{
    static GameObject bgMusic = null;
    // Start is called before the first frame update
    void Awake()
    {
        if (bgMusic != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            bgMusic = gameObject;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
