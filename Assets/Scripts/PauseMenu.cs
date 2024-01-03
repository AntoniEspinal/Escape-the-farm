using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public static bool isPaused;
    private bool isFirstTime = true;

    // Start is called before the first frame update
    void Start()
    {
        // on start pause menu is not activated 
       pauseMenu.SetActive(false);
    }    

    // Update is called once per frame
    void Update()
    {
        if(isFirstTime)
        {
            ResumeGame();
            isFirstTime = false;
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene("PauseMenu");
            
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

   public void PauseGame()
    {
        // activates the pause menu and freezes game 
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
         // deactivate the pause screen and unfreezes game 
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
     public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

     public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Manor");
    }
        
    
}
