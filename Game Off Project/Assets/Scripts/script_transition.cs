using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_transition : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    int levelIndex;
    
    public void changeLevel(int index)
    {
        levelIndex = index;
        animator.SetTrigger("start");
    }

    public void Finish()
    {
        SceneManager.LoadScene(levelIndex);
    }
}
