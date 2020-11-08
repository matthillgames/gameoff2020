using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems

public class script_launcher : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Mouse Click Detected");
    }
}
