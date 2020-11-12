using UnityEngine;

public class script_gravity : MonoBehaviour
{
    public float GRAVITY = 5000f;
    public float DAMPING_FORCE = 500f; //Does nothing yet

    private void OnTriggerStay(Collider other) //Runs when moon is within gravity field
    {
        //Apply gravity to moon
        other.transform.LookAt(transform.position);
        other.attachedRigidbody.AddForce(other.transform.forward * GRAVITY * Time.deltaTime / Mathf.Pow(Vector3.Distance(other.transform.position, transform.position),2f), ForceMode.Force);

        //Dampen velocity away from planet
        var localvel = other.transform.InverseTransformDirection(other.attachedRigidbody.velocity);
        if (localvel.z < 0)
        {
            localvel.z *= .98f;
            other.attachedRigidbody.velocity = other.transform.TransformDirection(localvel);
        }
    }
}
