using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnden = false;
    public Rotator rotator;
    public Spawner Spawner;
    public Animator animator;
   public void EndGame()
    {
        if (gameHasEnden)
            return;
        rotator.enabled = false;
        Spawner.enabled = false;
        animator.SetTrigger("EndGame");
        gameHasEnden = true;
        
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
