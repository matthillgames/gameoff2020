using UnityEngine;
using TMPro;

public class script_gravity : MonoBehaviour
{
    public float GRAVITY = 5000f;
    public float DAMPING_MULTIPLYER = 1f; //Does nothing yet
    public float TIMER = 3f;
    public int count = 0;
    public int requiredCount = 1;
    public bool complete = false;
    public int icount = 0;
    public int lcount = 0;
    public float timer = 3f;
    public TextMeshPro mtext;


    private void FixedUpdate()
    {
        if (lcount == icount)
            timer -= Time.deltaTime;
        else
            timer = TIMER;

        if (timer <= 0)
            count = icount;

        if (count == requiredCount)
            complete = true;
        else
            complete = false;

        lcount = icount;
        icount = 0;

        if (requiredCount - count > 0)
            mtext.text = (requiredCount - count).ToString();
        else
            mtext.text = "0";
    }

    private void OnTriggerStay(Collider other) //Runs when moon is within gravity field
    {
        icount++;

        //Apply gravity to moon
        other.transform.LookAt(transform.position);
        var gForce = other.transform.forward * GRAVITY * Time.deltaTime / Mathf.Pow(Vector3.Distance(other.transform.position, transform.position), 2f);
        other.attachedRigidbody.AddForce(gForce, ForceMode.Force);

        //Dampen velocity away from planet
        var localvel = other.transform.InverseTransformDirection(other.attachedRigidbody.velocity);
        if (localvel.z < 0)
        {
            localvel.z *= DAMPING_MULTIPLYER;
            other.attachedRigidbody.velocity = other.transform.TransformDirection(localvel);
        }
    }
}
