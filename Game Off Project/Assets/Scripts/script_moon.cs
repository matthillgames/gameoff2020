using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_moon : MonoBehaviour
{
    public GameObject sound;
    public GameObject part;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Planet" || collision.gameObject.tag == "Moon")
        {
            if (sound != null)
                Instantiate(sound, transform.position,transform.rotation);
            if (part != null)
                Instantiate(part, transform.position,transform.rotation);
            Destroy(gameObject);
        }

    }
}
