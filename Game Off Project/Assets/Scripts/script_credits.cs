using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_credits : MonoBehaviour
{
    public script_transition transition;
    public void mainMenuButton()
    {
        transition.changeLevel(0);
    }
}
