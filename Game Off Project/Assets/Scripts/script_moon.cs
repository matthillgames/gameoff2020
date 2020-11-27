using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_moon : MonoBehaviour
{
    public GameObject sound;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Planet" || collision.gameObject.tag == "Moon")
        {
            Instantiate(sound);
            Destroy(gameObject);
        }

    }
}
