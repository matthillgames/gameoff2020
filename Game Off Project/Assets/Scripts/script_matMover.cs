using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_matMover : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 speed = new Vector2(0.3f, 0);

    Renderer rend;
    Vector2 offset = new Vector2(0, 0);
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        offset += new Vector2(Time.deltaTime, Time.deltaTime) * -speed;
        rend.material.mainTextureOffset = offset;
    }
}
