using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_mainMenu : MonoBehaviour
{
    public AudioSource sound;
    public script_transition transition;
    int levelIndex = 0;

    // Start is called before the first frame update
    public void PlayButton()
    {
        transition.changeLevel(SceneManager.GetActiveScene().buildIndex + 1);
        sound.Play();
    }
    public void CreditsButton()
    {
        transition.changeLevel(6);
        sound.Play();
    }
    public void LevelSelectButton()
    {
        transition.changeLevel(7);
        sound.Play();
    }
}