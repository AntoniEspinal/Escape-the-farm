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

        Cursor.lockState = CursorLockMode.None; // unlocks curosr when paused
        Cursor.visible = true;
    }

    public void ResumeGame()
    {
        // deactivate the pause screen and unfreezes game 
        pauseMenu.SetActive(false);
        Time.timeScale = 0f;
        isPaused = false;

        Cursor.lockState = CursorLockMode.Locked; //locks cursor when game isnt paused
        Cursor.visible = false;
    }
    public void GoToMainMenu()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Main Menu");
    }
    public void Restart()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("level");
    }
    
}
