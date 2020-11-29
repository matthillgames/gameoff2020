using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_menuLauncher : MonoBehaviour
{
    public Vector2 forceRange;
    public Vector2 angleRange;

    public float rate;

    public GameObject moon;
    public float timer = 2f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = rate;
            var inst = Instantiate(moon, transform);
            inst.transform.Rotate(new Vector3(0, 0, Random.Range(angleRange.x, angleRange.y)));
            inst.GetComponent<Rigidbody>().AddForce(inst.transform.right * -forceRange);
        }
    }
}
