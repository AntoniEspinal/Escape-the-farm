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

        // unlocks curosr when paused
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true;
    }

    public void ResumeGame()
    {
        // deactivate the pause screen and unfreezes game 
        pauseMenu.SetActive(false);
        Time.timeScale = 0f;
        isPaused = false;

        //locks cursor when game isnt paused
        Cursor.lockState = CursorLockMode.Locked; 
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

    public void ExitGame()
    {

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    
    }
    
}
