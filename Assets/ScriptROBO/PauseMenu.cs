using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
  
            if(GameIsPaused)
            {
                Resume();
            }
            else 
            { Pause(); 
            }
        }
    }




    public void Resume ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameObject.Find("FPSRigi").GetComponent<RigidbodyMovement>().enabled = true;

    }
    
    
    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        GameObject.Find("FPSRigi").GetComponent<RigidbodyMovement>().enabled = false;

    }

    public void LoadMenu ()
    {
        SceneManager.LoadScene(0);
    }


    public void Restart ()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame ()
    {
        Application.Quit(); 
    }




}
