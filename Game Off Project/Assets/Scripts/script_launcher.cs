using UnityEngine;

public class script_launcher : MonoBehaviour
{
    public GameObject line;
    public float LINE_MAX_LENGTH = 3f;
    float power = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (line.activeSelf == true)
        {
            drawLine();
        }
    }

    public void OnMouseDown()
    {
        Debug.Log("Click");
        line.SetActive(true);
    }

    public void OnMouseUp()
    {
        Debug.Log("UnClick");
        line.SetActive(false);
    }

    void drawLine() //Draws a line from this object to the mouse pointer
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;
        var lineLength = Mathf.Sqrt(mousePos.x * mousePos.x + mousePos.y * mousePos.y);
        if (lineLength < LINE_MAX_LENGTH)
        {
            line.GetComponent<LineRenderer>().SetPosition(1, mousePos);
            power = lineLength / LINE_MAX_LENGTH;
        }
        else
        {
            var endPos = mousePos / lineLength * LINE_MAX_LENGTH;
            endPos.z = mousePos.z;
            line.GetComponent<LineRenderer>().SetPosition(1, endPos);
            power = 1f;
        }
    }

}
