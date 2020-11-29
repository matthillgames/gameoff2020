using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_credits : MonoBehaviour
{
    public script_transition transition;
    public AudioSource sound;
    public void mainMenuButton()
    {
        transition.changeLevel(0);
        sound.Play();
    }
    public void levelSelectButton(int i)
    {
        transition.changeLevel(i);
        sound.Play();
    }
}
