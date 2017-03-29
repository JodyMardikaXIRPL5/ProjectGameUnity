using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour {

    private bool gameHasEnded = false;

    public Rotator rotator;
    public Munculkan munculkan;

    public Animator animator;
    
    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        munculkan.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
    }

    public void RestartLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
