using UnityEngine;

public class script_gravity : MonoBehaviour
{
    public float GRAVITY = 5000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        other.transform.LookAt(transform.position);
        other.attachedRigidbody.AddForce(other.transform.forward * GRAVITY * Time.deltaTime / Mathf.Pow(Vector3.Distance(other.transform.position, transform.position),2f), ForceMode.Force);
    }
}
